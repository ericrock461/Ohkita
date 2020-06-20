using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ohkita
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Cursor.Hide();

            //create and open the menu upon loading game
            Menu ms = new Menu();
            this.Controls.Add(ms);
        }

        public static void ChangeScreen(UserControl current, string next)
        {
            //f is set to the form that the current control is on
            Form f = current.FindForm();
            f.Controls.Remove(current);
            UserControl ns = null;

            ///If any screens, (UserControls), are added to the program they need to
            ///be added within this switch block as well.
            switch (next)
            {
                case "MenuScreen":
                    ns = new Menu();
                    break;
                case "GameScreen":
                    ns = new GameScreen();
                    break;             
                case "Instructions":
                    ns = new InstructionsScreen();
                    break;
                case "ResultsScreen":
                    ns = new ResultsScreen();
                    break;
            }

            //centres the control on the screen
            ns.Location = new Point((f.Width - ns.Width) / 2, (f.Height - ns.Height) / 2);

            f.Controls.Add(ns);
            ns.Focus();
        }
    }
}
