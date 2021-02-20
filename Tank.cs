using System;

public class Class1
{
	
        
    
        public int x = 0;
        public int y = 0;
        public int way = 0;
        public int tway = 0;
        public int mod = 0;

        public Bullet Tank_Control(PreviewKeyDownEventArgs a)
        {
            if (mod == 0)
            {
                int step = 30;
                switch (a.KeyData.ToString())
                {
                    case "A":
                        if ((x > 0) && (way == 1))
                        {
                            x -= step;
                        }
                        else
                        {
                            way = 1;
                        }
                        break;
                    case "D":
                        if ((x < 780) && (way == 0))
                        {
                            x += step;
                        }
                        else { way = 0; }
                        break;
                    case "W":
                        if ((y > 0) && (way == 2))
                        {
                            y -= step;
                        }
                        else { way = 2; }
                        break;
                    case "S":
                        if ((y < 570) && (way == 3))
                        {
                            y += step;
                        }
                        else { way = 3; }
                        break;
                    case "C":
                        {

                            if (Bullet.count < 300) { blt.Add(new Bullet(this)); }
                            else { blt[Bullet.count - 1] = new Bullet(this); }
                            return blt[blt.Count - 1];
                        }
                }
                return null;
            }
            else
            {
                if (mod == 1)
                {
                    int step = 30;
                    switch (a.KeyData)
                    {
                        case Keys.Left:
                            if ((x > 0) && (way == 1))
                            {
                                x -= step;
                            }
                            else
                            {
                                way = 1;
                            }
                            break;
                        case Keys.Right:
                            if ((x < 780) && (way == 0))
                            {
                                x += step;
                            }
                            else { way = 0; }
                            break;
                        case Keys.Up:
                            if ((y > 0) && (way == 2))
                            {
                                y -= step;
                            }
                            else { way = 2; }
                            break;
                        case Keys.Down:
                            if ((y < 570) && (way == 3))
                            {
                                y += step;
                            }
                            else { way = 3; }
                            break;
                        case Keys.End:
                            {

                                if (Bullet.count < 300) { blt.Add(new Bullet(this)); }
                                else { blt[Bullet.count - 1] = new Bullet(this); }
                                return blt[blt.Count - 1];
                            }
                    }
                    return null;
                }
                return null;
            }
        }
        public void Tower_Control(PreviewKeyDownEventArgs a)
        {

            if (a.KeyData == Keys.W && (a.Alt))
            {
                tway = 2;
            }

        }//Управление башней

        public void DrawTank()
        {
            switch (this.way)
            {
                case 0:
                    {
                        /*
                        buffer.Graphics.FillRectangle(Brushes.DarkOrange, x, y, 27, 30);
                        buffer.Graphics.FillRectangle(Brushes.WhiteSmoke, x + 5, y + 9, 12, 12);
                        buffer.Graphics.FillRectangle(Brushes.WhiteSmoke, x + 15, y + 13, 10, 4);
                        buffer.Graphics.FillRectangle(Brushes.Red, x, y, 30, 7);
                        buffer.Graphics.FillRectangle(Brushes.Red, x, y + 23, 30, 7);*/
                        buffer.Graphics.DrawImage(persRight1, x, y, 64, 64);
                        break;

                    }
                case 1:
                    {
                        /*buffer.Graphics.FillRectangle(Brushes.DarkOrange, x + 3, y, 27, 30);
                        buffer.Graphics.FillRectangle(Brushes.WhiteSmoke, x + 13, y + 9, 12, 12);
                        buffer.Graphics.FillRectangle(Brushes.WhiteSmoke, x + 5, y + 13, 10, 4);
                        buffer.Graphics.FillRectangle(Brushes.Red, x, y, 30, 7);
                        buffer.Graphics.FillRectangle(Brushes.Red, x, y + 23, 30, 7);*/
                        buffer.Graphics.DrawImage(persLeft1, x, y, 64, 64);
                        break;
                    }
                case 2:
                    {
                        /*buffer.Graphics.FillRectangle(Brushes.DarkOrange, x, y + 3, 30, 27);
                        buffer.Graphics.FillRectangle(Brushes.WhiteSmoke, x + 9, y + 13, 12, 12);
                        buffer.Graphics.FillRectangle(Brushes.WhiteSmoke, x + 13, y + 5, 4, 10);
                        buffer.Graphics.FillRectangle(Brushes.Red, x, y, 7, 30);
                        buffer.Graphics.FillRectangle(Brushes.Red, x + 23, y, 7, 30);*/
                        buffer.Graphics.DrawImage(persUp1, x, y, 64, 64);
                        break;
                    }
                case 3:
                    {
                        /*buffer.Graphics.FillRectangle(Brushes.DarkOrange, x, y, 30, 27);
                        buffer.Graphics.FillRectangle(Brushes.WhiteSmoke, x + 9, y + 5, 12, 12);
                        buffer.Graphics.FillRectangle(Brushes.WhiteSmoke, x + 13, y + 15, 4, 10);
                        buffer.Graphics.FillRectangle(Brushes.Red, x, y, 7, 30);
                        buffer.Graphics.FillRectangle(Brushes.Red, x + 23, y, 7, 30);*/
                        buffer.Graphics.DrawImage(persDown1, x, y, 64, 64);
                        break;
                    }
            }
        }
}

