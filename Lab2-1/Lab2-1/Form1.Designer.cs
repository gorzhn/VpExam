namespace Lab2_1
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
            this.radioMala = new System.Windows.Forms.RadioButton();
            this.radioSredna = new System.Windows.Forms.RadioButton();
            this.radioGolema = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textGolema = new System.Windows.Forms.TextBox();
            this.textSredna = new System.Windows.Forms.TextBox();
            this.textMala = new System.Windows.Forms.TextBox();
            this.textKecap = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkKecap = new System.Windows.Forms.CheckBox();
            this.checkEkstraSirenje = new System.Windows.Forms.CheckBox();
            this.checkFeferonki = new System.Windows.Forms.CheckBox();
            this.textEkstrasirenje = new System.Windows.Forms.TextBox();
            this.textFeferonki = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cenaPivo = new System.Windows.Forms.TextBox();
            this.cenaSokOdJabolko = new System.Windows.Forms.TextBox();
            this.cenaKokaKola = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textPivo = new System.Windows.Forms.TextBox();
            this.textSokOdJabolko = new System.Windows.Forms.TextBox();
            this.textKokaKola = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textVkupno = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioMala
            // 
            this.radioMala.AutoSize = true;
            this.radioMala.Location = new System.Drawing.Point(6, 32);
            this.radioMala.Name = "radioMala";
            this.radioMala.Size = new System.Drawing.Size(52, 17);
            this.radioMala.TabIndex = 0;
            this.radioMala.TabStop = true;
            this.radioMala.Text = "Мала";
            this.radioMala.UseVisualStyleBackColor = true;
            this.radioMala.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioSredna
            // 
            this.radioSredna.AutoSize = true;
            this.radioSredna.Location = new System.Drawing.Point(6, 59);
            this.radioSredna.Name = "radioSredna";
            this.radioSredna.Size = new System.Drawing.Size(62, 17);
            this.radioSredna.TabIndex = 1;
            this.radioSredna.TabStop = true;
            this.radioSredna.Text = "Средна";
            this.radioSredna.UseVisualStyleBackColor = true;
            this.radioSredna.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioGolema
            // 
            this.radioGolema.AutoSize = true;
            this.radioGolema.Location = new System.Drawing.Point(6, 86);
            this.radioGolema.Name = "radioGolema";
            this.radioGolema.Size = new System.Drawing.Size(63, 17);
            this.radioGolema.TabIndex = 2;
            this.radioGolema.TabStop = true;
            this.radioGolema.Text = "Голема";
            this.radioGolema.UseVisualStyleBackColor = true;
            this.radioGolema.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textGolema);
            this.groupBox1.Controls.Add(this.textSredna);
            this.groupBox1.Controls.Add(this.textMala);
            this.groupBox1.Controls.Add(this.radioGolema);
            this.groupBox1.Controls.Add(this.radioMala);
            this.groupBox1.Controls.Add(this.radioSredna);
            this.groupBox1.Location = new System.Drawing.Point(45, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 128);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // textGolema
            // 
            this.textGolema.Enabled = false;
            this.textGolema.Location = new System.Drawing.Point(96, 85);
            this.textGolema.Name = "textGolema";
            this.textGolema.Size = new System.Drawing.Size(100, 20);
            this.textGolema.TabIndex = 5;
            this.textGolema.Text = "500";
            // 
            // textSredna
            // 
            this.textSredna.Enabled = false;
            this.textSredna.Location = new System.Drawing.Point(96, 59);
            this.textSredna.Name = "textSredna";
            this.textSredna.Size = new System.Drawing.Size(100, 20);
            this.textSredna.TabIndex = 4;
            this.textSredna.Text = "300";
            this.textSredna.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textMala
            // 
            this.textMala.Enabled = false;
            this.textMala.Location = new System.Drawing.Point(97, 31);
            this.textMala.Name = "textMala";
            this.textMala.Size = new System.Drawing.Size(99, 20);
            this.textMala.TabIndex = 3;
            this.textMala.Text = "200";
            this.textMala.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textKecap
            // 
            this.textKecap.Enabled = false;
            this.textKecap.Location = new System.Drawing.Point(125, 83);
            this.textKecap.Name = "textKecap";
            this.textKecap.Size = new System.Drawing.Size(100, 20);
            this.textKecap.TabIndex = 5;
            this.textKecap.Text = "20";
            this.textKecap.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkKecap);
            this.groupBox2.Controls.Add(this.checkEkstraSirenje);
            this.groupBox2.Controls.Add(this.checkFeferonki);
            this.groupBox2.Controls.Add(this.textKecap);
            this.groupBox2.Controls.Add(this.textEkstrasirenje);
            this.groupBox2.Controls.Add(this.textFeferonki);
            this.groupBox2.Location = new System.Drawing.Point(334, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 128);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // checkKecap
            // 
            this.checkKecap.AutoSize = true;
            this.checkKecap.Location = new System.Drawing.Point(7, 87);
            this.checkKecap.Name = "checkKecap";
            this.checkKecap.Size = new System.Drawing.Size(56, 17);
            this.checkKecap.TabIndex = 8;
            this.checkKecap.Text = "Кечап";
            this.checkKecap.UseVisualStyleBackColor = true;
            this.checkKecap.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // checkEkstraSirenje
            // 
            this.checkEkstraSirenje.AutoSize = true;
            this.checkEkstraSirenje.Location = new System.Drawing.Point(7, 59);
            this.checkEkstraSirenje.Name = "checkEkstraSirenje";
            this.checkEkstraSirenje.Size = new System.Drawing.Size(105, 17);
            this.checkEkstraSirenje.TabIndex = 7;
            this.checkEkstraSirenje.Text = "Екстра сирење";
            this.checkEkstraSirenje.UseVisualStyleBackColor = true;
            this.checkEkstraSirenje.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // checkFeferonki
            // 
            this.checkFeferonki.AutoSize = true;
            this.checkFeferonki.Location = new System.Drawing.Point(7, 31);
            this.checkFeferonki.Name = "checkFeferonki";
            this.checkFeferonki.Size = new System.Drawing.Size(87, 17);
            this.checkFeferonki.TabIndex = 6;
            this.checkFeferonki.Text = "Феферонки";
            this.checkFeferonki.UseVisualStyleBackColor = true;
            this.checkFeferonki.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // textEkstrasirenje
            // 
            this.textEkstrasirenje.Enabled = false;
            this.textEkstrasirenje.Location = new System.Drawing.Point(125, 56);
            this.textEkstrasirenje.Name = "textEkstrasirenje";
            this.textEkstrasirenje.Size = new System.Drawing.Size(100, 20);
            this.textEkstrasirenje.TabIndex = 4;
            this.textEkstrasirenje.Text = "50";
            // 
            // textFeferonki
            // 
            this.textFeferonki.Enabled = false;
            this.textFeferonki.Location = new System.Drawing.Point(126, 28);
            this.textFeferonki.Name = "textFeferonki";
            this.textFeferonki.Size = new System.Drawing.Size(99, 20);
            this.textFeferonki.TabIndex = 3;
            this.textFeferonki.Text = "40";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox13);
            this.groupBox3.Controls.Add(this.textBox14);
            this.groupBox3.Controls.Add(this.textBox15);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cenaPivo);
            this.groupBox3.Controls.Add(this.cenaSokOdJabolko);
            this.groupBox3.Controls.Add(this.cenaKokaKola);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textPivo);
            this.groupBox3.Controls.Add(this.textSokOdJabolko);
            this.groupBox3.Controls.Add(this.textKokaKola);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(45, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(576, 155);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // textBox13
            // 
            this.textBox13.Enabled = false;
            this.textBox13.Location = new System.Drawing.Point(441, 89);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 20);
            this.textBox13.TabIndex = 19;
            // 
            // textBox14
            // 
            this.textBox14.Enabled = false;
            this.textBox14.Location = new System.Drawing.Point(441, 62);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 20);
            this.textBox14.TabIndex = 18;
            // 
            // textBox15
            // 
            this.textBox15.Enabled = false;
            this.textBox15.Location = new System.Drawing.Point(441, 35);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 20);
            this.textBox15.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Вкупно";
            // 
            // cenaPivo
            // 
            this.cenaPivo.Enabled = false;
            this.cenaPivo.Location = new System.Drawing.Point(301, 92);
            this.cenaPivo.Name = "cenaPivo";
            this.cenaPivo.Size = new System.Drawing.Size(100, 20);
            this.cenaPivo.TabIndex = 15;
            this.cenaPivo.Text = "80";
            // 
            // cenaSokOdJabolko
            // 
            this.cenaSokOdJabolko.Enabled = false;
            this.cenaSokOdJabolko.Location = new System.Drawing.Point(301, 65);
            this.cenaSokOdJabolko.Name = "cenaSokOdJabolko";
            this.cenaSokOdJabolko.Size = new System.Drawing.Size(100, 20);
            this.cenaSokOdJabolko.TabIndex = 14;
            this.cenaSokOdJabolko.Text = "70";
            // 
            // cenaKokaKola
            // 
            this.cenaKokaKola.Enabled = false;
            this.cenaKokaKola.Location = new System.Drawing.Point(301, 38);
            this.cenaKokaKola.Name = "cenaKokaKola";
            this.cenaKokaKola.Size = new System.Drawing.Size(100, 20);
            this.cenaKokaKola.TabIndex = 13;
            this.cenaKokaKola.Text = "60";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Цена";
            // 
            // textPivo
            // 
            this.textPivo.Location = new System.Drawing.Point(163, 92);
            this.textPivo.Name = "textPivo";
            this.textPivo.Size = new System.Drawing.Size(100, 20);
            this.textPivo.TabIndex = 11;
            this.textPivo.Text = "0";
            this.textPivo.TextChanged += new System.EventHandler(this.text_TextChanged);
            // 
            // textSokOdJabolko
            // 
            this.textSokOdJabolko.Location = new System.Drawing.Point(163, 65);
            this.textSokOdJabolko.Name = "textSokOdJabolko";
            this.textSokOdJabolko.Size = new System.Drawing.Size(100, 20);
            this.textSokOdJabolko.TabIndex = 10;
            this.textSokOdJabolko.Text = "0";
            this.textSokOdJabolko.TextChanged += new System.EventHandler(this.text_TextChanged);
            // 
            // textKokaKola
            // 
            this.textKokaKola.Location = new System.Drawing.Point(163, 38);
            this.textKokaKola.Name = "textKokaKola";
            this.textKokaKola.Size = new System.Drawing.Size(100, 20);
            this.textKokaKola.TabIndex = 9;
            this.textKokaKola.Text = "0";
            this.textKokaKola.TextChanged += new System.EventHandler(this.text_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Количина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пиво";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сок од јаболко";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кока Кола";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Овошна пита",
            "Сладолед",
            "Торта"});
            this.listBox1.Location = new System.Drawing.Point(45, 393);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(172, 409);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(100, 20);
            this.textBox16.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(171, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Цена на десертот";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Нарачај";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 465);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Откажи";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.textVkupno);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(346, 384);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(296, 119);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Наплата";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(173, 81);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(173, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textVkupno
            // 
            this.textVkupno.Location = new System.Drawing.Point(173, 24);
            this.textVkupno.Name = "textVkupno";
            this.textVkupno.Size = new System.Drawing.Size(100, 20);
            this.textVkupno.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "За враќање";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Наплатено";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Вкупно за плаќање";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 571);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioMala;
        private System.Windows.Forms.RadioButton radioSredna;
        private System.Windows.Forms.RadioButton radioGolema;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textMala;
        private System.Windows.Forms.TextBox textGolema;
        private System.Windows.Forms.TextBox textSredna;
        private System.Windows.Forms.TextBox textKecap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkKecap;
        private System.Windows.Forms.CheckBox checkEkstraSirenje;
        private System.Windows.Forms.CheckBox checkFeferonki;
        private System.Windows.Forms.TextBox textEkstrasirenje;
        private System.Windows.Forms.TextBox textFeferonki;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cenaPivo;
        private System.Windows.Forms.TextBox cenaSokOdJabolko;
        private System.Windows.Forms.TextBox cenaKokaKola;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textPivo;
        private System.Windows.Forms.TextBox textSokOdJabolko;
        private System.Windows.Forms.TextBox textKokaKola;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textVkupno;
    }
}

