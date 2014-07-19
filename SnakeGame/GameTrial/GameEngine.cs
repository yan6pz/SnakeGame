using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameTrial
{
    public partial class GameEngine : Form
    {
        Random randomFood = new Random();
        private Graphics paper;
        Snake snake =new Snake();
        Food food ;
        private bool down = false;
        private bool up = false;
        private bool left = false;
        private bool right = false;
        private int score = 0;

        public GameEngine()
        {
            InitializeComponent();
            food = new Food(randomFood);
        }

        public void GameEngine_Paint(Object sender, PaintEventArgs e)
        {
            paper = e.Graphics;
            food.DrawFood(paper);
            snake.DrawSnake(paper);
            this.BackColor = Color.DarkGray;
        }

        private void TheTime_Tick(object sender, EventArgs e)
        {
            snakeScoreLabel.Text = score.ToString();
            if(down)
            {
                snake.moveDown();
            }
            if (up)
            {
                snake.moveUp();
            }
            if (left)
            {
                snake.moveLeft();
            }
            if (right)
            {
                snake.moveRight();
            }

            this.Invalidate();
            collision();
            for (int i = 0; i < snake.SnakeRec.Length; i++)
            {
                if(snake.SnakeRec[i].IntersectsWith(food.foodRec))
                {
                    score += 1;
                    snake.GrowSnake();


                    food.FoodLocation(randomFood);
                }
            }
            
        }

      public void collision()
      {
          for (int i = 1; i < snake.SnakeRec.Length; i++)
          {
              if (snake.SnakeRec[0].IntersectsWith(snake.SnakeRec[1]))
              {
                  restart();
              }
          }
          if (snake.SnakeRec[0].X < 0 || snake.SnakeRec[0].X > 1000)
          {
              restart();
          }
          if (snake.SnakeRec[0].Y < 0 || snake.SnakeRec[0].Y > 1000)
          {
              restart();
          }

      }

        public void restart()
        {
            TheTime.Enabled = false;
            MessageBox.Show("GAME OVER");
            snakeScoreLabel.Text = "0";
            score = 0;
            spaceBarLabel.Text = "Press SPACECAR to begin";
            snake = new Snake();


        }

        private void GameEngine_Load(Object sender, EventArgs e)
        {

        }

        private void GameEngine_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                    case Keys.Space:
                            TheTime.Enabled = true;
                            snakeScoreLabel.Text = "";
                            spaceBarLabel.Text = "";
                            up = false;
                            down = false;
                            left = false;
                            right = true;
                        break;
                    case Keys.Right:
                            right = true;
                            up = false;
                            down = false;
                            left = false;
                        break;
                    case Keys.Left:
                            left = true;
                            right = false;
                            down = false;
                            up = false;
                        break;
                    case Keys.Down:
                            down = true;
                            up = false;
                            left = false;
                            right = false;
                        break;
                    case Keys.Up:
                            up = true;
                            down = false;
                            right = false;
                            left = false;
                        break;

            }
            //if (e.KeyData == Keys.Space)
            //{
            //    TheTime.Enabled = true;
            //    up = false;
            //    down = false;
            //    left = false;
            //    right = true;
            //}
            //if (e.KeyData == Keys.Right)
            //{
            //    right = true;
            //    up = false;
            //    down = false;
            //    left = false;
            //}
            //if(e.KeyData==)
        }


    }
}
