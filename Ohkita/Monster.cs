using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Ohkita
{
    class Monster
    {
        //public string type, direction;
        public int x, y, size, /*speed,*/ health;

        public Monster(/*string _type,*/ int _x, int _y, int _size, /*int _speed, string _direction,*/ int _health)
        {
            //type = _type;
            x = _x;
            y = _y;
            size = _size;
            //speed = _speed;
            //direction = _direction;
            health = _health;
        }

        public void Move(string direction)
        {
            if (direction == "left")
            {
                x = x - 10;
            }
            if (direction == "up")
            {
                y = y - 10;
            }
            if (direction == "right")
            {
                x = x + 10;
            }
            if (direction == "down")
            {
                y = y + 10;
            }
        }

        /*
        public Boolean Collision(Bullet b)
        {
            //Rectangle heroRec = new Rectangle(heroMon.x, heroMon.y, heroMon.size, heroMon.size);

            Rectangle MonRec = new Rectangle(x, y, size, size);

            Rectangle BulletRec = new Rectangle(b.x, b.y, b.size, b.size);
        }*/

        
    }
}

