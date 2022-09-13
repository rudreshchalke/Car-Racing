namespace CarRacing
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.over = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.car = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.coins = new System.Windows.Forms.Label();
            this.cnt = new System.Windows.Forms.Label();
            this.coin2 = new System.Windows.Forms.PictureBox();
            this.coin3 = new System.Windows.Forms.PictureBox();
            this.coin4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // over
            // 
            this.over.AutoSize = true;
            this.over.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.over.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.over.Font = new System.Drawing.Font("Stencil", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.over.ForeColor = System.Drawing.Color.Red;
            this.over.Location = new System.Drawing.Point(115, 22);
            this.over.Name = "over";
            this.over.Size = new System.Drawing.Size(153, 31);
            this.over.TabIndex = 10;
            this.over.Text = "GAME OVER";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.exit.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Red;
            this.exit.Location = new System.Drawing.Point(145, 66);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(82, 23);
            this.exit.TabIndex = 12;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // enemy2
            // 
            this.enemy2.Image = global::CarRacing.Properties.Resources.cars;
            this.enemy2.Location = new System.Drawing.Point(104, 209);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(44, 82);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.enemy2.TabIndex = 9;
            this.enemy2.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.Image = global::CarRacing.Properties.Resources.cars;
            this.enemy3.Location = new System.Drawing.Point(235, 164);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(44, 82);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.enemy3.TabIndex = 8;
            this.enemy3.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.Image = global::CarRacing.Properties.Resources.cars;
            this.enemy1.Location = new System.Drawing.Point(35, 98);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(44, 82);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.enemy1.TabIndex = 7;
            this.enemy1.TabStop = false;
            // 
            // car
            // 
            this.car.Image = global::CarRacing.Properties.Resources.PngItem_4582942;
            this.car.Location = new System.Drawing.Point(70, 370);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(44, 62);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.car.TabIndex = 6;
            this.car.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox6.Location = new System.Drawing.Point(371, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(10, 462);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox5.Location = new System.Drawing.Point(2, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 462);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Location = new System.Drawing.Point(181, 373);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(8, 107);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(181, 242);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(8, 107);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(181, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(8, 107);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(181, -18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(8, 107);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // coin1
            // 
            this.coin1.Image = global::CarRacing.Properties.Resources.pngfind_com_gold_coins_png_37612;
            this.coin1.Location = new System.Drawing.Point(35, 230);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(24, 29);
            this.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coin1.TabIndex = 14;
            this.coin1.TabStop = false;
            // 
            // coins
            // 
            this.coins.AutoSize = true;
            this.coins.BackColor = System.Drawing.Color.DarkGray;
            this.coins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.coins.Font = new System.Drawing.Font("Stencil", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coins.ForeColor = System.Drawing.Color.Red;
            this.coins.Location = new System.Drawing.Point(235, 421);
            this.coins.Name = "coins";
            this.coins.Size = new System.Drawing.Size(88, 31);
            this.coins.TabIndex = 15;
            this.coins.Text = "COINS";
            // 
            // cnt
            // 
            this.cnt.AutoSize = true;
            this.cnt.BackColor = System.Drawing.Color.DarkGray;
            this.cnt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cnt.Font = new System.Drawing.Font("Stencil", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnt.ForeColor = System.Drawing.Color.Red;
            this.cnt.Location = new System.Drawing.Point(329, 421);
            this.cnt.Name = "cnt";
            this.cnt.Size = new System.Drawing.Size(2, 31);
            this.cnt.TabIndex = 16;
            // 
            // coin2
            // 
            this.coin2.Image = global::CarRacing.Properties.Resources.pngfind_com_gold_coins_png_37612;
            this.coin2.Location = new System.Drawing.Point(151, 111);
            this.coin2.Name = "coin2";
            this.coin2.Size = new System.Drawing.Size(24, 29);
            this.coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coin2.TabIndex = 17;
            this.coin2.TabStop = false;
            // 
            // coin3
            // 
            this.coin3.Image = global::CarRacing.Properties.Resources.pngfind_com_gold_coins_png_37612;
            this.coin3.Location = new System.Drawing.Point(195, 262);
            this.coin3.Name = "coin3";
            this.coin3.Size = new System.Drawing.Size(24, 29);
            this.coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coin3.TabIndex = 18;
            this.coin3.TabStop = false;
            // 
            // coin4
            // 
            this.coin4.Image = global::CarRacing.Properties.Resources.pngfind_com_gold_coins_png_37612;
            this.coin4.Location = new System.Drawing.Point(329, 280);
            this.coin4.Name = "coin4";
            this.coin4.Size = new System.Drawing.Size(24, 29);
            this.coin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coin4.TabIndex = 19;
            this.coin4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.coin4);
            this.Controls.Add(this.coin3);
            this.Controls.Add(this.coin2);
            this.Controls.Add(this.cnt);
            this.Controls.Add(this.coins);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.over);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.car);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.Label over;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox coin1;
        private System.Windows.Forms.Label coins;
        private System.Windows.Forms.Label cnt;
        private System.Windows.Forms.PictureBox coin2;
        private System.Windows.Forms.PictureBox coin3;
        private System.Windows.Forms.PictureBox coin4;
    }
}

