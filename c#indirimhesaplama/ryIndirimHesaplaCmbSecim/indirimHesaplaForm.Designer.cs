namespace ryIndirimHesaplaCmbSecim
{
    partial class indirimHesaplaForm
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
            this.cmbKdvOran = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbIndirim = new System.Windows.Forms.ComboBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.tbToplamTutar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIndirimTutar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbKdvMiktar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTutar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbKdvOran
            // 
            this.cmbKdvOran.FormattingEnabled = true;
            this.cmbKdvOran.Items.AddRange(new object[] {
            "% 1",
            "% 10",
            "% 20"});
            this.cmbKdvOran.Location = new System.Drawing.Point(116, 127);
            this.cmbKdvOran.Name = "cmbKdvOran";
            this.cmbKdvOran.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbKdvOran.Size = new System.Drawing.Size(99, 24);
            this.cmbKdvOran.TabIndex = 3;
            this.cmbKdvOran.SelectedIndexChanged += new System.EventHandler(this.cmbKdvOran_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "KDV Oranı";
            // 
            // cmbIndirim
            // 
            this.cmbIndirim.FormattingEnabled = true;
            this.cmbIndirim.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25"});
            this.cmbIndirim.Location = new System.Drawing.Point(117, 53);
            this.cmbIndirim.Name = "cmbIndirim";
            this.cmbIndirim.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbIndirim.Size = new System.Drawing.Size(99, 24);
            this.cmbIndirim.TabIndex = 1;
            this.cmbIndirim.SelectedIndexChanged += new System.EventHandler(this.cmbIndirim_SelectedIndexChanged);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(142, 241);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 34);
            this.btnKapat.TabIndex = 6;
            this.btnKapat.Text = "Çıkış";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // tbToplamTutar
            // 
            this.tbToplamTutar.Enabled = false;
            this.tbToplamTutar.Location = new System.Drawing.Point(116, 201);
            this.tbToplamTutar.MaxLength = 5;
            this.tbToplamTutar.Name = "tbToplamTutar";
            this.tbToplamTutar.Size = new System.Drawing.Size(100, 24);
            this.tbToplamTutar.TabIndex = 5;
            this.tbToplamTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Toplam Tutar";
            // 
            // tbIndirimTutar
            // 
            this.tbIndirimTutar.Enabled = false;
            this.tbIndirimTutar.Location = new System.Drawing.Point(116, 90);
            this.tbIndirimTutar.MaxLength = 5;
            this.tbIndirimTutar.Name = "tbIndirimTutar";
            this.tbIndirimTutar.Size = new System.Drawing.Size(100, 24);
            this.tbIndirimTutar.TabIndex = 2;
            this.tbIndirimTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "İndirimli Tutar";
            // 
            // tbKdvMiktar
            // 
            this.tbKdvMiktar.Enabled = false;
            this.tbKdvMiktar.Location = new System.Drawing.Point(116, 164);
            this.tbKdvMiktar.MaxLength = 5;
            this.tbKdvMiktar.Name = "tbKdvMiktar";
            this.tbKdvMiktar.Size = new System.Drawing.Size(100, 24);
            this.tbKdvMiktar.TabIndex = 4;
            this.tbKdvMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "KDV Miktarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "İndirim Oranı";
            // 
            // tbTutar
            // 
            this.tbTutar.Location = new System.Drawing.Point(117, 16);
            this.tbTutar.MaxLength = 5;
            this.tbTutar.Name = "tbTutar";
            this.tbTutar.Size = new System.Drawing.Size(100, 24);
            this.tbTutar.TabIndex = 0;
            this.tbTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Ürün Tutarı";
            // 
            // indirimHesaplaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 293);
            this.ControlBox = false;
            this.Controls.Add(this.cmbKdvOran);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbIndirim);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.tbToplamTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbIndirimTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbKdvMiktar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTutar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "indirimHesaplaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İndirim Hesapla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKdvOran;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbIndirim;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.TextBox tbToplamTutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIndirimTutar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbKdvMiktar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTutar;
        private System.Windows.Forms.Label label1;
    }
}

