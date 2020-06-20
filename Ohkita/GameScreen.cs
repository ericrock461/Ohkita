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
    //NOTE: After coding the hero and its bullets, I'm just now realizing...
    //maybe I should have called the bullets (from hero) projectiles, and
    //the projectiles (from enemies) bullets!
    //Oh well... for now the hero gets bullets and the enemies projectiles


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
        SolidBrush projectileBrush = new SolidBrush(Color.Blue);



        //create a list to hold all bullets on screen
        List<Bullet> bullets = new List<Bullet>();

        //create a list to hold all monsters on screen     
        List<Monster> monsters = new List<Monster>();

        //create a list to hold all projectiles on screen
        List<Projectile> projectiles = new List<Projectile>();


        //create "hero" monster 
        Monster hero;

        //determines when bullets will fire
        int bulletTimer = 0;


        //Random randGen = new Random();
        //int projectX;
        int projecTimer = 0;



        public GameScreen()
        {
            InitializeComponent();
            OnStart();
        }

        public void OnStart()
        {
            //set game start values
            Monster m = new Monster(300, 50, 20, 25);
            monsters.Add(m);

            hero = new Monster(400, 300, 20, 50);
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


            //Bullets
            bulletTimer++;

            //causes the hero to fire bullets (automatically)
            if (bulletTimer == 3)
            {
                Bullet b = new Bullet(hero.x + 5, hero.y + 5, 10);
                bullets.Add(b);

                bulletTimer = 0;
            }

            foreach (Bullet b in bullets)
            {
                b.y = b.y - 15;
            }


            //Projectiles
            projecTimer++;

            if (projecTimer == 8)
            {
                foreach (Monster m in monsters)
                {
                    Projectile p = new Projectile(m.x + 5, m.y + 5, 15);
                    projectiles.Add(p);
                }

                projecTimer = 0;
            }

            foreach (Projectile p in projectiles)
            {
                p.y = p.y + 8;
            }


            //Collision
            /*foreach (Monster m in monsters)
            {
                if (m.Collision)
                {
                    BulletsMonstersCollision()
                }
            }*/




            Refresh();
        }



        //So as it turns out, there was code on OneNote for how to do collision involving
        //multiple objects against multiple objects. And it uses the exact same classes that
        //I'm using!!!
        //...but I don't really understand it...


        /*public void BulletsMonstersCollision()
        {
            //will contain index values of all bullets that have collided with a monster 
            List<int> bulletsToRemove = new List<int>();

            //will contain index values of all monsters that have collided with a bullet 
            List<int> monstersToRemove = new List<int>();
            foreach (Bullet b in bullets)
            {
                foreach (Monster m in monsters)
                {
                    //uses collision method in monster class and returns true 
                    //if monster 'm' has collided with bullet 'b' 
                    if (m.Collision(b))
                    {
                        //checks to make sure that the bullet is not already in removal list 
                        if (!bulletsToRemove.Contains(bullets.IndexOf(b)))
                        {
                            //add the index value from bullets of the bullet that collided  
                            bulletsToRemove.Add(bullets.IndexOf(b));
                        }

                        //checks to make sure that the monster is not already in removal list 
                        if (!monstersToRemove.Contains(monsters.IndexOf(m)))

                        {

                            //add the index value from monsters of the monster that collided 

                            monstersToRemove.Add(monsters.IndexOf(m));
                        }
                    }
                }
            }

            //reverse lists so when removing you do so from the end of the list first 
            bulletsToRemove.Reverse();
            monstersToRemove.Reverse();

            foreach (int i in bulletsToRemove)
            {
                bullets.RemoveAt(i);
            }
            foreach (int i in monstersToRemove)
            {
                monsters.RemoveAt(i);
            }
        }*/


        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //draw monsters to screen
            foreach (Monster m in monsters)
            {
                e.Graphics.FillRectangle(monsterBrush, m.x, m.y, m.size, m.size);
            }

            //draw the "hero" to the screen
            e.Graphics.FillRectangle(heroBrush, hero.x, hero.y, hero.size, hero.size);

            //draw bullets to the screen
            foreach (Bullet b in bullets)
            {
                e.Graphics.FillRectangle(bulletBrush, b.x, b.y, b.size, b.size);
            }

            
            //draw projectiles to the screen
            foreach (Projectile p in projectiles)
            {
                e.Graphics.FillRectangle(projectileBrush, p.x, p.y, p.size, p.size);
            }
        }
    }
}
