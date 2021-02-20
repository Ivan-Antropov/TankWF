using System;
using TankWF.Drawing.NonPhysics.Effects;
using System.Collections.Generic;
using TankWF.Resources;

namespace TankWF.Drawing.Physics.Movable.Unit
{
    public abstract class Tank : IMovable, IDrawable
    {
        //Cписок для танков
        public static LinkedList<Tank> tanks;
        //количество танков
        public static int tankscount = 0;
        protected int recharge = 0;
        protected float step = 2.2f;
        public float Step
        {
            get
            {
                return step;
            }
        }
        public float Size { get; }
        //порядковый номер танка
        protected int tankID;            
        //здоровье
        public int health = 2;
        //взрывается ли танк
        public bool IsBoom = false;
        public int BoomAnimation = 0;


        public direction Direction { get; set; }
        public float X { get; set; }
        public float Y { get; set; }

        protected int animationSpeed = 0;
        protected int form = 0;

        public Tank(int x, int y)
        {
            Size = 64;
            X = x;
            Y = y;
            tankscount++;
        }
        abstract public void Move(System.Windows.Forms.PreviewKeyDownEventArgs key);

        //метод для отрисовки танка
        public virtual void Draw()
        {
            if (IsBoom)
            {
                TankBoom.tankBooms.Add(new TankBoom(this));
                return;
            }
            switch (Direction)
            {
                case direction.Right:
                    {
                        if (form == 0)//выбор картинки для танка
                        {
                            Drawer.buffer.Graphics.DrawImage(Images.persRight1, (int)X, (int)Y, Size, Size);
                        }
                        else
                        {
                            Drawer.buffer.Graphics.DrawImage(Images.persRight2, (int)X, (int)Y, Size, Size);
                        }
                        break;

                    }
                case direction.Left:
                    {
                        if (form == 0)//выбор картинки для танка
                        {
                            Drawer.buffer.Graphics.DrawImage(Images.persLeft1, (int)X, (int)Y, Size, Size);
                        }
                        else
                        {
                            Drawer.buffer.Graphics.DrawImage(Images.persLeft2, (int)X, (int)Y, Size, Size);
                        }
                        break;
                    }
                case direction.Up:
                    {
                        if (form == 0)//выбор картинки для танка
                        {
                            Drawer.buffer.Graphics.DrawImage(Images.persUp1, (int)X, (int)Y, Size, Size);
                        }
                        else
                        {
                            Drawer.buffer.Graphics.DrawImage(Images.persUp2, (int)X, (int)Y, Size, Size);
                        }
                        break;
                    }
                case direction.Down:
                    {
                        if (form == 0)//выбор картинки для танка
                        {
                            Drawer.buffer.Graphics.DrawImage(Images.persDown1, (int)X, (int)Y, Size, Size);
                        }
                        else
                        {
                            Drawer.buffer.Graphics.DrawImage(Images.persDown2, (int)X, (int)Y, Size, Size);
                        }
                        break;
                    }
            }
            if (recharge != 0) { recharge--; }
            if (animationSpeed != 0) { animationSpeed--; }
            if (health == 0) { IsBoom = true; }
        }
    }
}
