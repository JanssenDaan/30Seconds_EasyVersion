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
    public partial class UCTeam : UserControl
    {
        public Team team = new Team();
        public UCTeam()
        {
            InitializeComponent();
            this.BackColor = Color.Gray;
            
        }

        private void tbxTeamName_TextChanged(object sender, EventArgs e)
        {
            team.TeamName = tbxTeamName.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form1.instance.pnlTeams.Controls.Remove(this);

        }
    }
}
