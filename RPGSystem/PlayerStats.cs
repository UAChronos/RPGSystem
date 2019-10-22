using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPGSystem.Models;

namespace RPGSystem
{
    /// <summary>
    /// Class for PlayerStats user control.
    /// </summary>
    public partial class PlayerStats : UserControl
    {
        public PlayerStats()
        {
            InitializeComponent();
        }

        public PlayerStats(Player player) : this()
        {

        }
    }
}
