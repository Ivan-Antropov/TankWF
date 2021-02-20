using System;
using System.Collections.Generic;
using System.Drawing;

namespace TankWF.Resources
{
    class Images
    {
        public static Image persDown1;        //Хз зачем я сделал эти переменные
        public static Image persDown2;        //можно и без них,но мне лень переделывать..
        public static Image persUp1;
        public static Image persUp2;
        public static Image persLeft1;
        public static Image persLeft2;
        public static Image persRight1;
        public static Image persRight2;
        public static List<Image> bulletUp;
        public static List<Image> bulletDown;
        public static List<Image> bulletLeft;
        public static List<Image> bulletRight;
        public static List<Image> Explothion; //Список для изоброжений взрыва

        static Images ()
        {
            Explothion = new List<Image>();
            bulletUp = new List<Image>();
            bulletDown = new List<Image>();
            bulletLeft = new List<Image>();
            bulletRight = new List<Image>();
            //Добавляем ресурсы
            bulletUp.Add(Properties.Resources.Rocket);
            bulletUp.Add(Properties.Resources.Rocket_2);
            bulletUp.Add(Properties.Resources.Rocket_3);
            bulletDown.Add(Properties.Resources.Rocket_down_1);
            bulletDown.Add(Properties.Resources.Rocket_down_2);
            bulletDown.Add(Properties.Resources.Rocket_down_3);
            bulletLeft.Add(Properties.Resources.Rocket_left_1);
            bulletLeft.Add(Properties.Resources.Rocket_left_2);
            bulletLeft.Add(Properties.Resources.Rocket_left_3);
            bulletRight.Add(Properties.Resources.Rocket_right_1);
            bulletRight.Add(Properties.Resources.Rocket_right_2);
            bulletRight.Add(Properties.Resources.Rocket_right_3);
            Explothion.Add(Properties.Resources.Explosion_15);
            Explothion.Add(Properties.Resources.Explosion_14);
            Explothion.Add(Properties.Resources.Explosion_13);
            Explothion.Add(Properties.Resources.Explosion_12);
            Explothion.Add(Properties.Resources.Explosion_11);
            Explothion.Add(Properties.Resources.Explosion_10);
            Explothion.Add(Properties.Resources.Explosion_9);
            Explothion.Add(Properties.Resources.Explosion_8);
            Explothion.Add(Properties.Resources.Explosion_7);
            Explothion.Add(Properties.Resources.Explosion_6);
            Explothion.Add(Properties.Resources.Explosion_5);
            Explothion.Add(Properties.Resources.Explosion_4);
            Explothion.Add(Properties.Resources.Explosion_3);
            Explothion.Add(Properties.Resources.Explosion_2);
            Explothion.Add(Properties.Resources.Explosion_1);
            persDown1 = Properties.Resources.Tank_down_1;
            persDown2 = Properties.Resources.Tank_down_2;
            persUp1 = Properties.Resources.Tank_up_1;
            persUp2 = Properties.Resources.Tank_up_2;
            persLeft1 = Properties.Resources.Tank_left_1;
            persLeft2 = Properties.Resources.Tank_left_2;
            persRight1 = Properties.Resources.Tank_right_1;
            persRight2 = Properties.Resources.Tank_right_2;
        }
    }
}
