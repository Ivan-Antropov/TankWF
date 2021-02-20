using System;
using TankWF.Drawing.Physics.Movable.Unit;
using System.Collections.Generic;
using TankWF.Resources;

namespace TankWF.Drawing.NonPhysics.Effects
{
    class TankBoom : IDrawable
    {
        public static List<TankBoom> tankBooms = new List<TankBoom>();
        public float X { get; set; }
        public float Y { get; set; }
        private int animation = 14;
        private int boomAnimation = 0;
        private int animationSpeed = 12;
        private Tank tank;
        public float Size { get; }
        internal TankBoom(Tank tank)
        {
            this.tank = tank;
            Size = tank.Size;
            X = tank.X;
            Y = tank.Y;
            
            tankBooms.Add(this);
        }

        public void Draw()
        {
            if (animation == 14)
            {
                TankWF.Physics.CollisionDetector.drawableObjects.Remove(tank);
                Tank.tanks.Remove(tank);
            }
            Drawer.buffer.Graphics.DrawImage(Images.Explothion[animation], X - Size, Y - Size, 3 * Size, 3 * Size);
            if ((boomAnimation % animationSpeed) == 0)
            {
                if (animation == 0) { tankBooms.Remove(this); }
                else
                {
                    animation--;
                    boomAnimation++;
                }
                return;
            }
            boomAnimation++;
        }
    }
}
