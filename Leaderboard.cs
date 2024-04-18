using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectJoc
{
    public partial class Leaderboard : Form
    {
        public class LeaderboardEventArgs : EventArgs
        {
            public List<LeaderboardEntry> LeaderboardEntries { get; set; }

            public LeaderboardEventArgs(List<LeaderboardEntry> leaderboardEntries)
            {
                LeaderboardEntries = leaderboardEntries;
            }
        }

        public class LeaderboardEntry
        {
            public string PlayerName { get; set; }
            public int Score { get; set; }
            public DateTime Timestamp { get; set; }
            public string Dimension { get; set; }
        }
    }
}

