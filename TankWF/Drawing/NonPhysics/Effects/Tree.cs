using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankWF.Drawing.NonPhysics.Effects
{
    class Tree : IDrawable
    {
        public static List<Tree> trees= new List<Tree>();
        public float X { get; set; }
        public float Y { get; set; }

        private readonly float size = 64;
        public float Size
        {
            get
            {
                return size;
            }
        }

        public Tree(int x, int y)
        {
            trees.Add(this);
            X = x;
            Y = y;
        }

        public void Draw()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if ((i + j) % 2 != 0)
                    {
                        Drawer.buffer.Graphics.FillRectangle(System.Drawing.Brushes.Green, X + i * Size / 8, Y + j * Size / 8, Size / 8, Size / 8);
                    }
                }
            }
        }
    }
}
