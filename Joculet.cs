using System;
using System.Drawing;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Security.Policy;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Schema;
using System.Drawing.Imaging;
using System.IO;
using System.Net;


namespace Joculet
{
    public partial class Joculet : Form
    {
        private const int HexSize = 50;
        private const int HorizontalOffset = 60;
        private const int VerticalOffset = 60;
        private Image startImage;
        private Bitmap doubleBuffer;
        private Graphics bufferGraphics;
        private Image endImage;
        private Image pawnImage;
        private Image obstacleImage;
        private Pawn pawn;
        private bool hasMoved = false;
        private Bitmap buffer;
        private HashSet<Point> obstacles;
        private HashSet<Point> visitedHexagons = new HashSet<Point>();
        private List<PointF> pawnTrail;
        private List<Point> availableMoves;
        private int score = 0;
        private int totalHexagons = 0;
        private TimeSpan remainingTime;
        private bool isFirstMove = true;
        private System.Windows.Forms.Timer timer;
        private const int TotalSeconds = 300;
        private int endPointCol;
        private int endPointRow;
        private Point startPoint = new Point(0, 4); // Declare startPoint as a field
        private Point endPoint = new Point(8, 4); // Declare endPoint as a field
        private HashSet<Point> fixedRouteWithoutObstacles = new HashSet<Point>();
        private List<Point> staticRoute;

        public Joculet()
        {
            InitializeComponent();

            Controls.Add(panel1);
            pawn = new Pawn(4, 0);
            pawnTrail = new List<PointF>();
            panel1.PreviewKeyDown += panel1_PreviewKeyDown;
            panel1.Focus();
            buffer = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
            

            scoreLabel.Text = "Score: 0";
            scoreLabel.Location = new Point(1100, 240);
            Point startPoint = new Point(0, 4);
            Point endPoint = new Point(8, 4);
            totalHexagons = 9 * 9;
            
            availableMoves = new List<Point>();
            Label mesajpion = new Label();
            Label countdownLabel = new Label();
            Label inchidejocin = new Label();
            mesajpion.Text = "";



            mesajpion.Visible = false;
            mesajpion.AutoSize = true;

            countdownLabel.Text = "";
            countdownLabel.Visible = false;
            inchidejocin.Visible = false;
            countdownLabel.AutoSize = true;

            timer = new System.Windows.Forms.Timer();

            // Set the interval to 1 second (1000 milliseconds)
            timer.Interval = 1000;

            // Attach an event handler for the Tick event
            timer.Tick += Timer_Tick;

            this.Controls.Add(mesajpion);
            this.Controls.Add(countdownLabel);
            Button exportButton = new Button();
            exportButton.Text = "Export";
            exportButton.Location = new Point(1100, 160);
            exportButton.Click += exportButton_Click; // Adaugă evenimentul click pentru buton

            // Adaugă butonul în panel1 (sau în containerul adecvat)
            this.Controls.Add(exportButton);

            System.Windows.Forms.Timer countdownTimer = new System.Windows.Forms.Timer();

            countdownTimer.Interval = 1000; // 1 second
            countdownTimer.Tick += countdownTimer_Tick_1;
            panel1.Paint += new PaintEventHandler(panel1_Paint_1);
            obstacles = GenerateRandomObstacles(startPoint, endPoint);
            InitializeGame();

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            try
            {
                Graphics graphics = e.Graphics;
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                

                DrawHexagonalChessBoard(graphics);
                
            }
            catch (Exception ex)
            {
                // Handle the exception here, e.g., display an error message
                MessageBox.Show($"An error occurred while painting the panel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DrawPawn(Graphics graphics, Brush brush, double x, double y, int size)
        {

            float pawnSize = size * 1.3f;
            graphics.DrawImage(pawnImage, (float)x - pawnSize / 2, (float)y - pawnSize / 2, pawnSize, pawnSize);

        }

        private void DrawStartPoint(Graphics graphics, Brush brush, double x, double y, int size)
        {
            PointF startPoint = GetHexagonCenter(0, 4, size);
            float imageSize = size * 1.3f; // Adjust the image size as needed
            DrawHexagon1(graphics, Pens.Transparent, Brushes.Transparent, x, y, size); // Draw the transparent hexagon shape
            graphics.DrawImage(startImage, startPoint.X - imageSize / 2, startPoint.Y - imageSize / 2, imageSize, imageSize);
        }

        private void DrawEndPoint(Graphics graphics, Brush brush, double x, double y, int size)
        {
            PointF endPoint = GetHexagonCenter(8, 4, size);
            float imageSize = size * 1.3f;
            DrawHexagon1(graphics, Pens.Transparent, Brushes.Transparent, x, y, size);
            graphics.DrawImage(endImage, endPoint.X - imageSize / 2, endPoint.Y - imageSize / 2, imageSize, imageSize);
        }

        private void DrawHexagon1(Graphics graphics, Pen pen, Brush brush, double x, double y, int size)
        {
            PointF[] hexagonPoints = GetHexagonPoints(x, y, size);

            graphics.FillPolygon(brush, hexagonPoints);
            graphics.DrawPolygon(pen, hexagonPoints);
        }

        private PointF[] GetHexagonPoints(double x, double y, int size)
        {
            PointF[] hexagonPoints = new PointF[6];
            double angle = 2.0 * Math.PI / 6;
            double angleOffset = Math.PI / 6;

            for (int i = 0; i < 6; i++)
            {
                double theta = angle * i + angleOffset;
                float hx = (float)x + size * (float)Math.Cos(theta);
                float hy = (float)y + size * (float)Math.Sin(theta);
                hexagonPoints[i] = new PointF(hx, hy);
            }

            return hexagonPoints;
        }

        private void DrawHexagonalChessBoard(Graphics graphics)
        {
            int rowCount = 9;
            int colCount = 9;


            // Specify the font properties for the individual score text
            Font font = new Font("Impact", 10, FontStyle.Bold);
            Brush brush = Brushes.Yellow;

            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < colCount; col++)
                {
                    PointF center = GetHexagonCenter(col, row, HexSize);

                    if (row + col > 3 && row + col < 13)
                    {
                        double x = center.X;
                        double y = center.Y;

                        if (col == 0 && row == 4)
                        {
                            DrawHexagon1(graphics, Pens.Black, Brushes.DarkGray, x, y, HexSize);
                            DrawStartPoint(graphics, Brushes.White, x, y, HexSize);
                        }
                        else if (col == 8 && row == 4)
                        {
                            DrawHexagon1(graphics, Pens.Black, Brushes.DarkGray, x, y, HexSize);
                            DrawEndPoint(graphics, Brushes.White, x, y, HexSize);
                            endPointCol = col;
                            endPointRow = row;
                        }
                        else
                        {
                            Brush hexagonBrush = Brushes.DarkGray;

                            // Check if the hexagon has been visited by the pawn

                            if (fixedRouteWithoutObstacles.Contains(new Point(col, row)) || staticRoute.Contains(new Point(col, row)))
                            {
                                // Draw the hexagon without obstacles or on the static route
                                Brush fillColor = staticRoute.Contains(new Point(col, row))
                                    ? Brushes.LightGreen // Hexagon on the static route
                                    : Brushes.LightBlue; // Hexagon without obstacles

                                DrawHexagon1(graphics, Pens.Black, fillColor, x, y, HexSize);

                                if (visitedHexagons.Contains(new Point(col, row)))
                                {
                                    DrawHexagon1(graphics, Pens.Black, Brushes.Orange, x, y, HexSize);
                                }
                            }
                            else if (visitedHexagons.Contains(new Point(col, row)))
                            {
                                hexagonBrush = Brushes.Orange;
                                DrawHexagon1(graphics, Pens.Black, Brushes.Orange, x, y, HexSize);

                            }
                            else if (obstacles.Contains(new Point(row, col)))
                            {
                                // Draw the hexagon with obstacles
                                DrawHexagon1(graphics, Pens.Black, Brushes.DarkGray, x, y, HexSize);
                                float imageSize = HexSize * 1.3f;
                                float imageX = (float)(x - imageSize / 2);
                                float imageY = (float)(y - imageSize / 2);
                                graphics.DrawImage(obstacleImage, imageX, imageY, imageSize, imageSize);
                            }
                            else
                            {
                                DrawHexagon1(graphics, Pens.Black, hexagonBrush, x, y, HexSize);
                            }
                        }

                        if (col == pawn.Col && row == pawn.Row)
                        {
                            DrawPawn(graphics, Brushes.White, x, y, HexSize);
                        }
                    }
                }
            }
        }


        private HashSet<Point> GenerateRandomObstacles(Point startPoint, Point endPoint)
        {
            HashSet<Point> obstacles = new HashSet<Point>();
            Random random = new Random();
            int numObstacles = random.Next(20, 50);

            for (int i = 0; i < numObstacles; i++)
            {
                Point obstaclePoint;
                bool isStartOrEndpoint;

                do
                {
                    int row = random.Next(0, 9);
                    int col = random.Next(0, 9);
                    obstaclePoint = new Point(col, row);
                    isStartOrEndpoint = obstaclePoint.Equals(startPoint) || obstaclePoint.Equals(endPoint);
                }
                while (isStartOrEndpoint || obstacles.Contains(obstaclePoint));

                obstacles.Add(obstaclePoint);
            }

            return obstacles;
        }
        

        private PointF GetHexagonCenter(int col, int row, int size)
        {
            double x = 1.75 * HorizontalOffset + 1.75 * size * col + 1.75 * (size / 2 * row);
            double y = 1.55 * VerticalOffset + 1.53 * size * row;

            return new PointF((float)x, (float)y);
        }



        public class Pawn
        {
            public int Row { get; set; }
            public int Col { get; set; }

            public Pawn(int row, int col)
            {
                Row = row;
                Col = col;
            }
        }



        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            DrawHexagonalChessBoard(graphics);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            buffer = new Bitmap(ClientSize.Width, ClientSize.Height);
            Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            MessageBox.Show("Make the first move to start the timer");
        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private bool CheckEndGameCondition()
        {
            return pawn.Col == 8 && pawn.Row == 4;
            int visitedHexagonCount = visitedHexagons.Count;
            score = visitedHexagonCount * 10; // Assigning 10 points per visited hexagon

            return (visitedHexagonCount == totalHexagons);
        }



        private void UpdateAvailableMoves()
        {
            availableMoves.Clear();

            int currentCol = pawn.Col;
            int currentRow = pawn.Row;
            scoreLabel.Text = "Score: " + score.ToString();
            scoreLabel.Location = new Point(1100, 250);

            // Check all possible neighboring positions and add them to available moves if valid
            for (int dRow = -1; dRow <= 1; dRow++)
            {
                for (int dCol = -1; dCol <= 1; dCol++)
                {
                    int newRow = currentRow + dRow;
                    int newCol = currentCol + dCol;

                    if (IsWithinMapBounds(newRow, newCol) && !obstacles.Contains(new Point(newRow, newCol)))
                    {
                        availableMoves.Add(new Point(newRow, newCol));
                    }
                }
            }

            // Add the route hexagons as available moves
            foreach (PointF point in pawnTrail)
            {
                int row = (int)point.Y;
                int col = (int)point.X;

                if (IsWithinMapBounds(row, col) && !obstacles.Contains(new Point(row, col)) && !visitedHexagons.Contains(new Point(col, row)))
                {
                    availableMoves.Add(new Point(row, col));
                }
            }

            // Add the endpoint as an available move
            availableMoves.Add(endPoint);
        }
        private bool IsWithinMapBounds(int row, int col)
        {
            // Calculate the sum of row and column
            int sum = row + col;

            // Check if the sum is within the map boundary
            if (sum < 4 || sum > 12)
                return false;

            // Check if the row and column are within their respective boundaries
            return row >= 0 && row < 9 && col >= 0 && col < 9;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.A || keyData == Keys.S || keyData == Keys.Q || keyData == Keys.X)
            {
                // Handle pawn movement based on the arrow key pressed
                MovePawn(keyData);
                return true;
            }
            else if (keyData == Keys.W)
            {
                // Handle oblique movement: Right-Up
                MovePawn(Keys.W);
                return true;
            }
            else if (keyData == Keys.Z)
            {
                // Handle oblique movement: Left-Down
                MovePawn(Keys.Z);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void panel1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.S || e.KeyCode == Keys.Q || e.KeyCode == Keys.X || e.KeyCode == Keys.Z || e.KeyCode == Keys.W)
            {
                // Handle pawn movement based on the arrow key pressed
                MovePawn(e.KeyCode);
                e.IsInputKey = true; // Ensure the arrow key is recognized as an input key
            }
        }

        private void MovePawn(Keys keyCode)
        {
            int currentCol = pawn.Col;
            int currentRow = pawn.Row;
            int newCol = currentCol;
            int newRow = currentRow;
            visitedHexagons.Add(new Point(newCol, newRow));

            score += 10; // Add 10 points for each visited hexagon

            if (isFirstMove)
            {

                // Start the timer
                timer.Start();

                // Set the initial remaining time (5 minutes)
                remainingTime = TimeSpan.FromSeconds(TotalSeconds);

                // Update the timer label to display the initial remaining time
                timerLabel.Text = "Timp ramas" + remainingTime.ToString(@"mm\:ss");
                timerLabel.Location = new Point(1100, 200);
                isFirstMove = false;
            }
            // Calculate the potential new column and row based on the arrow key pressed
            if (keyCode == Keys.A)
            {
                newCol--;
            }
            else if (keyCode == Keys.S)
            {
                newCol++;
            }
            else if (keyCode == Keys.Q)
            {
                newRow--;
            }
            else if (keyCode == Keys.X)
            {
                newRow++;
            }
            else if (keyCode == Keys.W)
            {
                // Oblique movement: Right-Up
                newCol++;
                newRow--;
            }
            else if (keyCode == Keys.Z)
            {
                // Oblique movement: Left-Down
                newCol--;
                newRow++;
            }
            mesajpion.Location = new Point(1100, 400);
            if (newCol == 8 && newRow == 4)
            {
                // Update the pawn's position
                pawn.Col = newCol;
                pawn.Row = newRow;

                // Add the new position to the pawn's trail
                pawnTrail.Add(new PointF(currentCol, currentRow));

                // Mark the hexagon as visited
                visitedHexagons.Add(new Point(newCol, newRow));

                // Update the available moves
                UpdateAvailableMoves();

                // Display the end game message and perform necessary actions
                mesajpion.Text = "Felicitari ai ajuns la final";
                mesajpion.Visible = true;
                countdownTimer.Interval = 1000; // 1 second
                countdownLabel.Location = new Point(1460, 450);
                countdownLabel.Text = "5";
                countdownLabel.Visible = true;
                countdownTimer.Start();
                inchidejocin.Location = new Point(1100, 450); ;
                inchidejocin.Text = "Jocul se inchide in:";
                inchidejocin.Visible = true;
            }
            else if (IsWithinMapBounds(newRow, newCol))
            {
                // Check if the new position is not blocked by an obstacle
                if (!obstacles.Contains(new Point(newRow, newCol)))
                {
                    // Check if the new position is not a visited hexagon
                    if (!visitedHexagons.Contains(new Point(newCol, newRow)))
                    {
                        // Check if there is at least one neighboring hexagon that is not visited
                        bool hasValidNeighbor = false;

                        // Check the neighboring hexagons
                        if (IsWithinMapBounds(newRow - 1, newCol) && !visitedHexagons.Contains(new Point(newCol, newRow - 1)) && !obstacles.Contains(new Point(newRow - 1, newCol)))
                        {
                            hasValidNeighbor = true;
                        }
                        else if (IsWithinMapBounds(newRow + 1, newCol) && !visitedHexagons.Contains(new Point(newCol, newRow + 1)) && !obstacles.Contains(new Point(newRow + 1, newCol + 1)))
                        {
                            hasValidNeighbor = true;
                        }
                        else if (IsWithinMapBounds(newRow, newCol - 1) && !visitedHexagons.Contains(new Point(newCol - 1, newRow)) && !obstacles.Contains(new Point(newRow, newCol - 1)))
                        {
                            hasValidNeighbor = true;
                        }
                        else if (IsWithinMapBounds(newRow, newCol + 1) && !visitedHexagons.Contains(new Point(newCol + 1, newRow)) && !obstacles.Contains(new Point(newRow, newCol + 1)))
                        {
                            hasValidNeighbor = true;
                        }
                        else if (IsWithinMapBounds(newRow - 1, newCol + 1) && !visitedHexagons.Contains(new Point(newCol + 1, newRow - 1)) && !obstacles.Contains(new Point(newRow - 1, newCol + 1)))
                        {
                            hasValidNeighbor = true;
                        }
                        else if (IsWithinMapBounds(newRow + 1, newCol - 1) && !visitedHexagons.Contains(new Point(newCol - 1, newRow + 1)) && !obstacles.Contains(new Point(newRow + 1, newCol - 1)))
                        {
                            hasValidNeighbor = true;
                        }

                        if (hasValidNeighbor)
                        {
                            // Update the pawn's position
                            pawn.Col = newCol;
                            pawn.Row = newRow;

                            // Add the new position to the pawn's trail
                            pawnTrail.Add(new PointF(currentCol, currentRow));

                            // Mark the hexagon as visited
                            visitedHexagons.Add(new Point(newCol, newRow));

                            // Update the available moves
                            UpdateAvailableMoves();

                            // Check if the game has reached the end condition
                            if (CheckEndGameCondition())
                            {
                                mesajpion.Text = "Felicitari ai ajuns la final";
                                mesajpion.Visible = true;
                                countdownTimer.Interval = 1000; // 1 second
                                countdownLabel.Location = new Point(1460, 450);
                                countdownLabel.Text = "5";
                                countdownLabel.Visible = true;
                                countdownTimer.Start();
                                inchidejocin.Location = new Point(1100, 450); ;
                                inchidejocin.Text = "Jocul se inchide in:";
                                inchidejocin.Visible = true;
                            }
                        }
                        else
                        {
                            // The pawn is stuck because there are no valid neighboring hexagons
                            pawn.Col = newCol;
                            pawn.Row = newRow;
                            panel1.Refresh();
                            visitedHexagons.Add(new Point(newCol, newRow));
                            mesajpion.Text = "Nu mai ai unde muta cumetre!";
                            mesajpion.Visible = true;
                            countdownTimer.Interval = 1000; // 1 second
                            countdownLabel.Location = new Point(1460, 450); ;
                            countdownLabel.Text = "5";
                            countdownLabel.Visible = true;
                            countdownTimer.Start();
                            inchidejocin.Location = new Point(1100, 450);

                            inchidejocin.Text = "Jocul se inchide in:";
                            inchidejocin.Visible = true;
                        }
                    }
                    else
                    {
                        // The pawn is stuck because the new position is already visited
                        mesajpion.Text = "E cam blocat...";
                        mesajpion.Visible = true;

                    }
                }
                else
                {
                    // The pawn is stuck because the new position is blocked by an obstacle
                    mesajpion.Text = "Obstacol!";
                    mesajpion.Visible = true;
                }
            }
            else
            {
                // The pawn is stuck because the new position is outside the map bounds
                mesajpion.Text = "Afara de pe harta!";
                mesajpion.Visible = true;
            }
            panel1.Invalidate();
        }
        private void countdownTimer_Tick_1(object sender, EventArgs e)
        {
            int countdownValue = int.Parse(countdownLabel.Text);

            // Decrement the countdown value
            countdownValue--;

            if (countdownValue <= 0)
            {
                // Stop the countdown timer
                countdownTimer.Stop();

                // Exit the game
                Application.Exit();
            }
            else
            {
                // Update the countdown label
                countdownLabel.Text = countdownValue.ToString();
            }
        }

        private void InitializeGame()
        {
            // ... your existing code for initializing the game ...

            // Add the starting point to the visited hexagons
            visitedHexagons.Add(new Point(pawn.Col, pawn.Row));
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update the remaining time
            remainingTime = remainingTime.Subtract(TimeSpan.FromSeconds(1));

            // Update the timer label to display the remaining time
            timerLabel.Text = "Timp ramas:" + remainingTime.ToString(@"mm\:ss");

            // Check if the countdown has reached zero
            if (remainingTime.TotalSeconds <= 0)
            {

                timer.Stop();

            }
        }


        private void exportButton_Click(object sender, EventArgs e)
        {


            // Create a new bitmap with the size of the panel
            Bitmap bitmap = new Bitmap(panel1.Width, panel1.Height);

            // Capture the content of the panel into the bitmap
            panel1.DrawToBitmap(bitmap, new Rectangle(0, 0, panel1.Width, panel1.Height));



            // Obține calea folderului și numele de fișier cu timestamp
            string folderPath = "C:\\Users\\admin\\source\\repos\\Joculet\\maps"; // Înlocuiește cu calea dorită
            string fileName = "harta_" + DateTime.Now.ToString("yyyy/MM/dd/HH/mm/ss") + ".png";

            // Concatenează calea folderului cu numele fișierului
            string filePath = Path.Combine(folderPath, fileName);

            // Salvează imaginea în folderul ales
            bitmap.Save(filePath, ImageFormat.Png);
        }

    }
}