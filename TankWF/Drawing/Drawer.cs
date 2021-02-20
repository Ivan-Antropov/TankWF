using System;
using TankWF.Drawing.Physics.Movable.Bullets;
using TankWF.Drawing.Physics.Movable.Unit;
using TankWF.Drawing.Physics.Immovable;
using TankWF.Drawing.NonPhysics.Effects;
using System.Collections.Generic;
using System.Drawing;

namespace TankWF.Drawing
{
    class Drawer
    {
        public static BufferedGraphics buffer;
        static BufferedGraphicsContext context;          
        
        public Drawer(BufferedGraphicsContext contxt)
        {
            context = contxt;
        }

        public void Draw()
        {
            buffer.Graphics.Clear(Color.Chocolate);
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 18; j++)
                {
                    buffer.Graphics.FillRectangle(Brushes.BurlyWood, j * 64 + 1, i * 64, 62, 62);
                    buffer.Graphics.DrawLine(Pens.Chocolate, j * 64, i * 64, j * 64 + 64, i * 64 + 64);
                    buffer.Graphics.DrawLine(Pens.Chocolate, j * 64 + 64, i * 64, j * 64, i * 64 + 64);
                    buffer.Graphics.FillRectangle(Brushes.DarkSlateGray, j * 64 + 9, i * 64 + 9, 46, 46);
                }
            }

            for (int i = 0; i < WoodBlock.woodBlocks.Count; i++)
            {
                if (WoodBlock.woodBlocks[i] != null)
                {
                    WoodBlock.woodBlocks[i].Draw();
                }
            }

            for (int i = 0; i < Bullet.bullets.Count; i++)
            {
                if (Bullet.bullets[i] != null) 
                { 
                    Bullet.bullets[i].Draw(); 
                }
            }
            foreach (Tank tank in Tank.tanks)
            {
                tank.Draw();
            }
            for (int i = 0; i < Tree.trees.Count; i++)
            {
                Tree.trees[i].Draw();
            }

            for (int i = 0; i < TankBoom.tankBooms.Count; i++)
            {
                TankBoom.tankBooms[i].Draw();
            }
        }
    }
}
