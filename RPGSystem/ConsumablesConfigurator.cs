using RPGSystem.Services;
using System;
using System.Windows.Forms;

namespace RPGSystem
{
    /// <summary>
    /// This is class for ConsumablesConfigurator form.
    /// </summary>
    public partial class ConsumablesConfigurator : Form
    {
        /// <summary>
        /// Property that stores gold ammount
        /// </summary>
        public int Gold { get; private set; }
        /// <summary>
        /// Property that stores ammount of crafting pieces
        /// </summary>
        public int CraftingPieces { get; private set; }
        
        public ConsumablesConfigurator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// btnSubmit_Click is an event handler that executes when user clicks the button on form.
        /// </summary>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (int.TryParse(numAmmountOfGold.Text, out var gold) && int.TryParse(numAmmountOfCraftingPieces.Text, out var pieces))
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
        /// <summary>
        /// ConsumablesConfigurator_Load is an event handler that executes on form load.
        /// </summary>
        private void ConsumablesConfigurator_Load(object sender, EventArgs e)
        {
            Gold = GameDataService.Instance.GameModel.Gold;
            CraftingPieces = GameDataService.Instance.GameModel.CraftingPieces;

            numAmmountOfGold.Value = Gold;
            numAmmountOfCraftingPieces.Value = CraftingPieces;
        }
    }
}
