namespace SnakeGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbCheDoChoi = new System.Windows.Forms.GroupBox();
            this.rabtnHangrao = new System.Windows.Forms.RadioButton();
            this.rabtnTudo = new System.Windows.Forms.RadioButton();
            this.lbDiem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbLevel = new System.Windows.Forms.GroupBox();
            this.btnKho = new System.Windows.Forms.Button();
            this.btnVua = new System.Windows.Forms.Button();
            this.btnDe = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNotification = new System.Windows.Forms.Label();
            this.btnNewgame = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbAbout = new System.Windows.Forms.Label();
            this.gbCheDoChoi.SuspendLayout();
            this.gbLevel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gbCheDoChoi
            // 
            this.gbCheDoChoi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbCheDoChoi.Controls.Add(this.rabtnHangrao);
            this.gbCheDoChoi.Controls.Add(this.rabtnTudo);
            this.gbCheDoChoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCheDoChoi.Location = new System.Drawing.Point(418, 54);
            this.gbCheDoChoi.Name = "gbCheDoChoi";
            this.gbCheDoChoi.Size = new System.Drawing.Size(220, 56);
            this.gbCheDoChoi.TabIndex = 3;
            this.gbCheDoChoi.TabStop = false;
            this.gbCheDoChoi.Text = "Chế độ chơi";
            // 
            // rabtnHangrao
            // 
            this.rabtnHangrao.AutoSize = true;
            this.rabtnHangrao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rabtnHangrao.Location = new System.Drawing.Point(101, 22);
            this.rabtnHangrao.Name = "rabtnHangrao";
            this.rabtnHangrao.Size = new System.Drawing.Size(90, 20);
            this.rabtnHangrao.TabIndex = 7;
            this.rabtnHangrao.Text = "Hàng rào";
            this.rabtnHangrao.UseVisualStyleBackColor = true;
            // 
            // rabtnTudo
            // 
            this.rabtnTudo.AutoSize = true;
            this.rabtnTudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rabtnTudo.Location = new System.Drawing.Point(29, 22);
            this.rabtnTudo.Name = "rabtnTudo";
            this.rabtnTudo.Size = new System.Drawing.Size(66, 20);
            this.rabtnTudo.TabIndex = 6;
            this.rabtnTudo.TabStop = true;
            this.rabtnTudo.Text = "Tự do";
            this.rabtnTudo.UseVisualStyleBackColor = true;
            this.rabtnTudo.CheckedChanged += new System.EventHandler(this.rabtnTudo_CheckedChanged);
            // 
            // lbDiem
            // 
            this.lbDiem.AutoSize = true;
            this.lbDiem.Font = new System.Drawing.Font("Rockwell Extra Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiem.ForeColor = System.Drawing.Color.Red;
            this.lbDiem.Location = new System.Drawing.Point(565, 12);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(29, 28);
            this.lbDiem.TabIndex = 5;
            this.lbDiem.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Extra Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(457, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "SCORE :";
            // 
            // gbLevel
            // 
            this.gbLevel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbLevel.Controls.Add(this.btnKho);
            this.gbLevel.Controls.Add(this.btnVua);
            this.gbLevel.Controls.Add(this.btnDe);
            this.gbLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.gbLevel.Location = new System.Drawing.Point(418, 116);
            this.gbLevel.Name = "gbLevel";
            this.gbLevel.Size = new System.Drawing.Size(220, 55);
            this.gbLevel.TabIndex = 6;
            this.gbLevel.TabStop = false;
            this.gbLevel.Text = "Caáp ñoä";
            this.gbLevel.Enter += new System.EventHandler(this.gbLevel_Enter);
            // 
            // btnKho
            // 
            this.btnKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKho.Location = new System.Drawing.Point(144, 19);
            this.btnKho.Name = "btnKho";
            this.btnKho.Size = new System.Drawing.Size(59, 30);
            this.btnKho.TabIndex = 2;
            this.btnKho.Text = "Khó";
            this.btnKho.UseVisualStyleBackColor = false;
            this.btnKho.Click += new System.EventHandler(this.btnKho_Click);
            // 
            // btnVua
            // 
            this.btnVua.BackColor = System.Drawing.Color.Lime;
            this.btnVua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVua.Location = new System.Drawing.Point(80, 19);
            this.btnVua.Name = "btnVua";
            this.btnVua.Size = new System.Drawing.Size(59, 30);
            this.btnVua.TabIndex = 1;
            this.btnVua.Text = "Vừa";
            this.btnVua.UseVisualStyleBackColor = false;
            this.btnVua.Click += new System.EventHandler(this.btnVua_Click);
            // 
            // btnDe
            // 
            this.btnDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDe.Location = new System.Drawing.Point(15, 19);
            this.btnDe.Name = "btnDe";
            this.btnDe.Size = new System.Drawing.Size(59, 30);
            this.btnDe.TabIndex = 0;
            this.btnDe.Text = "Dễ";
            this.btnDe.UseVisualStyleBackColor = false;
            this.btnDe.Click += new System.EventHandler(this.btnDe_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnRestartGame);
            this.panel2.Controls.Add(this.btnPlay);
            this.panel2.Controls.Add(this.btnPause);
            this.panel2.Location = new System.Drawing.Point(418, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(85, 185);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(4, 191);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 34);
            this.panel3.TabIndex = 1;
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.AllowDrop = true;
            this.btnRestartGame.BackgroundImage = global::SnakeGame.Properties.Resources.reload1;
            this.btnRestartGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestartGame.FlatAppearance.BorderSize = 0;
            this.btnRestartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestartGame.Location = new System.Drawing.Point(21, 124);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(41, 41);
            this.btnRestartGame.TabIndex = 11;
            this.btnRestartGame.UseVisualStyleBackColor = true;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = global::SnakeGame.Properties.Resources.play1;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(21, 18);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(41, 41);
            this.btnPlay.TabIndex = 10;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackgroundImage = global::SnakeGame.Properties.Resources.pause1;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Location = new System.Drawing.Point(21, 71);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(41, 41);
            this.btnPause.TabIndex = 8;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SnakeGame.Properties.Resources.snakechot1;
            this.pictureBox1.Location = new System.Drawing.Point(538, 177);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BackgroundImage = global::SnakeGame.Properties.Resources.Wall;
            this.panel1.Controls.Add(this.lbNotification);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 400);
            this.panel1.TabIndex = 2;
            this.panel1.TabStop = true;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbNotification
            // 
            this.lbNotification.AutoSize = true;
            this.lbNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotification.ForeColor = System.Drawing.Color.Red;
            this.lbNotification.Location = new System.Drawing.Point(108, 188);
            this.lbNotification.Name = "lbNotification";
            this.lbNotification.Size = new System.Drawing.Size(0, 25);
            this.lbNotification.TabIndex = 0;
            this.lbNotification.Click += new System.EventHandler(this.lbNotification_Click);
            // 
            // btnNewgame
            // 
            this.btnNewgame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnNewgame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewgame.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewgame.ForeColor = System.Drawing.Color.Navy;
            this.btnNewgame.Location = new System.Drawing.Point(45, 3);
            this.btnNewgame.Name = "btnNewgame";
            this.btnNewgame.Size = new System.Drawing.Size(132, 28);
            this.btnNewgame.TabIndex = 9;
            this.btnNewgame.Text = "NEW GAME";
            this.btnNewgame.UseVisualStyleBackColor = true;
            this.btnNewgame.Click += new System.EventHandler(this.btnNewgame_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnNewgame);
            this.panel4.Location = new System.Drawing.Point(418, 368);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 34);
            this.panel4.TabIndex = 13;
            // 
            // lbAbout
            // 
            this.lbAbout.AutoSize = true;
            this.lbAbout.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAbout.Location = new System.Drawing.Point(559, 409);
            this.lbAbout.Name = "lbAbout";
            this.lbAbout.Size = new System.Drawing.Size(94, 15);
            this.lbAbout.TabIndex = 14;
            this.lbAbout.Text = "Design by phihung";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(650, 425);
            this.Controls.Add(this.lbAbout);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gbLevel);
            this.Controls.Add(this.lbDiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbCheDoChoi);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Rắn săn mồi";
            this.Activated += new System.EventHandler(this.Form1_Load);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.gbCheDoChoi.ResumeLayout(false);
            this.gbCheDoChoi.PerformLayout();
            this.gbLevel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbCheDoChoi;
        private System.Windows.Forms.RadioButton rabtnHangrao;
        private System.Windows.Forms.RadioButton rabtnTudo;
        private System.Windows.Forms.Label lbDiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbLevel;
        private System.Windows.Forms.Button btnKho;
        private System.Windows.Forms.Button btnVua;
        private System.Windows.Forms.Button btnDe;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnNewgame;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbNotification;
        private System.Windows.Forms.Button btnRestartGame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbAbout;
    }
}

