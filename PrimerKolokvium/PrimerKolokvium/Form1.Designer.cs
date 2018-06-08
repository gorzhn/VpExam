namespace PrimerKolokvium
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listAerodrom = new System.Windows.Forms.ListBox();
            this.listaDestinacii = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Додади аеродром";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Избриши аеродром";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Додади дестинација";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listAerodrom
            // 
            this.listAerodrom.FormattingEnabled = true;
            this.listAerodrom.Location = new System.Drawing.Point(12, 13);
            this.listAerodrom.Name = "listAerodrom";
            this.listAerodrom.Size = new System.Drawing.Size(201, 277);
            this.listAerodrom.TabIndex = 3;
            this.listAerodrom.SelectedIndexChanged += new System.EventHandler(this.listAerodrom_SelectedIndexChanged);
            // 
            // listaDestinacii
            // 
            this.listaDestinacii.FormattingEnabled = true;
            this.listaDestinacii.Location = new System.Drawing.Point(350, 13);
            this.listaDestinacii.Name = "listaDestinacii";
            this.listaDestinacii.Size = new System.Drawing.Size(201, 277);
            this.listaDestinacii.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 408);
            this.Controls.Add(this.listAerodrom);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listaDestinacii);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listAerodrom;
        private System.Windows.Forms.ListBox listaDestinacii;
    }
}

