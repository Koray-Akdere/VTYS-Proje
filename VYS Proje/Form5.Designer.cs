﻿namespace VYS_Proje
{
    partial class Form5
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
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextKisiId = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextPaketId = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedTextBitisTarihi = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBaslangicTarihi = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextUyelikId = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnIdAra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(428, 224);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(225, 70);
            this.btnGuncelle.TabIndex = 30;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(428, 135);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(225, 70);
            this.btnSil.TabIndex = 29;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(428, 46);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(225, 70);
            this.btnEkle.TabIndex = 28;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = "Kişi ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "Paket ID :";
            // 
            // maskedTextKisiId
            // 
            this.maskedTextKisiId.Location = new System.Drawing.Point(240, 152);
            this.maskedTextKisiId.Mask = "00000";
            this.maskedTextKisiId.Name = "maskedTextKisiId";
            this.maskedTextKisiId.Size = new System.Drawing.Size(125, 29);
            this.maskedTextKisiId.TabIndex = 36;
            this.maskedTextKisiId.ValidatingType = typeof(int);
            // 
            // maskedTextPaketId
            // 
            this.maskedTextPaketId.Location = new System.Drawing.Point(240, 99);
            this.maskedTextPaketId.Mask = "00000";
            this.maskedTextPaketId.Name = "maskedTextPaketId";
            this.maskedTextPaketId.Size = new System.Drawing.Size(125, 29);
            this.maskedTextPaketId.TabIndex = 37;
            this.maskedTextPaketId.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 23);
            this.label6.TabIndex = 41;
            this.label6.Text = "Başlangıç Tarihi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 23);
            this.label7.TabIndex = 42;
            this.label7.Text = "Bitiş Tarihi :";
            // 
            // maskedTextBitisTarihi
            // 
            this.maskedTextBitisTarihi.Location = new System.Drawing.Point(240, 258);
            this.maskedTextBitisTarihi.Mask = "00/00/0000";
            this.maskedTextBitisTarihi.Name = "maskedTextBitisTarihi";
            this.maskedTextBitisTarihi.Size = new System.Drawing.Size(125, 29);
            this.maskedTextBitisTarihi.TabIndex = 43;
            this.maskedTextBitisTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBaslangicTarihi
            // 
            this.maskedTextBaslangicTarihi.Location = new System.Drawing.Point(240, 205);
            this.maskedTextBaslangicTarihi.Mask = "00/00/0000";
            this.maskedTextBaslangicTarihi.Name = "maskedTextBaslangicTarihi";
            this.maskedTextBaslangicTarihi.Size = new System.Drawing.Size(125, 29);
            this.maskedTextBaslangicTarihi.TabIndex = 44;
            this.maskedTextBaslangicTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextUyelikId
            // 
            this.maskedTextUyelikId.Location = new System.Drawing.Point(240, 46);
            this.maskedTextUyelikId.Mask = "00000";
            this.maskedTextUyelikId.Name = "maskedTextUyelikId";
            this.maskedTextUyelikId.Size = new System.Drawing.Size(125, 29);
            this.maskedTextUyelikId.TabIndex = 45;
            this.maskedTextUyelikId.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 46;
            this.label3.Text = "Üyelik ID :";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(428, 313);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(225, 70);
            this.btnAra.TabIndex = 57;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnIdAra
            // 
            this.btnIdAra.Location = new System.Drawing.Point(140, 313);
            this.btnIdAra.Name = "btnIdAra";
            this.btnIdAra.Size = new System.Drawing.Size(225, 70);
            this.btnIdAra.TabIndex = 59;
            this.btnIdAra.Text = "ID Ara";
            this.btnIdAra.UseVisualStyleBackColor = true;
            this.btnIdAra.Click += new System.EventHandler(this.btnIdAra_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(687, 418);
            this.Controls.Add(this.btnIdAra);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextUyelikId);
            this.Controls.Add(this.maskedTextBaslangicTarihi);
            this.Controls.Add(this.maskedTextBitisTarihi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maskedTextPaketId);
            this.Controls.Add(this.maskedTextKisiId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üyelik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextKisiId;
        private System.Windows.Forms.MaskedTextBox maskedTextPaketId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskedTextBitisTarihi;
        private System.Windows.Forms.MaskedTextBox maskedTextBaslangicTarihi;
        private System.Windows.Forms.MaskedTextBox maskedTextUyelikId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnIdAra;
    }
}