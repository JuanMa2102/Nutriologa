﻿namespace Login
{
    partial class frmReporte
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Campo2 = new System.Windows.Forms.TextBox();
            this.campo1 = new System.Windows.Forms.TextBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.pictureclose = new System.Windows.Forms.PictureBox();
            this.btnAgendar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureclose)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(96, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "FECHA FIN";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(96, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "FECHA INICIO";
            // 
            // Campo2
            // 
            this.Campo2.Location = new System.Drawing.Point(99, 206);
            this.Campo2.Name = "Campo2";
            this.Campo2.Size = new System.Drawing.Size(245, 20);
            this.Campo2.TabIndex = 11;
            // 
            // campo1
            // 
            this.campo1.Location = new System.Drawing.Point(99, 120);
            this.campo1.Name = "campo1";
            this.campo1.Size = new System.Drawing.Size(245, 20);
            this.campo1.TabIndex = 10;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.White;
            this.Titulo.Location = new System.Drawing.Point(93, 29);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(281, 31);
            this.Titulo.TabIndex = 16;
            this.Titulo.Text = "Pacientes Atendidos";
            // 
            // pictureclose
            // 
            this.pictureclose.Location = new System.Drawing.Point(427, 12);
            this.pictureclose.Name = "pictureclose";
            this.pictureclose.Size = new System.Drawing.Size(23, 22);
            this.pictureclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureclose.TabIndex = 15;
            this.pictureclose.TabStop = false;
            // 
            // btnAgendar
            // 
            this.btnAgendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(160)))), ((int)(((byte)(172)))));
            this.btnAgendar.Image = global::Login.Properties.Resources.ico_10;
            this.btnAgendar.Location = new System.Drawing.Point(166, 258);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(119, 83);
            this.btnAgendar.TabIndex = 14;
            this.btnAgendar.Text = "HACER REPORTE";
            this.btnAgendar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgendar.UseVisualStyleBackColor = false;
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(66)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(455, 363);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.pictureclose);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Campo2);
            this.Controls.Add(this.campo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Campo2;
        private System.Windows.Forms.TextBox campo1;
        private System.Windows.Forms.PictureBox pictureclose;
        private System.Windows.Forms.Label Titulo;
    }
}