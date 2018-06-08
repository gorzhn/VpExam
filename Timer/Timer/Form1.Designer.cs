namespace Timer
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
            this.label1 = new System.Windows.Forms.Label();
            this.textIme = new System.Windows.Forms.TextBox();
            this.broj1 = new System.Windows.Forms.TextBox();
            this.operacija = new System.Windows.Forms.TextBox();
            this.broj2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.newGame = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblPoeni = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Играч";
            // 
            // textIme
            // 
            this.textIme.Location = new System.Drawing.Point(73, 51);
            this.textIme.Name = "textIme";
            this.textIme.Size = new System.Drawing.Size(100, 20);
            this.textIme.TabIndex = 1;
            // 
            // broj1
            // 
            this.broj1.Location = new System.Drawing.Point(16, 119);
            this.broj1.Name = "broj1";
            this.broj1.Size = new System.Drawing.Size(100, 20);
            this.broj1.TabIndex = 2;
            // 
            // operacija
            // 
            this.operacija.Location = new System.Drawing.Point(122, 119);
            this.operacija.Name = "operacija";
            this.operacija.Size = new System.Drawing.Size(23, 20);
            this.operacija.TabIndex = 3;
            // 
            // broj2
            // 
            this.broj2.Location = new System.Drawing.Point(151, 119);
            this.broj2.Name = "broj2";
            this.broj2.Size = new System.Drawing.Size(100, 20);
            this.broj2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "=";
            // 
            // textGuess
            // 
            this.textGuess.Location = new System.Drawing.Point(294, 119);
            this.textGuess.Name = "textGuess";
            this.textGuess.Size = new System.Drawing.Size(100, 20);
            this.textGuess.TabIndex = 6;
            this.textGuess.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(403, 117);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 23);
            this.btnGuess.TabIndex = 7;
            this.btnGuess.Text = "Погоди";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Поени";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 270);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(518, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Преостанато време";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 12;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(16, 377);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(517, 23);
            this.progressBar2.TabIndex = 13;
            // 
            // newGame
            // 
            this.newGame.Location = new System.Drawing.Point(78, 416);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(75, 23);
            this.newGame.TabIndex = 14;
            this.newGame.Text = "Нова игра";
            this.newGame.UseVisualStyleBackColor = true;
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(241, 416);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Најдобри играчи";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(403, 416);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Исклучи";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lblPoeni
            // 
            this.lblPoeni.AutoSize = true;
            this.lblPoeni.Location = new System.Drawing.Point(73, 194);
            this.lblPoeni.Name = "lblPoeni";
            this.lblPoeni.Size = new System.Drawing.Size(35, 13);
            this.lblPoeni.TabIndex = 15;
            this.lblPoeni.Text = "label7";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 466);
            this.Controls.Add(this.lblPoeni);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.newGame);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.textGuess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.broj2);
            this.Controls.Add(this.operacija);
            this.Controls.Add(this.broj1);
            this.Controls.Add(this.textIme);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textIme;
        private System.Windows.Forms.TextBox broj1;
        private System.Windows.Forms.TextBox operacija;
        private System.Windows.Forms.TextBox broj2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblPoeni;
        private System.Windows.Forms.Timer timer1;
    }
}

