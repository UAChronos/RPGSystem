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

        private void BtnThrewADice_Click(object sender, EventArgs e)
        {
            Random threwReuslt = new Random();
            lblThrowResult.Text = $"{threwReuslt.Next(1, 6)}";
            lblThrowResult.Font = new Font("Monotype Corsiva", 100F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204))); ;
        }
    }
}
