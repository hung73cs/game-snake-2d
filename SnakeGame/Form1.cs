using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SnakeGame
{

    public partial class Form1 : Form
    {
        #region Khai báo biến
        Snake snake = new Snake();
        Random randFood = new Random();
        Food food;
        Graphics paper;
        Boolean up = false, down = false, left = false, right = false;
        int score = 0;
        #endregion

        #region Form1
        public Form1()
        {
            InitializeComponent();
            food = new Food(randFood);
            panel1.Width = 400;
            panel1.Height = 400;
            paper = panel1.CreateGraphics();
            panel1.Focus();
        }
        #endregion

        #region Load Form
        private void Form1_Load(object sender, EventArgs e)
        {

            rabtnTudo.Checked = true;
            rabtnHangrao.Checked = false;
            btnDe.Enabled = true;

            btnVua.Enabled = true;
            btnKho.Enabled = true;

        }
        #endregion

        #region Time 
        private void timer1_Tick(object sender, EventArgs e)
        {


            if (down == true) { snake.moveDown(); }
            if (up == true) { snake.moveUp(); }
            if (right == true) { snake.moveRight(); }
            if (left == true) { snake.moveLeft(); }
            GameMode();
            for (int i = 0; i < snake.SnakeRec.Length; i++)
            {
                if (snake.SnakeRec[i].IntersectsWith(food.foodRec))
                {
                    
                    lbDiem.Text = (score += 10).ToString();
                    snake.GrowSnake();
                    food.FoodLocation(randFood);

                }
            }

            panel1.Invalidate();
        }
        #endregion

        #region Vẽ rắn khi chơi
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            food.DrawFood(paper);
            snake.DrawSnake(paper);
        }
        #endregion

        #region Gamemode
        public void GameMode()
        {
            if (rabtnTudo.Checked == true)
            {
                GamemodeTudo();
                return;
            }

            else if (rabtnHangrao.Checked == true)
            {
                GamemodeHangrao();
                return;
            }
        }

        public void GamemodeTudo()
        {
            for (int i = 1; i < snake.SnakeRec.Length; i++)
            {
                if (snake.SnakeRec[0].IntersectsWith(snake.SnakeRec[i]))
                {
                    GameOver();


                }
            }
            if (snake.SnakeRec[0].Y < 10)
            {
                snake.SnakeRec[0].Y = panel1.Width - 20;
            }
            if (snake.SnakeRec[0].Y > panel1.Width - 20)
            {
                snake.SnakeRec[0].Y = 10;
            }
            if (snake.SnakeRec[0].X < 10)
            {
                snake.SnakeRec[0].X = panel1.Height - 20;
            }
            if (snake.SnakeRec[0].X > panel1.Height - 20)
            {
                snake.SnakeRec[0].X = 10;
            }
        }

        public void GamemodeHangrao()
        {
            for (int i = 1; i < snake.SnakeRec.Length; i++)
            {
                if (snake.SnakeRec[0].IntersectsWith(snake.SnakeRec[i]))
                {
                    GameOver();

                }
            }
            if (snake.SnakeRec[0].Y < 10 || snake.SnakeRec[0].Y > panel1.Height - 20)
            {
                GameOver();
            }

            if (snake.SnakeRec[0].X < 10 || snake.SnakeRec[0].X > panel1.Width - 20)
            {
                GameOver();

            }
        }

        #endregion

        #region Cấp độ
        private void btnDe_Click(object sender, EventArgs e)
        {
            btnDe.BackColor = Color.Yellow;
            btnVua.BackColor = Color.White;
            btnKho.BackColor = Color.White;
            timer1.Interval = 150;
        }

        private void btnVua_Click(object sender, EventArgs e)
        {
            btnDe.BackColor = Color.White;
            btnVua.BackColor = Color.Yellow;
            btnKho.BackColor = Color.White;
            timer1.Interval = 100;
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            btnDe.BackColor = Color.White;
            btnVua.BackColor = Color.White;
            btnKho.BackColor = Color.Yellow;
            timer1.Interval = 50;
        }
        #endregion

        #region Game Over
        private void GameOver()
        {
            timer1.Enabled = false;
            var result = MessageBox.Show("Úi! Rắn chết roàiiii!!!");
            if (result == DialogResult.OK)
            {
                gbCheDoChoi.Enabled = true;
                gbLevel.Enabled = true;
                timer1.Enabled = false;
                score = 0;
                lbDiem.Text = "O";
                snake = new Snake();

            }


        }
        #endregion

        #region Restart
        private void Restart()
        {
            gbCheDoChoi.Enabled = false;
            gbLevel.Enabled = false;
            timer1.Enabled = false;
            score = 0;
            lbDiem.Text = "O";
            snake = new Snake();
        }
        #endregion

        #region Phím chọn
        private void btnPause_Click(object sender, EventArgs e)
        {

            timer1.Enabled = false;
            lbNotification.Text = "TẠM DỪNG !!!";
            panel1.Focus();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            lbNotification.Text = "";
            timer1.Enabled = true;
            gbCheDoChoi.Enabled = false;
            gbLevel.Enabled = false;
            left = false;
            right = false;
            up = false;
            down = false;
            panel1.Focus();

        }

        private void btnNewgame_Click(object sender, EventArgs e)
        {

            gbCheDoChoi.Enabled = true;
            gbLevel.Enabled = true;
            timer1.Enabled = false;
            left = false;
            right = false;
            up = false;
            down = false;
            score = 0;
            snake = new Snake();

        }



        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            Restart();
            btnPlay_Click(sender, e);
        }
        #endregion

        #region Sự kiện phím bấm
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            panel1.Focus();
            if (e.KeyData == Keys.Space)
            {
                if (timer1.Enabled == false)
                {
                    btnPlay_Click(sender, e);
                }
                else if (timer1.Enabled == true)
                {
                    btnPause_Click(sender, e);

                }

            }
            if (e.KeyData == Keys.Up && down == false)
            {
                up = true;
                down = false;
                right = false;
                left = false;
            }
            if (e.KeyData == Keys.Down && up == false)
            {
                up = false;
                down = true;
                right = false;
                left = false;
            }
            if (e.KeyData == Keys.Right && left == false)
            {
                up = false;
                down = false;
                right = true;
                left = false;
            }
            if (e.KeyData == Keys.Left && right == false)
            {
                up = false;
                down = false;
                right = false;
                left = true;
            }

        }

        #endregion

        #region Mousce-click Focus
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            panel1.Focus();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            panel1.Focus();

        }
        #endregion

        #region Pla
        private void lbNotification_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void rabtnTudo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gbLevel_Enter(object sender, EventArgs e)
        {

        }
        #endregion
    }
}

