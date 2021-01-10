namespace FlowChartV3.DiyagramFormlari
{
    partial class Pencere
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
            this.buton_tamamla = new System.Windows.Forms.Button();
            this.cb_degisken = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mesaj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buton_tamamla
            // 
            this.buton_tamamla.Location = new System.Drawing.Point(180, 67);
            this.buton_tamamla.Name = "buton_tamamla";
            this.buton_tamamla.Size = new System.Drawing.Size(91, 29);
            this.buton_tamamla.TabIndex = 9;
            this.buton_tamamla.Text = "Tamamla";
            this.buton_tamamla.UseVisualStyleBackColor = true;
            this.buton_tamamla.Click += new System.EventHandler(this.buton_tamamla_Click);
            // 
            // cb_degisken
            // 
            this.cb_degisken.FormattingEnabled = true;
            this.cb_degisken.Items.AddRange(new object[] {
            "null"});
            this.cb_degisken.Location = new System.Drawing.Point(74, 39);
            this.cb_degisken.Name = "cb_degisken";
            this.cb_degisken.Size = new System.Drawing.Size(198, 21);
            this.cb_degisken.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Değişken";
            // 
            // txt_mesaj
            // 
            this.txt_mesaj.Location = new System.Drawing.Point(73, 12);
            this.txt_mesaj.Name = "txt_mesaj";
            this.txt_mesaj.Size = new System.Drawing.Size(199, 20);
            this.txt_mesaj.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mesaj";
            // 
            // Pencere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 107);
            this.Controls.Add(this.buton_tamamla);
            this.Controls.Add(this.cb_degisken);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_mesaj);
            this.Controls.Add(this.label1);
            this.Name = "Pencere";
            this.Text = "Pencere";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pencere_FormClosing);
            this.Load += new System.EventHandler(this.Pencere_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buton_tamamla;
        private System.Windows.Forms.ComboBox cb_degisken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mesaj;
        private System.Windows.Forms.Label label1;
    }
}