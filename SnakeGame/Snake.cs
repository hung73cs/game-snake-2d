using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Linq;

namespace SnakeGame
{
    class Snake
    {
        #region Khai báo biến
        private Rectangle[] snakeRec;
        public Rectangle[] SnakeRec
        {
            get
            {
                return snakeRec;
            }
        }
        private SolidBrush brushdau, brushthan;
        private int x, y, width, height;
        #endregion

        #region Tạo rắn
        public Snake()
        {
            snakeRec = new Rectangle[3];

            brushdau = new SolidBrush(Color.Black);

            brushthan = new SolidBrush(Color.DimGray);
            x = 30; y = 10; width = 10; height = 10;
            for (int i = 0; i < snakeRec.Length; i++)
            {
                snakeRec[i] = new Rectangle(x, y, width, height);   
                x -= 10;
            }           
        }
        #endregion

        #region Vẽ rắn 
        public void DrawSnake(Graphics paper)
        {
            paper.FillRectangle(brushdau, snakeRec[0]);
            for (int i = 1; i < snakeRec.Length; i++)
            {
                paper.FillRectangle(brushthan, snakeRec[i]);
            }           
        }
        #endregion

        #region Vẽ rắn lúc di chuyển
        public void DrawSnakeRun()
        {
            for (int i = snakeRec.Length - 1; i > 0; i--)
            {
                snakeRec[i] = snakeRec[i - 1];
            }
        }
        #endregion

        #region Điều khiển rắn
        public void moveDown()
        {
            DrawSnakeRun();
            snakeRec[0].Y += 10;
        }
        public void moveUp()
        {
            DrawSnakeRun();
            snakeRec[0].Y -= 10;
        }
        public void moveRight()
        {
            DrawSnakeRun();
            snakeRec[0].X += 10;
        }
        public void moveLeft()
        {
            DrawSnakeRun();
            snakeRec[0].X -= 10;
        }
        #endregion

        #region Rắn lớn dần
        public void GrowSnake()
        {
            List<Rectangle> rec = snakeRec.ToList();
            rec.Add(new Rectangle(snakeRec[snakeRec.Length - 1].X, snakeRec[snakeRec.Length - 1].Y, width, height));
            rec.Add(new Rectangle(snakeRec[snakeRec.Length - 1].X, snakeRec[snakeRec.Length - 1].Y, width, height));
            rec.Add(new Rectangle(snakeRec[snakeRec.Length - 1].X, snakeRec[snakeRec.Length - 1].Y, width, height));
            snakeRec = rec.ToArray();
        }
        #endregion
    }
}
