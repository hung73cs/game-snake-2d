using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SnakeGame
{
    class Food
    {
        #region Khai báo biến
        private int x, y, width, height;
        private SolidBrush brush = new SolidBrush(Color.Red);     
        public Rectangle foodRec;
        #endregion

        #region Tạo thức ăn
        public Food(Random randFood)
        {
            x = randFood.Next(10, 39) * 10;
            y = randFood.Next(10, 39) * 10;         
            width = 10; height = 10;
            foodRec = new Rectangle(x, y, width, height); 
         }
        #endregion

        #region Tạo vị trí thức ăn xuất hiện
        public void FoodLocation(Random randFood)
        {
            x = randFood.Next(10, 39) * 10;
            y = randFood.Next(10, 39) * 10;
        }
        #endregion

        #region Vẽ thức ăn
        public void DrawFood(Graphics paper)
        {
            foodRec.X = x;
            foodRec.Y = y;
            paper.FillEllipse(brush, foodRec);          
        }
        #endregion
    }
}
