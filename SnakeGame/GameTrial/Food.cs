using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace GameTrial
{
    public class Food
    {
        private int x, y, width, height;
        private SolidBrush brush;
        public Rectangle foodRec;

        public Food(Random guid)
        {
            x=guid.Next(5, 40)*10;
            y = guid.Next(5, 40)*10;
            brush=new SolidBrush(Color.BlueViolet);
            width = 10;
            height = 10;
            foodRec=new Rectangle(x,y,width,height);
        }

        public void FoodLocation(Random guid)
        {
            x = guid.Next(5, 40)*10;
            y = guid.Next(5, 40)*10;
        }

        public void DrawFood(Graphics paper)
        {
            foodRec.X = x;
            foodRec.Y = y;
            paper.FillRectangle(brush,foodRec);
        }
    }
}
