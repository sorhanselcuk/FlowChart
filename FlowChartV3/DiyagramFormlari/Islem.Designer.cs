namespace FlowChartV3.DiyagramFormlari
{
    partial class Islem
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buton_tanimlama = new System.Windows.Forms.Button();
            this.cb_degiskenTipi = new System.Windows.Forms.ComboBox();
            this.txt_degiskenDegeri = new System.Windows.Forms.TextBox();
            this.txt_degiskenAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_deger = new System.Windows.Forms.TextBox();
            this.buton_islem = new System.Windows.Forms.Button();
            this.cb_degiskenSonucu = new System.Windows.Forms.ComboBox();
            this.cb_degisken2 = new System.Windows.Forms.ComboBox();
            this.cb_operator = new System.Windows.Forms.ComboBox();
            this.cb_degisken1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(351, 167);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buton_tanimlama);
            this.tabPage1.Controls.Add(this.cb_degiskenTipi);
            this.tabPage1.Controls.Add(this.txt_degiskenDegeri);
            this.tabPage1.Controls.Add(this.txt_degiskenAdi);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(343, 141);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tanımlama";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buton_tanimlama
            // 
            this.buton_tanimlama.Location = new System.Drawing.Point(147, 101);
            this.buton_tanimlama.Name = "buton_tanimlama";
            this.buton_tanimlama.Size = new System.Drawing.Size(122, 35);
            this.buton_tanimlama.TabIndex = 6;
            this.buton_tanimlama.Text = "Tamamla";
            this.buton_tanimlama.UseVisualStyleBackColor = true;
            this.buton_tanimlama.Click += new System.EventHandler(this.buton_tanimlama_Click);
            // 
            // cb_degiskenTipi
            // 
            this.cb_degiskenTipi.FormattingEnabled = true;
            this.cb_degiskenTipi.Items.AddRange(new object[] {
            "int",
            "double"});
            this.cb_degiskenTipi.Location = new System.Drawing.Point(147, 48);
            this.cb_degiskenTipi.Name = "cb_degiskenTipi";
            this.cb_degiskenTipi.Size = new System.Drawing.Size(121, 21);
            this.cb_degiskenTipi.TabIndex = 5;
            // 
            // txt_degiskenDegeri
            // 
            this.txt_degiskenDegeri.Location = new System.Drawing.Point(147, 75);
            this.txt_degiskenDegeri.Name = "txt_degiskenDegeri";
            this.txt_degiskenDegeri.Size = new System.Drawing.Size(122, 20);
            this.txt_degiskenDegeri.TabIndex = 4;
            // 
            // txt_degiskenAdi
            // 
            this.txt_degiskenAdi.Location = new System.Drawing.Point(147, 17);
            this.txt_degiskenAdi.Name = "txt_degiskenAdi";
            this.txt_degiskenAdi.Size = new System.Drawing.Size(119, 20);
            this.txt_degiskenAdi.TabIndex = 3;
            this.txt_degiskenAdi.TextChanged += new System.EventHandler(this.txt_degiskenAdi_TextChanged);
            this.txt_degiskenAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_degiskenAdi_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Değişken Değeri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Değişken Tipi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Değişken Adı ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_ekle);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txt_deger);
            this.tabPage2.Controls.Add(this.buton_islem);
            this.tabPage2.Controls.Add(this.cb_degiskenSonucu);
            this.tabPage2.Controls.Add(this.cb_degisken2);
            this.tabPage2.Controls.Add(this.cb_operator);
            this.tabPage2.Controls.Add(this.cb_degisken1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(343, 141);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "İşlem";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(119, 107);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(42, 23);
            this.btn_ekle.TabIndex = 14;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "İstediğiniz değerleri giriniz";
            // 
            // txt_deger
            // 
            this.txt_deger.Location = new System.Drawing.Point(14, 110);
            this.txt_deger.Name = "txt_deger";
            this.txt_deger.Size = new System.Drawing.Size(100, 20);
            this.txt_deger.TabIndex = 12;
            // 
            // buton_islem
            // 
            this.buton_islem.Location = new System.Drawing.Point(213, 105);
            this.buton_islem.Name = "buton_islem";
            this.buton_islem.Size = new System.Drawing.Size(113, 29);
            this.buton_islem.TabIndex = 8;
            this.buton_islem.Text = "Tamamla";
            this.buton_islem.UseVisualStyleBackColor = true;
            this.buton_islem.Click += new System.EventHandler(this.buton_islem_Click);
            // 
            // cb_degiskenSonucu
            // 
            this.cb_degiskenSonucu.FormattingEnabled = true;
            this.cb_degiskenSonucu.Location = new System.Drawing.Point(14, 65);
            this.cb_degiskenSonucu.Name = "cb_degiskenSonucu";
            this.cb_degiskenSonucu.Size = new System.Drawing.Size(121, 21);
            this.cb_degiskenSonucu.TabIndex = 7;
            // 
            // cb_degisken2
            // 
            this.cb_degisken2.FormattingEnabled = true;
            this.cb_degisken2.Location = new System.Drawing.Point(205, 27);
            this.cb_degisken2.Name = "cb_degisken2";
            this.cb_degisken2.Size = new System.Drawing.Size(121, 21);
            this.cb_degisken2.TabIndex = 6;
            // 
            // cb_operator
            // 
            this.cb_operator.FormattingEnabled = true;
            this.cb_operator.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.cb_operator.Location = new System.Drawing.Point(141, 27);
            this.cb_operator.Name = "cb_operator";
            this.cb_operator.Size = new System.Drawing.Size(58, 21);
            this.cb_operator.TabIndex = 5;
            // 
            // cb_degisken1
            // 
            this.cb_degisken1.FormattingEnabled = true;
            this.cb_degisken1.Location = new System.Drawing.Point(14, 27);
            this.cb_degisken1.Name = "cb_degisken1";
            this.cb_degisken1.Size = new System.Drawing.Size(121, 21);
            this.cb_degisken1.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Sonuç Değişkeni";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Değişken 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Operatör";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Değişken 1";
            // 
            // Islem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 167);
            this.Controls.Add(this.tabControl1);
            this.Name = "Islem";
            this.Text = "Islem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Islem_FormClosing);
            this.Load += new System.EventHandler(this.Islem_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buton_tanimlama;
        private System.Windows.Forms.ComboBox cb_degiskenTipi;
        private System.Windows.Forms.TextBox txt_degiskenDegeri;
        private System.Windows.Forms.TextBox txt_degiskenAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buton_islem;
        private System.Windows.Forms.ComboBox cb_degiskenSonucu;
        private System.Windows.Forms.ComboBox cb_degisken2;
        private System.Windows.Forms.ComboBox cb_operator;
        private System.Windows.Forms.ComboBox cb_degisken1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_deger;
    }
}