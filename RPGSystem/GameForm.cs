using RPGSystem.Models;
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
    /// <summary>
    /// Class for GameForm form.
    /// </summary>
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler that executes when user clicks on Add Player tool strip menu item. 
        /// </summary>
        ///<para>Add player on game board.</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayerStats playerStats = new PlayerStats(GameDataService.Instance.GameModel.CreateNewPlayer());
            flowLayoutPanel1.Controls.Add(playerStats);
        }

        /// <summary>
        /// Event handler that executes when user clicks on Dice Tool strip menu item.
        ///<para>Shows dice tool.</para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
