using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ohkita
{
    public partial class InstructionsScreen : UserControl
    {
        public InstructionsScreen()
        {
            InitializeComponent();
        }
      
        private void playButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, "GameScreen");
        }
    }
}
