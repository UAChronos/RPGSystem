using RPGSystem.Models;
using RPGSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

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

        public Player Player { get; private set; }
        /// <summary>
        /// Event handler that executes when user clicks on Add Player tool strip menu item. 
        /// </summary>
        ///<para>Add player on game board.</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayerStats playerStats = new PlayerStats(GameDataService.Instance.GameModel.CreateNewPlayer());
            using (PlayerEditor playerEditor = new PlayerEditor(playerStats.Player))
            {
                playerEditor.ShowDialog();
            }
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
                if (consumablesConfigurator.ShowDialog(this) == DialogResult.OK)
                {
                    GameDataService.Instance.GameModel.Gold = consumablesConfigurator.Gold;
                    GameDataService.Instance.GameModel.CraftingPieces = consumablesConfigurator.CraftingPieces;
                    UpdateUI(false);
                }
            }
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            UpdateUI(false);
        }

        private void UpdateUI(bool isFullUpdate)
        {
            lblAmmountOfGold.Text = GameDataService.Instance.GameModel.Gold.ToString();
            lblAmmountOfCraftingPieces.Text = GameDataService.Instance.GameModel.CraftingPieces.ToString();
            if (isFullUpdate == true)
            {
                flowLayoutPanel1.Controls.Clear();
                flowLayoutPanel1.Controls.AddRange(GameDataService.Instance.GameModel.Players.Select(p => new PlayerStats(p)).ToArray());

                //foreach (Player p in GameDataService.Instance.GameModel.Players)
                //{
                //    PlayerStats playerStats = new PlayerStats(p);
                //    flowLayoutPanel1.Controls.Add(playerStats);
                //}
            }
        }

        protected string filePath; 
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    DialogResult result = saveFileDialog.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        string fileName = saveFileDialog.FileName;
                        GameDataService.Instance.SaveToXml(fileName);
                    }
                }
            }
            else
            {
                GameDataService.Instance.SaveToXml(filePath);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                DialogResult result = saveFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;
                    GameDataService.Instance.SaveToXml(fileName);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                DialogResult result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;
                    GameDataService.Instance.LoadFromXml(fileName);
                    UpdateUI(true);
                    filePath = fileName;
                }
            }
        }
    }
}
