using RPGSystem.Services;
using System;
using System.Windows.Forms;

namespace RPGSystem
{
    public partial class ConsumablesConfigurator : Form
    {
        public int Gold { get; private set; }

        public int CraftingPieces { get; private set; }
        
        public ConsumablesConfigurator()
        {
            InitializeComponent();
        }

        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtAmmountOfGold.Text, out var gold) && int.TryParse(txtAmmountOfCraftingPieces.Text, out var pieces))
            {
                Gold = gold;
                CraftingPieces = pieces;
            }
            else
            {
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void ConsumablesConfigurator_Load(object sender, EventArgs e)
        {
            Gold = GameDataService.Instance.GameModel.Gold;
            CraftingPieces = GameDataService.Instance.GameModel.CraftingPieces;

            txtAmmountOfGold.Text = Gold.ToString();
            txtAmmountOfCraftingPieces.Text = CraftingPieces.ToString();
        }
    }
}
