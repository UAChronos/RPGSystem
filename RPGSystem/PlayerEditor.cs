using RPGSystem.Models;
using System;
using System.Windows.Forms;

namespace RPGSystem
{
    public partial class PlayerEditor : Form
    {
        public PlayerEditor()
        {
            Player = new Player();
            InitializeComponent();
        }

        public PlayerEditor(Player player) : this()
        {
            Player = player;
            txtPlayersName.Text = Player.Name;
            txtPlayersSkills.Text = Player.Skills;
            txtPlayersClass.Text = Player.Class;
            txtPlayersItems.Text = Player.Items;
        }

        public Player Player { get; private set; }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Player.Name = txtPlayersName.Text.Trim();
            Player.Class = txtPlayersClass.Text.Trim();
            Player.Skills = txtPlayersSkills.Text.Trim();
            Player.Items = txtPlayersItems.Text.Trim();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
