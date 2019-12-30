using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPGSystem.Models;

namespace RPGSystem
{
    /// <summary>
    /// Class for PlayerStats user control.
    /// </summary>
    public partial class PlayerStats : UserControl
    {
        public PlayerStats()
        {
            InitializeComponent();
        }

        public PlayerStats(Player player) : this()
        {
            Player = player;
            lblPlayersName.DataBindings.Add("Text", Player, nameof(Player.Name));
            txtPlayersClass.DataBindings.Add("Text", Player, nameof(Player.Class));
            txtPlayersSkills.DataBindings.Add("Text", Player, nameof(Player.Skills));
            txtPlayersItems.DataBindings.Add("Text", Player, nameof(Player.Items));
        }

        public Player Player { get; private set; }

        private void btnEditPlayer_Click(object sender, EventArgs e)
        {
            using (PlayerEditor playerEditor = new PlayerEditor(Player))
            {
                playerEditor.ShowDialog();
            }
        }
    }
}
