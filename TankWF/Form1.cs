using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TankWF.Drawing;
using TankWF.Drawing.NonPhysics.Effects;
using TankWF.Drawing.Physics.Movable;
using TankWF.Drawing.Physics.Immovable;
using TankWF.Drawing.Physics.Movable.Unit;
using TankWF.Drawing.Physics.Movable.Bullets;

namespace TankWF
{
    public partial class Form1 : Form
    {
        bool tick;                            //переменные для обработчика нажатий
        bool tick2;                           //не дают кликать 2 раза с 1 танка чаще чем 1 раз за цикл
        Drawer drawer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Height = 768;
            pictureBox1.Width = 1024;
            Graphics gr = pictureBox1.CreateGraphics();
            Bullet.bullets = new List<Bullet>();
            Tank.tanks = new LinkedList<Tank>();
            drawer = new Drawer(BufferedGraphicsManager.Current);
            Drawer.buffer = BufferedGraphicsManager.Current.Allocate(gr, pictureBox1.DisplayRectangle);
            //создаем объекты типа Tank
            Tank.tanks.AddLast(new PlayerTank());
            for (int i = 0; i < 1; i++) { Tank.tanks.AddLast(new PlayerTank(64 * i + 200, 0)); }
            Tank.tanks.AddLast(new PlayerTank(300, 364));
            Tank.tanks.Last().Direction = direction.Up;
            Tank.tanks.AddLast(new PlayerTank(300, 300));
            Tank.tanks.Last().Direction = direction.Down;
            Tank.tanks.AddLast(new PlayerTank(300, 496));
            Tank.tanks.Last().Direction = direction.Up;
            Tank.tanks.AddLast(new PlayerTank(364, 496));
            Tank.tanks.Last().Direction = direction.Left;
            Tank.tanks.AddLast(new PlayerTank(300, 428));
            Tank.tanks.Last().Direction = direction.Down;
            Tank.tanks.AddLast(new PlayerTank(364, 300));
            Tank.tanks.Last().Direction = direction.Left;
            Tank.tanks.AddLast(new PlayerTank(428, 300));
            Tank.tanks.Last().Direction = direction.Right;
            for (int i = 0; i < 5; i++)
            {
                new WoodBlock(128, 64 * i, 64);
            }
            new WoodBlock(96, 0, 32);
            new WoodBlock(96, 128, 32);
            for (int i = 0; i < 9; i++)
            {
                new WoodBlock(992 - 32 * i, 512, 32);
                new WoodBlock(640, 768 - 32 * i, 32);
            }
            for (int i = 0; i < 5; i++)
            {
                new Tree(0, 128 + i * 64);
                new Tree(64, 128 + i * 64);
                new Tree(128, 128 + i * 64);
            }
            tick = false;
            tick2 = false;
            //pictureBox1.PreviewKeyDown += pictureBox1_PreviewKeyDown2;
            //задаем интервал таймера в мс
            timer1.Interval = 15;
            //запускаем таймер
            timer1.Start();
            //назначаем обработчик события для таймера
            timer1.Tick += timer1_Tick;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Focus();
            drawer.Draw();
            Drawer.buffer.Render();
            tick = false;
            tick2 = false;
        }
        private void pictureBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if ((Tank.tanks.First != null)&&(Tank.tanks.First().health != 0))
            {
                if (!tick)
                {
                    Tank.tanks.First().Move(e);
                    tick = true;
                }
            }
            if ((Tank.tanks.First.Next != null) && (Tank.tanks.First.Next.Value.health != 0))
            {
                if (!tick2)
                {
                    Tank.tanks.First.Next.Value.Move(e);
                    tick2 = true;
                }
            }
        }
        /*
        private void pictureBox1_PreviewKeyDown2(object sender, PreviewKeyDownEventArgs e)
        {
            if ((Tank.tanks[1] != null) && (Tank.tanks[1].health != 0))
            {
                if (!tick2)
                {
                    Tank.tanks[1].Move(e);
                    tick2 = true;
                }
            }
        }*/
    }
}
