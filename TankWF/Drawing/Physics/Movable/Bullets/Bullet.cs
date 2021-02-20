using System;
using System.Collections.Generic;
using TankWF.Resources;
using TankWF.Drawing.Physics.Movable.Unit;

namespace TankWF.Drawing.Physics.Movable.Bullets
{
    public class Bullet : IDrawable
    {
        int animation = 0;
        int form = 0;
        public static List<Bullet> bullets;
        public float Size { get; }
        public float X { get; set; }             
        public float Y { get; set; }             

        public direction Direction { get; set; }
        public bool hit = false;    
        public static int count = 0;
        public int bulletID = 0;       
        readonly float step;     
        public float Step
        {
            get 
            { 
                return step; 
            }
        }
        public Bullet(Tank tank)
        {
            step = 2f;
            Size = 8;
            if (count < 100)
            {
                count++;
                bulletID = count;
            }
            else { count = 0; }
            switch (tank.Direction)
            {
                case direction.Right:
                    {
                        Direction = direction.Right;
                        X = tank.X + 0.7f * tank.Size;
                        Y = tank.Y + 0.41f * tank.Size;
                        break;
                    }
                case direction.Left:
                    {
                        Direction = direction.Left;
                        X = tank.X + 0.25f * tank.Size;
                        Y = tank.Y + 0.41f * tank.Size;
                        break;
                    }
                case direction.Up:
                    {
                        Direction = direction.Up;
                        X = tank.X + 0.41f * tank.Size;
                        Y = tank.Y + 0.25f * tank.Size;
                        break;
                    }
                case direction.Down:
                    {
                        Direction = direction.Down;
                        X = tank.X + 0.41f * tank.Size;
                        Y = tank.Y + 0.7f * tank.Size;
                        break;
                    }
            }


        }
        public void Draw()
        {
            if ((X >= -20) && (X <= 1024) && (Y >= -20) && (Y <= 768))
            {
                switch (Direction)
                {
                    case direction.Right:
                        {
                            foreach (Tank tank in Tank.tanks)
                            {
                                if (tank == null) { continue; }
                                if ((X + 28 > tank.X) &&
                                    (Y + 8 > tank.Y) &&
                                    (Y + 2 < (tank.Y + tank.Size)) &&
                                    (X + 21 < (tank.X + tank.Size)) &&
                                    (tank.IsBoom == false))
                                {
                                    hit = true;
                                    tank.health--;
                                    bullets[bulletID - 1] = null;
                                    return;
                                }
                            }
                            Drawer.buffer.Graphics.DrawImage(Images.bulletRight[form], X, Y, 31, 10);
                            X += step;
                            animation++;
                            if (animation == 6)
                            {
                                animation = 0;
                                if (form < 2) { form++; }
                                else { form = 0; }
                            }

                            break;
                        }
                    case direction.Left:
                        {
                            foreach (Tank tank in Tank.tanks)
                            {
                                if (tank == null) { continue; }
                                if ((Y + 8 > tank.Y) &&
                                    (X - 21 > tank.X) &&
                                    (X - 3 < (tank.X + tank.Size)) &&
                                    (Y + 2 < (tank.Y + tank.Size)) &&
                                    (tank.IsBoom == false))
                                {
                                    hit = true;
                                    tank.health--;
                                    bullets[bulletID - 1] = null;
                                    return;
                                }
                            }

                            Drawer.buffer.Graphics.DrawImage(Images.bulletLeft[form], X, Y, 31, 10);
                            X -= step;
                            animation++;
                            if (animation == 6)
                            {
                                animation = 0;
                                if (form < 2) { form++; }
                                else { form = 0; }
                            }
                            break;
                        }
                    case direction.Up:
                        {
                            foreach (Tank tank in Tank.tanks)
                            {
                                if (tank == null) { continue; }
                                if ((X + 8 > tank.X) &&
                                    (Y - 21 > tank.Y) &&
                                    (X + 2 < (tank.X + tank.Size)) &&
                                    (Y - 3 < (tank.Y + tank.Size)) &&
                                    (tank.IsBoom == false))
                                {
                                    hit = true;
                                    tank.health--;
                                    bullets[bulletID - 1] = null;
                                    return;
                                }
                            }
                            Drawer.buffer.Graphics.DrawImage(Images.bulletUp[form], X, Y, 10, 31);
                            Y -= step;
                            animation++;
                            if (animation == 6)
                            {
                                animation = 0;
                                if (form < 2) { form++; }
                                else { form = 0; }
                            }

                            break;
                        }
                    case direction.Down:
                        {
                            foreach (Tank tank in Tank.tanks)
                            {
                                if (tank == null) { continue; }
                                if ((X + 8 > tank.X) &&
                                    (Y + 28 > tank.Y) &&
                                    (X + 2 < (tank.X + tank.Size)) &&
                                    (Y + 21 < (tank.Y + tank.Size)) &&
                                    (tank.IsBoom == false))
                                {
                                    hit = true;
                                    tank.health--;
                                    bullets[bulletID - 1] = null;
                                    return;
                                }
                            }
                            Drawer.buffer.Graphics.DrawImage(Images.bulletDown[form], X, Y, 10, 31);
                            Y += step;
                            animation++;
                            if (animation == 6)
                            {
                                animation = 0;
                                if (form < 2) { form++; }
                                else { form = 0; }
                            }
                            break;
                        }
                }
            }
        }
    }
}
