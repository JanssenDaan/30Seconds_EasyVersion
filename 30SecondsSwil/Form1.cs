using DjanControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30SecondsSwil
{
    public partial class Form1 : Form
    {
        public static new Form1 instance { get; set; }
        public UCTeam ucTeam = new UCTeam();
        public UCPlayer ucPlayer = new UCPlayer();
        public int teamCounter { get; set; }
        public int playerCounter { get; set; }
        public Helpers Helper = new Helpers();

        public Form1()
        {
            InitializeComponent();
            instance = this;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            ucTeam = new UCTeam();
            ucTeam.team.TeamName = $"Team {teamCounter}";
            ucTeam.tbxTeamName.Text = $"Team {teamCounter}";
            pnlTeams.Controls.Add(ucTeam);
            teamCounter++;
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            ucPlayer = new UCPlayer();
            ucPlayer.player.Playername = $"Player: {playerCounter}";
            ucPlayer.tbxPlayerName.Text = $"Player: {playerCounter}";
            ucPlayer.BackColor = Helper.GetRandomColor();
            pnlPlayers.Controls.Add(ucPlayer);
            playerCounter++;
        }
    }
}
