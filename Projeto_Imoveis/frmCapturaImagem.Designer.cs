﻿namespace Projeto_Imoveis
{
    partial class frmCapturaImagem
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pctBoxCaptura = new System.Windows.Forms.PictureBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.cmbDispositivos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxCaptura)).BeginInit();
            this.SuspendLayout();
            // 
            // pctBoxCaptura
            // 
            this.pctBoxCaptura.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pctBoxCaptura.Location = new System.Drawing.Point(16, 15);
            this.pctBoxCaptura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pctBoxCaptura.Name = "pctBoxCaptura";
            this.pctBoxCaptura.Size = new System.Drawing.Size(853, 497);
            this.pctBoxCaptura.TabIndex = 0;
            this.pctBoxCaptura.TabStop = false;
            // 
            // btnCapturar
            // 
            this.btnCapturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapturar.Location = new System.Drawing.Point(769, 519);
            this.btnCapturar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(100, 53);
            this.btnCapturar.TabIndex = 1;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // cmbDispositivos
            // 
            this.cmbDispositivos.FormattingEnabled = true;
            this.cmbDispositivos.Location = new System.Drawing.Point(12, 544);
            this.cmbDispositivos.Name = "cmbDispositivos";
            this.cmbDispositivos.Size = new System.Drawing.Size(183, 24);
            this.cmbDispositivos.TabIndex = 2;
            this.cmbDispositivos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDispositivos_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dispositivos de vídeo";
            // 
            // frmCapturaImagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(885, 587);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDispositivos);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.pctBoxCaptura);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCapturaImagem";
            this.Text = "Captura de Imagem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCapturaImagem_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxCaptura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox pctBoxCaptura;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.ComboBox cmbDispositivos;
        private System.Windows.Forms.Label label1;
    }
}