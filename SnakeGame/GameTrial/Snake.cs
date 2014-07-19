using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace GameTrial
{
    public class Snake
    {
        private Rectangle[] snakeRec;
        private SolidBrush brush;
        private SolidBrush brushHead;
        private int x, y, width, height;

        public Rectangle[]  SnakeRec 
        {
            get { return snakeRec; } 
        }

        //firstlly initilize the snake at some position
        public Snake()
        {
            
            snakeRec=new Rectangle[5];
            brush= new SolidBrush(Color.Blue);
            brushHead=new SolidBrush(Color.Red);
            x = 30;
            y = 0;
            width = 15;
            height = 15;
            for (int i = 0; i < snakeRec.Length; i++)
            {
                snakeRec[i]=new Rectangle(x,y,width,height);
                x -= 15;
            }
        }

        public void DrawSnake(Graphics paper)
        {
            foreach (var rectangle in SnakeRec)
            {
                paper.FillRectangle(brush,rectangle);
            }
            paper.FillRectangle(brushHead,SnakeRec[0]);
        }

        public void DrawSnake()
        {
            //if reverse the cyclic order it will move backwards
            for (int i = snakeRec.Length-1; i >0; i--)
            {
                snakeRec[i] = snakeRec[i-1];
            }
        }

        public void moveDown()
        {
            DrawSnake();
            snakeRec[0].Y += 15;
            
        }
        public void moveUp()
        {
            DrawSnake();
            snakeRec[0].Y -= 15; 
        }
        public void moveLeft()
        {
            DrawSnake();
            snakeRec[0].X -= 15;
        }
        public void moveRight()
        {
            DrawSnake();
            snakeRec[0].X += 15;
        }

        public void GrowSnake()
        {
            //grow at its tail
            List<Rectangle> rec = snakeRec.ToList();
            rec.Add(new Rectangle(  snakeRec[snakeRec.Length-1].X
                                    ,snakeRec[snakeRec.Length-1].Y
                                    ,width
                                    ,height));
            snakeRec = rec.ToArray();
        }
    }
}
