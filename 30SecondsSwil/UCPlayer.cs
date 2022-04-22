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
    public partial class UCPlayer : UserControl
    {
        public Player player = new Player();
        public List<UCTeam> teamList = new List<UCTeam>();
        public UCPlayer()
        {
            InitializeComponent();
        }

        private void tbxPlayerName_TextChanged(object sender, EventArgs e)
        {
            player.Playername = tbxPlayerName.Text;
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            cdlColor.ShowDialog();
            this.BackColor = cdlColor.Color;
            player.color = cdlColor.Color;
        }

        private void cbxSelectTeam_Click(object sender, EventArgs e)
        {
            cbxSelectTeam.Items.Clear();
            teamList.Clear();
            teamList = Form1.instance.pnlTeams.Controls.OfType<UCTeam>().ToList(); ;
            foreach (UCTeam uc in teamList)
            {
                cbxSelectTeam.Items.Add(uc.team.TeamName);
            }
        }

        private void cbxSelectTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.TeamName = cbxSelectTeam.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form1.instance.pnlPlayers.Controls.Remove(this);
        }
    }
}
