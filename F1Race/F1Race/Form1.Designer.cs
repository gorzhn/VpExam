namespace F1Race
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.minuti = new System.Windows.Forms.NumericUpDown();
            this.sekundi = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMinuti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.minuti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekundi)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(26, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(253, 303);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(397, 13);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(265, 238);
            this.listBox2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Додади возач";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(253, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Избриши возач";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // minuti
            // 
            this.minuti.Location = new System.Drawing.Point(364, 296);
            this.minuti.Name = "minuti";
            this.minuti.Size = new System.Drawing.Size(120, 20);
            this.minuti.TabIndex = 2;
            // 
            // sekundi
            // 
            this.sekundi.Location = new System.Drawing.Point(542, 296);
            this.sekundi.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.sekundi.Name = "sekundi";
            this.sekundi.Size = new System.Drawing.Size(120, 20);
            this.sekundi.TabIndex = 2;
            this.sekundi.ValueChanged += new System.EventHandler(this.sekundi_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Минути";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Секунди";
            // 
            // btnMinuti
            // 
            this.btnMinuti.Location = new System.Drawing.Point(376, 338);
            this.btnMinuti.Name = "btnMinuti";
            this.btnMinuti.Size = new System.Drawing.Size(253, 23);
            this.btnMinuti.TabIndex = 1;
            this.btnMinuti.Text = "Додади минути";
            this.btnMinuti.UseVisualStyleBackColor = true;
            this.btnMinuti.Click += new System.EventHandler(this.btnMinuti_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 411);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sekundi);
            this.Controls.Add(this.minuti);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnMinuti);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.minuti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekundi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown minuti;
        private System.Windows.Forms.NumericUpDown sekundi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMinuti;
    }
}

