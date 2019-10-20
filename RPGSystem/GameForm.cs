using RPGSystem.Services;
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
    public partial class GameForm : Form
    {
        public GameForm()
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

        private void btnChangeAmmountOfGoldAndCraftingPieces_Click(object sender, EventArgs e)
        {
            using (ConsumablesConfigurator consumablesConfigurator = new ConsumablesConfigurator())
            {
                if(consumablesConfigurator.ShowDialog(this) == DialogResult.OK)
                {
                    GameDataService.Instance.GameModel.Gold = consumablesConfigurator.Gold;
                    GameDataService.Instance.GameModel.CraftingPieces = consumablesConfigurator.CraftingPieces;
                    UpdateUI();
                }
            }
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void UpdateUI()
        {
            lblAmmountOfGold.Text = GameDataService.Instance.GameModel.Gold.ToString();
            lblAmmountOfCraftingPieces.Text = GameDataService.Instance.GameModel.CraftingPieces.ToString();
        }
    }
}
