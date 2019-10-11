using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayerStats playerStats = new PlayerStats();
            flowLayoutPanel1.Controls.Add(playerStats);
        }

        private void DiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiceTool diceTool = new DiceTool();
            diceTool.Show();
        }
    }
}
