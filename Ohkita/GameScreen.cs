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
    public partial class GameScreen : UserControl
    {
        //button control keys
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown;

        //used to draw hero to screen
        SolidBrush heroBrush = new SolidBrush(Color.Red);
        //used to bullets to the screen
        SolidBrush bulletBrush = new SolidBrush(Color.OrangeRed);

        //used to draw monsters to screen
        SolidBrush monsterBrush = new SolidBrush(Color.DarkRed);
        //used to draw projectiles to the screem
        SolidBrush projectBrush = new SolidBrush(Color.Blue);



        //create a list to hold all bullets on screen
        List<Bullet> bullets = new List<Bullet>();

        //create a list to hold all monsters on screen     
        List<Monster> monsters = new List<Monster>();

        //create a list to hold all projectiles on screen
        List<Projectile> projectiles = new List<Projectile>();


        //create "hero" monster 
        Monster hero;

        Random randGen = new Random();
        int projectX;



        int projectTimer = 0;



        public GameScreen()
        {
            InitializeComponent();
            OnStart();
        }

        public void OnStart()
        {
            //set game start values
            Monster m = new Monster(150, 150, 10, 50);
            monsters.Add(m);

            hero = new Monster(200, 200, 10, 50);
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //button presses
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //button releases
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
            }
        }

        private void GameLoop_Tick(object sender, EventArgs e)
        {
            //move hero            
            if (leftArrowDown)
            {
                hero.Move("left");
            }
            if (rightArrowDown)
            {
                hero.Move("right");
            }
            if (upArrowDown)
            {
                hero.Move("up");
            }
            if (downArrowDown)
            {
                hero.Move("down");
            }


            //causes the hero to fire bullets (automatically)
            foreach (Bullet b in bullets)
            {
                b.y--;
            }



            Refresh();
        }
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //draw monsters to screen
            foreach (Monster m in monsters)
            {
                e.Graphics.FillRectangle(monsterBrush, m.x, m.y, m.size, m.size);
            }

            //draw the "hero" to the screen
            e.Graphics.FillRectangle(heroBrush, hero.x, hero.y, hero.size, hero.size);


            /*  //draw projectiles to the screen
            foreach (Projectile p in projectiles)
            {
                e.Graphics.FillRectangle(projectileBrush, p.x, p.y, p.size, p.size);
            }

            

            //draw the bullets to the screen
            foreach (Bullet b in bullets)
            {
                e.Graphics.FillRectangle(bulletBrush, b.x, b.y, b.size, b.size);
            }*/
        }
    }
}
