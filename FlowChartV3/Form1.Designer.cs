namespace FlowChartV3
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
            this.Guncelle = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buton_basla = new System.Windows.Forms.Button();
            this.buton_giris = new System.Windows.Forms.Button();
            this.buton_islem = new System.Windows.Forms.Button();
            this.buton_karar = new System.Windows.Forms.Button();
            this.buton_baglanti = new System.Windows.Forms.Button();
            this.buton_dongu = new System.Windows.Forms.Button();
            this.buton_pencere = new System.Windows.Forms.Button();
            this.buton_bitir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buton_sil = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buton_bagla = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Guncelle
            // 
            this.Guncelle.Enabled = true;
            this.Guncelle.Interval = 50;
            this.Guncelle.Tick += new System.EventHandler(this.Guncelle_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buton_basla);
            this.panel1.Controls.Add(this.buton_giris);
            this.panel1.Controls.Add(this.buton_islem);
            this.panel1.Controls.Add(this.buton_karar);
            this.panel1.Controls.Add(this.buton_baglanti);
            this.panel1.Controls.Add(this.buton_dongu);
            this.panel1.Controls.Add(this.buton_pencere);
            this.panel1.Controls.Add(this.buton_bitir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 147);
            this.panel1.TabIndex = 12;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button4.Location = new System.Drawing.Point(876, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 28);
            this.button4.TabIndex = 10;
            this.button4.Text = "___";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::FlowChartV3.Properties.Resources.max3;
            this.button3.Location = new System.Drawing.Point(922, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 28);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(968, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(87, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Flow";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(68, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 39);
            this.label2.TabIndex = 9;
            this.label2.Text = "Chart";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FlowChartV3.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // buton_basla
            // 
            this.buton_basla.FlatAppearance.BorderSize = 0;
            this.buton_basla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buton_basla.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buton_basla.Image = global::FlowChartV3.Properties.Resources.başla1;
            this.buton_basla.Location = new System.Drawing.Point(5, 77);
            this.buton_basla.Name = "buton_basla";
            this.buton_basla.Size = new System.Drawing.Size(120, 50);
            this.buton_basla.TabIndex = 0;
            this.buton_basla.UseVisualStyleBackColor = true;
            this.buton_basla.Click += new System.EventHandler(this.buton_basla_Click);
            // 
            // buton_giris
            // 
            this.buton_giris.FlatAppearance.BorderSize = 0;
            this.buton_giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buton_giris.Image = global::FlowChartV3.Properties.Resources.veri;
            this.buton_giris.Location = new System.Drawing.Point(257, 77);
            this.buton_giris.Name = "buton_giris";
            this.buton_giris.Size = new System.Drawing.Size(120, 50);
            this.buton_giris.TabIndex = 1;
            this.buton_giris.UseVisualStyleBackColor = true;
            this.buton_giris.Click += new System.EventHandler(this.buton_giris_Click);
            // 
            // buton_islem
            // 
            this.buton_islem.FlatAppearance.BorderSize = 0;
            this.buton_islem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buton_islem.Image = global::FlowChartV3.Properties.Resources.işlem;
            this.buton_islem.Location = new System.Drawing.Point(131, 77);
            this.buton_islem.Name = "buton_islem";
            this.buton_islem.Size = new System.Drawing.Size(120, 50);
            this.buton_islem.TabIndex = 2;
            this.buton_islem.UseVisualStyleBackColor = true;
            this.buton_islem.Click += new System.EventHandler(this.buton_islem_Click);
            // 
            // buton_karar
            // 
            this.buton_karar.FlatAppearance.BorderSize = 0;
            this.buton_karar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buton_karar.Image = global::FlowChartV3.Properties.Resources.koşul;
            this.buton_karar.Location = new System.Drawing.Point(383, 77);
            this.buton_karar.Name = "buton_karar";
            this.buton_karar.Size = new System.Drawing.Size(120, 50);
            this.buton_karar.TabIndex = 3;
            this.buton_karar.UseVisualStyleBackColor = true;
            this.buton_karar.Click += new System.EventHandler(this.buton_karar_Click);
            // 
            // buton_baglanti
            // 
            this.buton_baglanti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buton_baglanti.FlatAppearance.BorderSize = 0;
            this.buton_baglanti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buton_baglanti.Image = global::FlowChartV3.Properties.Resources.circle;
            this.buton_baglanti.Location = new System.Drawing.Point(761, 77);
            this.buton_baglanti.Name = "buton_baglanti";
            this.buton_baglanti.Size = new System.Drawing.Size(120, 50);
            this.buton_baglanti.TabIndex = 4;
            this.buton_baglanti.UseVisualStyleBackColor = true;
            this.buton_baglanti.Click += new System.EventHandler(this.buton_baglanti_Click);
            // 
            // buton_dongu
            // 
            this.buton_dongu.FlatAppearance.BorderSize = 0;
            this.buton_dongu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buton_dongu.Image = global::FlowChartV3.Properties.Resources.döngü;
            this.buton_dongu.Location = new System.Drawing.Point(509, 77);
            this.buton_dongu.Name = "buton_dongu";
            this.buton_dongu.Size = new System.Drawing.Size(120, 50);
            this.buton_dongu.TabIndex = 5;
            this.buton_dongu.UseVisualStyleBackColor = true;
            this.buton_dongu.Click += new System.EventHandler(this.buton_dongu_Click);
            // 
            // buton_pencere
            // 
            this.buton_pencere.FlatAppearance.BorderSize = 0;
            this.buton_pencere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buton_pencere.Image = global::FlowChartV3.Properties.Resources.yazdır;
            this.buton_pencere.Location = new System.Drawing.Point(635, 77);
            this.buton_pencere.Name = "buton_pencere";
            this.buton_pencere.Size = new System.Drawing.Size(120, 50);
            this.buton_pencere.TabIndex = 6;
            this.buton_pencere.UseVisualStyleBackColor = true;
            this.buton_pencere.Click += new System.EventHandler(this.buton_pencere_Click);
            // 
            // buton_bitir
            // 
            this.buton_bitir.FlatAppearance.BorderSize = 0;
            this.buton_bitir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buton_bitir.Image = global::FlowChartV3.Properties.Resources.başla1;
            this.buton_bitir.Location = new System.Drawing.Point(887, 77);
            this.buton_bitir.Name = "buton_bitir";
            this.buton_bitir.Size = new System.Drawing.Size(120, 50);
            this.buton_bitir.TabIndex = 7;
            this.buton_bitir.UseVisualStyleBackColor = true;
            this.buton_bitir.Click += new System.EventHandler(this.buton_bitir_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.buton_sil);
            this.panel2.Controls.Add(this.btn_temizle);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.buton_bagla);
            this.panel2.Location = new System.Drawing.Point(0, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(109, 209);
            this.panel2.TabIndex = 13;
            // 
            // buton_sil
            // 
            this.buton_sil.FlatAppearance.BorderSize = 0;
            this.buton_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buton_sil.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buton_sil.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buton_sil.Image = global::FlowChartV3.Properties.Resources.sil31;
            this.buton_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buton_sil.Location = new System.Drawing.Point(3, 0);
            this.buton_sil.Name = "buton_sil";
            this.buton_sil.Size = new System.Drawing.Size(103, 43);
            this.buton_sil.TabIndex = 8;
            this.buton_sil.Text = "   Sil";
            this.buton_sil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buton_sil.UseVisualStyleBackColor = true;
            this.buton_sil.Click += new System.EventHandler(this.buton_sil_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.FlatAppearance.BorderSize = 0;
            this.btn_temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_temizle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_temizle.Image = global::FlowChartV3.Properties.Resources.temizle;
            this.btn_temizle.Location = new System.Drawing.Point(3, 54);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(103, 43);
            this.btn_temizle.TabIndex = 11;
            this.btn_temizle.Text = "  Temizle";
            this.btn_temizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Image = global::FlowChartV3.Properties.Resources.play;
            this.button2.Location = new System.Drawing.Point(0, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 43);
            this.button2.TabIndex = 10;
            this.button2.Text = "   Play";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buton_bagla
            // 
            this.buton_bagla.FlatAppearance.BorderSize = 0;
            this.buton_bagla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buton_bagla.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buton_bagla.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buton_bagla.Image = global::FlowChartV3.Properties.Resources.bağla;
            this.buton_bagla.Location = new System.Drawing.Point(3, 108);
            this.buton_bagla.Name = "buton_bagla";
            this.buton_bagla.Size = new System.Drawing.Size(103, 43);
            this.buton_bagla.TabIndex = 9;
            this.buton_bagla.Text = "  Bağla";
            this.buton_bagla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buton_bagla.UseVisualStyleBackColor = true;
            this.buton_bagla.Click += new System.EventHandler(this.buton_bagla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 680);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlowChart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buton_giris;
        private System.Windows.Forms.Button buton_basla;
        private System.Windows.Forms.Button buton_bitir;
        private System.Windows.Forms.Button buton_pencere;
        private System.Windows.Forms.Button buton_dongu;
        private System.Windows.Forms.Button buton_baglanti;
        private System.Windows.Forms.Button buton_karar;
        private System.Windows.Forms.Button buton_islem;
        private System.Windows.Forms.Button buton_sil;
        private System.Windows.Forms.Timer Guncelle;
        private System.Windows.Forms.Button buton_bagla;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}

