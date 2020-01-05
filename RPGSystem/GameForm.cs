using RPGSystem.Models;
using RPGSystem.Services;
using System;
using System.Data;
using System.IO;
using System.Linq;
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
            }
        }

        private void SaveAs()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "DTB files(*.xml;*.json)|*.xml;*.json;|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                DialogResult result = saveFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;
                    fileExtension = Path.GetExtension(fileName);
                    if (fileExtension == ".xml")
                    {
                        GameDataService.Instance.SaveToXml(fileName);
                    }
                    else
                    {
                        GameDataService.Instance.SaveToJson(fileName);
                    }
                }
            }
        }

        private void Save()
        {
            if (fileExtension == ".xml")
            {
                GameDataService.Instance.SaveToXml(filePath);
            }
            else
            {
                GameDataService.Instance.SaveToJson(filePath);
            }
        }

        private string filePath;
        private string fileExtension;
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                SaveAs();
            }
            else
            {
                Save();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "DTB files(*.xml;*.json)|*.xml;*.json;|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                DialogResult result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;
                    fileExtension = Path.GetExtension(fileName);
                    if (fileExtension == ".xml")
                    {
                        GameDataService.Instance.LoadFromXml(fileName);
                    }
                    else
                    {
                        GameDataService.Instance.LoadFromJson(fileName);
                    }
                    UpdateUI(true);
                    filePath = fileName;
                }
            }
        }
    }
}
