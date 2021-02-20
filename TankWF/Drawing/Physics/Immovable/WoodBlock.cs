using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TankWF.Drawing.Physics.Immovable
{
    class WoodBlock : IDrawable
    {
        public static List<WoodBlock> woodBlocks;
        public float X { get; set; }
        public float Y { get; set; }

        public float Size { get; }

        static WoodBlock()
        {
            woodBlocks = new List<WoodBlock>();
        }

        public WoodBlock(float x, float y, int size)
        {
            Size = size;
            X = x;
            Y = y;
            woodBlocks.Add(this);
        }

        public void Draw()
        {
            Drawer.buffer.Graphics.FillRectangle(System.Drawing.Brushes.SaddleBrown, X, Y, Size, Size);
            Drawer.buffer.Graphics.FillRectangle(System.Drawing.Brushes.Cornsilk, X + 0.1f * Size, Y + 0.1f * Size, 0.8f * Size, 0.8f * Size);
        }
    }
}
