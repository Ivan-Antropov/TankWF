
namespace TankWF.Drawing
{
    interface IDrawable
    {
        float X { get; set; }
        float Y { get; set; }
        float Size { get; }
        void Draw();
    }
}
