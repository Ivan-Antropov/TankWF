using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TankWF.Drawing;
using TankWF.Drawing.Physics.Movable;
using TankWF.Drawing.Physics.Immovable;
using TankWF.Drawing.Physics.Movable.Unit;
using TankWF.Drawing.Physics.Movable.Bullets;

namespace TankWF.Physics
{
    class CollisionDetector
    {
        public static List<IDrawable> drawableObjects;

        static CollisionDetector()
        {
            drawableObjects = new List<IDrawable>();
            foreach (Tank tank in Tank.tanks)
            {
                drawableObjects.Add(tank);
            }
            foreach (WoodBlock woodBlock in WoodBlock.woodBlocks)
            {
                drawableObjects.Add(woodBlock);
            }
        }
        public static IDrawable CollisionDetection(IMovable obj)
        {
            switch (obj.Direction)
            {
                case direction.Right:
                    foreach (IDrawable drawable in drawableObjects)
                    {
                        if (drawable == null || obj == drawable)
                        {
                            continue;
                        }
                        if (((obj.Y + obj.Size - obj.Step) > drawable.Y) &&
                            (obj.Y + obj.Step < (drawable.Y + drawable.Size)) &&
                            (obj.X + obj.Step < (drawable.X + drawable.Size)) &&
                            ((obj.X + obj.Size) > drawable.X))
                        {
                            return drawable;
                        }
                    }
                    break;
                case direction.Left:
                    foreach (IDrawable drawable in drawableObjects)
                    {
                        if (drawable == null || obj == drawable)
                        {
                            continue;
                        }
                        if (((obj.Y + obj.Size - obj.Step) > drawable.Y) &&
                            (obj.Y + obj.Step < (drawable.Y + drawable.Size)) &&
                            ((obj.X + obj.Size - obj.Step) > drawable.X) &&
                            (obj.X < (drawable.X + drawable.Size)))
                        {
                            return drawable;
                        }
                    }
                    break;
                case direction.Up:
                    foreach (IDrawable drawable in drawableObjects)
                    {
                        if (drawable == null || obj == drawable)
                        {
                            continue;
                        }
                        if ((obj.Y < (drawable.Y + drawable.Size)) &&
                            (obj.X + obj.Step < (drawable.X + drawable.Size)) &&
                            ((obj.X + obj.Size - obj.Step) > drawable.X) &&
                            ((obj.Y + obj.Size - obj.Step) > drawable.Y))
                        {
                            return drawable;
                        }
                    }
                    break;
                case direction.Down:
                    foreach (IDrawable drawable in drawableObjects)
                    {
                        if (drawable == null || obj == drawable)
                        {
                            continue;
                        }
                        if ((obj.Y + obj.Step < (drawable.Y + drawable.Size)) &&
                            (obj.X + obj.Step < (drawable.X + drawable.Size)) &&
                            ((obj.X + obj.Size - obj.Step) > drawable.X) &&
                            ((obj.Y + obj.Size) > drawable.Y))
                        {
                            return drawable;
                        }
                    }
                    break;
            }
            return null;
        }

    }
}
