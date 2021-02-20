 
namespace TankWF.Drawing.Physics.Movable
{
    public enum direction { Right, Left, Up, Down };
    interface IMovable : IDrawable
    {
        direction Direction { get; }
        float Step { get; }
        void Move(System.Windows.Forms.PreviewKeyDownEventArgs key);
    }
}
