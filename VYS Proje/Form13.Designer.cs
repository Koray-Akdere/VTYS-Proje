﻿namespace VYS_Proje
{
    partial class Form13
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
            this.maskedTextBaslangicTarihi = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBitisTarihi = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textHedef = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBeslenmeId = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextProgramId = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnIdAra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(410, 239);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(225, 70);
            this.btnGuncelle.TabIndex = 54;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(410, 138);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(225, 70);
            this.btnSil.TabIndex = 53;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(410, 37);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(225, 70);
            this.btnEkle.TabIndex = 52;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // maskedTextBaslangicTarihi
            // 
            this.maskedTextBaslangicTarihi.Location = new System.Drawing.Point(204, 217);
            this.maskedTextBaslangicTarihi.Mask = "00/00/0000";
            this.maskedTextBaslangicTarihi.Name = "maskedTextBaslangicTarihi";
            this.maskedTextBaslangicTarihi.Size = new System.Drawing.Size(125, 29);
            this.maskedTextBaslangicTarihi.TabIndex = 58;
            this.maskedTextBaslangicTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBitisTarihi
            // 
            this.maskedTextBitisTarihi.Location = new System.Drawing.Point(204, 277);
            this.maskedTextBitisTarihi.Mask = "00/00/0000";
            this.maskedTextBitisTarihi.Name = "maskedTextBitisTarihi";
            this.maskedTextBitisTarihi.Size = new System.Drawing.Size(125, 29);
            this.maskedTextBitisTarihi.TabIndex = 57;
            this.maskedTextBitisTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 23);
            this.label7.TabIndex = 56;
            this.label7.Text = "Bitiş Tarihi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 23);
            this.label6.TabIndex = 55;
            this.label6.Text = "Başlangıç Tarihi :";
            // 
            // textHedef
            // 
            this.textHedef.Location = new System.Drawing.Point(204, 157);
            this.textHedef.Name = "textHedef";
            this.textHedef.Size = new System.Drawing.Size(125, 29);
            this.textHedef.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 59;
            this.label3.Text = "Hedef :";
            // 
            // maskedTextBeslenmeId
            // 
            this.maskedTextBeslenmeId.Location = new System.Drawing.Point(204, 97);
            this.maskedTextBeslenmeId.Mask = "00000";
            this.maskedTextBeslenmeId.Name = "maskedTextBeslenmeId";
            this.maskedTextBeslenmeId.Size = new System.Drawing.Size(125, 29);
            this.maskedTextBeslenmeId.TabIndex = 62;
            this.maskedTextBeslenmeId.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 61;
            this.label2.Text = "Beslenme ID :";
            // 
            // maskedTextProgramId
            // 
            this.maskedTextProgramId.Location = new System.Drawing.Point(204, 37);
            this.maskedTextProgramId.Mask = "00000";
            this.maskedTextProgramId.Name = "maskedTextProgramId";
            this.maskedTextProgramId.Size = new System.Drawing.Size(125, 29);
            this.maskedTextProgramId.TabIndex = 68;
            this.maskedTextProgramId.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 67;
            this.label1.Text = "Program ID :";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(410, 340);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(225, 70);
            this.btnAra.TabIndex = 69;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnIdAra
            // 
            this.btnIdAra.Location = new System.Drawing.Point(104, 340);
            this.btnIdAra.Name = "btnIdAra";
            this.btnIdAra.Size = new System.Drawing.Size(225, 70);
            this.btnIdAra.TabIndex = 70;
            this.btnIdAra.Text = "ID Ara";
            this.btnIdAra.UseVisualStyleBackColor = true;
            this.btnIdAra.Click += new System.EventHandler(this.btnIdAra_Click);
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(684, 445);
            this.Controls.Add(this.btnIdAra);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.maskedTextProgramId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBeslenmeId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textHedef);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextBaslangicTarihi);
            this.Controls.Add(this.maskedTextBitisTarihi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form13";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Antrenman Programı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.MaskedTextBox maskedTextBaslangicTarihi;
        private System.Windows.Forms.MaskedTextBox maskedTextBitisTarihi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textHedef;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBeslenmeId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextProgramId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnIdAra;
    }
}