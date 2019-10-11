using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGSystem
{
    public partial class PlayerStats : UserControl
    {
        public PlayerStats()
        {
            InitializeComponent();
        }

        private void TxtPlayersClass_DoubleClick(object sender, EventArgs e)
        {
            txtPlayersClass.BorderStyle = BorderStyle.Fixed3D;
            txtPlayersClass.BorderColor = Color.Red;
            txtPlayersClass.ReadOnly = false;
        }

        private void TxtPlayersClass_MouseLeave(object sender, EventArgs e)
        {
            txtPlayersClass.BorderStyle = BorderStyle.None;
            txtPlayersClass.ReadOnly = true;
        }

        private void TxtPlayersSkills_MouseLeave(object sender, EventArgs e)
        {
            txtPlayersSkills.BorderStyle = BorderStyle.None;
            txtPlayersSkills.ReadOnly = true;
        }

        private void TxtPlayersSkills_DoubleClick(object sender, EventArgs e)
        {
            txtPlayersSkills.BorderStyle = BorderStyle.Fixed3D;
            txtPlayersSkills.BorderColor = Color.Red;
            txtPlayersSkills.ReadOnly = false;
        }

        private void TxtPlayersItems_MouseLeave(object sender, EventArgs e)
        {
            txtPlayersItems.BorderStyle = BorderStyle.None;
            txtPlayersItems.ReadOnly = true;
        }

        private void TxtPlayersItems_DoubleClick(object sender, EventArgs e)
        {
            txtPlayersItems.BorderStyle = BorderStyle.Fixed3D;
            txtPlayersItems.BorderColor = Color.Red;
            txtPlayersItems.ReadOnly = false;
        }
    }
}
