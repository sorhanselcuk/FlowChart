namespace FlowChartV3.DiyagramFormlari
{
    partial class Karar
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_degisken1 = new System.Windows.Forms.ComboBox();
            this.cb_islem = new System.Windows.Forms.ComboBox();
            this.cb_degisken2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buton_tamamla = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.txt_deger = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Değişken 1";
            // 
            // cb_degisken1
            // 
            this.cb_degisken1.FormattingEnabled = true;
            this.cb_degisken1.Location = new System.Drawing.Point(12, 41);
            this.cb_degisken1.Name = "cb_degisken1";
            this.cb_degisken1.Size = new System.Drawing.Size(107, 21);
            this.cb_degisken1.TabIndex = 1;
            // 
            // cb_islem
            // 
            this.cb_islem.FormattingEnabled = true;
            this.cb_islem.Items.AddRange(new object[] {
            "<",
            "<=",
            ">",
            ">=",
            "==",
            "!="});
            this.cb_islem.Location = new System.Drawing.Point(137, 41);
            this.cb_islem.Name = "cb_islem";
            this.cb_islem.Size = new System.Drawing.Size(44, 21);
            this.cb_islem.TabIndex = 2;
            // 
            // cb_degisken2
            // 
            this.cb_degisken2.FormattingEnabled = true;
            this.cb_degisken2.Location = new System.Drawing.Point(200, 41);
            this.cb_degisken2.Name = "cb_degisken2";
            this.cb_degisken2.Size = new System.Drawing.Size(107, 21);
            this.cb_degisken2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Değişken 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Operatör";
            // 
            // buton_tamamla
            // 
            this.buton_tamamla.Location = new System.Drawing.Point(200, 79);
            this.buton_tamamla.Name = "buton_tamamla";
            this.buton_tamamla.Size = new System.Drawing.Size(107, 34);
            this.buton_tamamla.TabIndex = 6;
            this.buton_tamamla.Text = "Tamamla";
            this.buton_tamamla.UseVisualStyleBackColor = true;
            this.buton_tamamla.Click += new System.EventHandler(this.buton_tamamla_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(113, 85);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(38, 23);
            this.btn_ekle.TabIndex = 12;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // txt_deger
            // 
            this.txt_deger.Location = new System.Drawing.Point(12, 87);
            this.txt_deger.Name = "txt_deger";
            this.txt_deger.Size = new System.Drawing.Size(100, 20);
            this.txt_deger.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "İstediğiniz sayısal değerleri giriniz";
            // 
            // Karar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 125);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_deger);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buton_tamamla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_degisken2);
            this.Controls.Add(this.cb_islem);
            this.Controls.Add(this.cb_degisken1);
            this.Controls.Add(this.label1);
            this.Name = "Karar";
            this.Text = "Karar";
            this.Load += new System.EventHandler(this.Karar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_degisken1;
        private System.Windows.Forms.ComboBox cb_islem;
        private System.Windows.Forms.ComboBox cb_degisken2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buton_tamamla;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox txt_deger;
        private System.Windows.Forms.Label label4;
    }
}