namespace Projeto_Imoveis
{
    partial class ListaDeClientes
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
            this.lswListaClientes = new System.Windows.Forms.ListView();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.rbtnID = new System.Windows.Forms.RadioButton();
            this.rbtnCPF = new System.Windows.Forms.RadioButton();
            this.rbtnNome = new System.Windows.Forms.RadioButton();
            this.rbtnTelefone = new System.Windows.Forms.RadioButton();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lswListaClientes
            // 
            this.lswListaClientes.FullRowSelect = true;
            this.lswListaClientes.GridLines = true;
            this.lswListaClientes.HideSelection = false;
            this.lswListaClientes.Location = new System.Drawing.Point(11, 38);
            this.lswListaClientes.Margin = new System.Windows.Forms.Padding(4);
            this.lswListaClientes.Name = "lswListaClientes";
            this.lswListaClientes.Size = new System.Drawing.Size(529, 266);
            this.lswListaClientes.TabIndex = 0;
            this.lswListaClientes.UseCompatibleStateImageBehavior = false;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(7, 23);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(145, 24);
            this.txtPesquisar.TabIndex = 1;
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(548, 138);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(91, 42);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(548, 88);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(91, 42);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // rbtnID
            // 
            this.rbtnID.AutoSize = true;
            this.rbtnID.Location = new System.Drawing.Point(7, 24);
            this.rbtnID.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnID.Name = "rbtnID";
            this.rbtnID.Size = new System.Drawing.Size(43, 21);
            this.rbtnID.TabIndex = 10;
            this.rbtnID.TabStop = true;
            this.rbtnID.Text = "ID";
            this.rbtnID.UseVisualStyleBackColor = true;
            // 
            // rbtnCPF
            // 
            this.rbtnCPF.AutoSize = true;
            this.rbtnCPF.Location = new System.Drawing.Point(68, 60);
            this.rbtnCPF.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnCPF.Name = "rbtnCPF";
            this.rbtnCPF.Size = new System.Drawing.Size(53, 21);
            this.rbtnCPF.TabIndex = 11;
            this.rbtnCPF.TabStop = true;
            this.rbtnCPF.Text = "CPF";
            this.rbtnCPF.UseVisualStyleBackColor = true;
            // 
            // rbtnNome
            // 
            this.rbtnNome.AutoSize = true;
            this.rbtnNome.Location = new System.Drawing.Point(7, 60);
            this.rbtnNome.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnNome.Name = "rbtnNome";
            this.rbtnNome.Size = new System.Drawing.Size(60, 21);
            this.rbtnNome.TabIndex = 12;
            this.rbtnNome.TabStop = true;
            this.rbtnNome.Text = "Nome";
            this.rbtnNome.UseVisualStyleBackColor = true;
            // 
            // rbtnTelefone
            // 
            this.rbtnTelefone.AutoSize = true;
            this.rbtnTelefone.Location = new System.Drawing.Point(52, 24);
            this.rbtnTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnTelefone.Name = "rbtnTelefone";
            this.rbtnTelefone.Size = new System.Drawing.Size(78, 21);
            this.rbtnTelefone.TabIndex = 13;
            this.rbtnTelefone.TabStop = true;
            this.rbtnTelefone.Text = "Telefone";
            this.rbtnTelefone.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(548, 38);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(91, 42);
            this.btnAdicionar.TabIndex = 14;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnCPF);
            this.groupBox1.Controls.Add(this.rbtnID);
            this.groupBox1.Controls.Add(this.rbtnNome);
            this.groupBox1.Controls.Add(this.rbtnTelefone);
            this.groupBox1.Location = new System.Drawing.Point(188, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 103);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(548, 238);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(91, 42);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(548, 188);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(91, 42);
            this.btnAtualizar.TabIndex = 17;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(13, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "ListaCliente";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPesquisar);
            this.groupBox2.Location = new System.Drawing.Point(16, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 64);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PESQUISAR";
            // 
            // ListaDeClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(654, 424);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lswListaClientes);
            this.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListaDeClientes";
            this.Text = "ListaClientes";
            this.Load += new System.EventHandler(this.ListaDeClientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lswListaClientes;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.RadioButton rbtnID;
        private System.Windows.Forms.RadioButton rbtnCPF;
        private System.Windows.Forms.RadioButton rbtnNome;
        private System.Windows.Forms.RadioButton rbtnTelefone;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}