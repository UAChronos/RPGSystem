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
    public partial class DiceTool : Form
    {
        public DiceTool()
        {
            InitializeComponent();
        }

        private RandomNumberGenerator randomNumberGenerator = new RandomNumberGenerator();
        private void BtnThrewADice_Click(object sender, EventArgs e)
        {
            lblThrowResult.Text = $"{randomNumberGenerator.NumberGenerator(1,6)}";
            lblThrowResult.Font = new Font("Monotype Corsiva", 100F, (FontStyle.Bold | FontStyle.Italic), GraphicsUnit.Point, 204); ;
        }
    }
}
