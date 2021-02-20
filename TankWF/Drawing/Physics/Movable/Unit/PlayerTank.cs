using System;
using System.Collections.Generic;
using TankWF.Physics;
using System.Windows.Forms;
using TankWF.Drawing.Physics.Movable.Bullets;


namespace TankWF.Drawing.Physics.Movable.Unit
{
    class PlayerTank : Tank
    {
        private int mode = 1;
        public PlayerTank() : base(0, 0)
        {
            mode = 0;
        }
        public PlayerTank(int x, int y) : base(x, y)
        {

        }
        public override void Move(PreviewKeyDownEventArgs key)
        {
            {
                if (mode == 0)
                {
                    switch (key.KeyData.ToString())
                    {
                        case "A":
                            if ((X > 0) && (Direction == direction.Left))
                            {
                                if (CollisionDetector.CollisionDetection(this) != null)
                                {
                                    if (form == 0)
                                    {
                                        form = 1;
                                        animationSpeed = 8;
                                    }
                                    else
                                    {
                                        form = 0;
                                        animationSpeed = 8;
                                    }
                                    return;
                                }
                                X -= step;
                                if (animationSpeed == 0)
                                {
                                    if (form == 0) 
                                    {
                                        form = 1;
                                        animationSpeed = 8;
                                    } 
                                    else 
                                    { 
                                        form = 0;
                                        animationSpeed = 8;
                                    }
                                }
                            }
                            else
                            { 
                                Direction = direction.Left;
                                if (form == 0) 
                                { 
                                    form = 1;
                                } 
                                else 
                                { 
                                    form = 0;
                                }
                            }
                            break;
                        case "D":
                            if ((X < 960) && (Direction == direction.Right))
                            {
                                if (CollisionDetector.CollisionDetection(this) != null)
                                {
                                    if (form == 0)
                                    {
                                        form = 1;
                                        animationSpeed = 8;
                                    }
                                    else
                                    {
                                        form = 0;
                                        animationSpeed = 8;
                                    }
                                    return;
                                }
                                X += step;
                                if (animationSpeed == 0)
                                {
                                    if (form == 0) 
                                    { 
                                        form = 1;
                                        animationSpeed = 8;
                                    } 
                                    else 
                                    { 
                                        form = 0;
                                        animationSpeed = 8;
                                    }
                                }
                            }
                            else 
                            { 
                                Direction = direction.Right;
                                if (form == 0) 
                                { 
                                    form = 1;
                                    animationSpeed = 8;
                                } 
                                else 
                                { 
                                    form = 0;
                                    animationSpeed = 8;
                                } 
                            }
                            break;
                        case "W":
                            if ((Y > 0) && (Direction == direction.Up))
                            {
                                if (CollisionDetector.CollisionDetection(this) != null)
                                {
                                    if (form == 0)
                                    {
                                        form = 1;
                                        animationSpeed = 8;
                                    }
                                    else
                                    {
                                        form = 0;
                                        animationSpeed = 8;
                                    }
                                    return;
                                }
                                Y -= step;
                                if (animationSpeed == 0)
                                {
                                    if (form == 0) 
                                    { 
                                        form = 1;
                                        animationSpeed = 8;
                                    } 
                                    else 
                                    { 
                                        form = 0;
                                        animationSpeed = 8;
                                    }
                                }
                            }
                            else 
                            { 
                                Direction = direction.Up;
                                if (form == 0) 
                                { 
                                    form = 1;
                                } 
                                else 
                                { 
                                    form = 0; 
                                } 
                            }
                            break;
                        case "S":
                            if ((Y < 704) && (Direction == direction.Down))
                            {
                                if (CollisionDetector.CollisionDetection(this) != null)
                                {
                                    if (form == 0)
                                    {
                                        form = 1;
                                        animationSpeed = 8;
                                    }
                                    else
                                    {
                                        form = 0;
                                        animationSpeed = 8;
                                    }
                                    return;
                                }
                                Y += step;
                                if (animationSpeed == 0)
                                {
                                    if (form == 0) 
                                    { 
                                        form = 1;
                                        animationSpeed = 8; 
                                    } 
                                    else 
                                    { 
                                        form = 0; 
                                        animationSpeed = 8;
                                    }
                                }
                            }
                            else 
                            { 
                                Direction = direction.Down; 
                                if (form == 0) 
                                { 
                                    form = 1;
                                } 
                                else 
                                { 
                                    form = 0;
                                } 
                            }
                            break;
                        case "C":
                            {
                                if (recharge == 0)
                                {
                                    recharge = 80;
                                    if (Bullet.count <= 100) 
                                    { 
                                        Bullet.bullets.Add(new Bullet(this)); 
                                    }
                                    else 
                                    { 
                                        Bullet.bullets[Bullet.count - 1] = new Bullet(this); 
                                    }
                                }
                                return;
                            }
                    }
                    return;
                }
                
            }
        }

    }
}
