﻿namespace VYS_Proje
{
    partial class Form3
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextKisiId = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextMaas = new System.Windows.Forms.MaskedTextBox();
            this.textUzmanlik = new System.Windows.Forms.TextBox();
            this.maskedTextDeneyim = new System.Windows.Forms.MaskedTextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnIdAra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(384, 227);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(225, 70);
            this.btnGuncelle.TabIndex = 24;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(384, 135);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(225, 70);
            this.btnSil.TabIndex = 23;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(384, 43);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(225, 70);
            this.btnEkle.TabIndex = 22;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Kişi ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Uzmanlık :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Deneyim(Yıl) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Maaş :";
            // 
            // maskedTextKisiId
            // 
            this.maskedTextKisiId.Location = new System.Drawing.Point(194, 64);
            this.maskedTextKisiId.Mask = "00000";
            this.maskedTextKisiId.Name = "maskedTextKisiId";
            this.maskedTextKisiId.Size = new System.Drawing.Size(125, 29);
            this.maskedTextKisiId.TabIndex = 30;
            this.maskedTextKisiId.ValidatingType = typeof(int);
            // 
            // maskedTextMaas
            // 
            this.maskedTextMaas.Location = new System.Drawing.Point(194, 244);
            this.maskedTextMaas.Mask = "000000";
            this.maskedTextMaas.Name = "maskedTextMaas";
            this.maskedTextMaas.Size = new System.Drawing.Size(125, 29);
            this.maskedTextMaas.TabIndex = 31;
            this.maskedTextMaas.ValidatingType = typeof(int);
            // 
            // textUzmanlik
            // 
            this.textUzmanlik.Location = new System.Drawing.Point(194, 124);
            this.textUzmanlik.Name = "textUzmanlik";
            this.textUzmanlik.Size = new System.Drawing.Size(125, 29);
            this.textUzmanlik.TabIndex = 32;
            // 
            // maskedTextDeneyim
            // 
            this.maskedTextDeneyim.Location = new System.Drawing.Point(194, 184);
            this.maskedTextDeneyim.Mask = "00";
            this.maskedTextDeneyim.Name = "maskedTextDeneyim";
            this.maskedTextDeneyim.Size = new System.Drawing.Size(125, 29);
            this.maskedTextDeneyim.TabIndex = 36;
            this.maskedTextDeneyim.ValidatingType = typeof(int);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(384, 319);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(225, 70);
            this.btnAra.TabIndex = 57;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnIdAra
            // 
            this.btnIdAra.Location = new System.Drawing.Point(94, 319);
            this.btnIdAra.Name = "btnIdAra";
            this.btnIdAra.Size = new System.Drawing.Size(225, 70);
            this.btnIdAra.TabIndex = 59;
            this.btnIdAra.Text = "ID Ara";
            this.btnIdAra.UseVisualStyleBackColor = true;
            this.btnIdAra.Click += new System.EventHandler(this.btnIdAra_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(659, 438);
            this.Controls.Add(this.btnIdAra);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.maskedTextDeneyim);
            this.Controls.Add(this.textUzmanlik);
            this.Controls.Add(this.maskedTextMaas);
            this.Controls.Add(this.maskedTextKisiId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çalışan";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextKisiId;
        private System.Windows.Forms.MaskedTextBox maskedTextMaas;
        private System.Windows.Forms.TextBox textUzmanlik;
        private System.Windows.Forms.MaskedTextBox maskedTextDeneyim;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnIdAra;
    }
}