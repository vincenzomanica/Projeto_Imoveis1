namespace Projeto_Imoveis
{
    partial class frmCadastroPessoas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.grpDadosPessoais = new System.Windows.Forms.GroupBox();
            this.pnlListaCEP = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lswListaCEP = new System.Windows.Forms.ListView();
            this.CEP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Logradouro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bairro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Numero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mtxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataTimePickerNascimento = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.pctBoxCliente = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbUF = new System.Windows.Forms.ComboBox();
            this.cmbMunicipio = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtxtCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.grpDadosPessoais.SuspendLayout();
            this.pnlListaCEP.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(35, 8);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(144, 22);
            this.txtID.TabIndex = 3;
            // 
            // grpDadosPessoais
            // 
            this.grpDadosPessoais.Controls.Add(this.pnlListaCEP);
            this.grpDadosPessoais.Controls.Add(this.mtxtTelefone);
            this.grpDadosPessoais.Controls.Add(this.mtxtCPF);
            this.grpDadosPessoais.Controls.Add(this.cmbGenero);
            this.grpDadosPessoais.Controls.Add(this.cmbEstadoCivil);
            this.grpDadosPessoais.Controls.Add(this.label16);
            this.grpDadosPessoais.Controls.Add(this.label17);
            this.grpDadosPessoais.Controls.Add(this.label12);
            this.grpDadosPessoais.Controls.Add(this.dataTimePickerNascimento);
            this.grpDadosPessoais.Controls.Add(this.groupBox2);
            this.grpDadosPessoais.Controls.Add(this.label5);
            this.grpDadosPessoais.Controls.Add(this.label4);
            this.grpDadosPessoais.Controls.Add(this.label3);
            this.grpDadosPessoais.Controls.Add(this.txtNome);
            this.grpDadosPessoais.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpDadosPessoais.Location = new System.Drawing.Point(12, 37);
            this.grpDadosPessoais.Name = "grpDadosPessoais";
            this.grpDadosPessoais.Size = new System.Drawing.Size(600, 299);
            this.grpDadosPessoais.TabIndex = 4;
            this.grpDadosPessoais.TabStop = false;
            this.grpDadosPessoais.Text = "Dados Pessoais";
            // 
            // pnlListaCEP
            // 
            this.pnlListaCEP.Controls.Add(this.label15);
            this.pnlListaCEP.Controls.Add(this.btnFechar);
            this.pnlListaCEP.Controls.Add(this.lswListaCEP);
            this.pnlListaCEP.Location = new System.Drawing.Point(194, 0);
            this.pnlListaCEP.Margin = new System.Windows.Forms.Padding(2);
            this.pnlListaCEP.Name = "pnlListaCEP";
            this.pnlListaCEP.Size = new System.Drawing.Size(512, 301);
            this.pnlListaCEP.TabIndex = 13;
            this.pnlListaCEP.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(2, 10);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 20);
            this.label15.TabIndex = 14;
            this.label15.Text = "Lista CEP";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFechar.Location = new System.Drawing.Point(5, 230);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(91, 44);
            this.btnFechar.TabIndex = 13;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lswListaCEP
            // 
            this.lswListaCEP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CEP,
            this.Logradouro,
            this.Bairro,
            this.Numero});
            this.lswListaCEP.FullRowSelect = true;
            this.lswListaCEP.GridLines = true;
            this.lswListaCEP.HideSelection = false;
            this.lswListaCEP.Location = new System.Drawing.Point(2, 32);
            this.lswListaCEP.Margin = new System.Windows.Forms.Padding(2);
            this.lswListaCEP.Name = "lswListaCEP";
            this.lswListaCEP.Size = new System.Drawing.Size(498, 186);
            this.lswListaCEP.TabIndex = 0;
            this.lswListaCEP.UseCompatibleStateImageBehavior = false;
            this.lswListaCEP.View = System.Windows.Forms.View.Details;
            this.lswListaCEP.SelectedIndexChanged += new System.EventHandler(this.lswListaCEP_SelectedIndexChanged);
            // 
            // CEP
            // 
            this.CEP.Text = "CEP";
            this.CEP.Width = 100;
            // 
            // Logradouro
            // 
            this.Logradouro.Text = "Logradouro";
            this.Logradouro.Width = 200;
            // 
            // Bairro
            // 
            this.Bairro.Text = "Bairro";
            this.Bairro.Width = 200;
            // 
            // Numero
            // 
            this.Numero.Text = "Numero";
            this.Numero.Width = 100;
            // 
            // mtxtTelefone
            // 
            this.mtxtTelefone.Location = new System.Drawing.Point(6, 79);
            this.mtxtTelefone.Mask = "+99 (99) 0000-0000";
            this.mtxtTelefone.Name = "mtxtTelefone";
            this.mtxtTelefone.Size = new System.Drawing.Size(161, 20);
            this.mtxtTelefone.TabIndex = 26;
            this.mtxtTelefone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtxtTelefone_KeyDown);
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.Location = new System.Drawing.Point(6, 122);
            this.mtxtCPF.Mask = "000,000,000-00";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(161, 20);
            this.mtxtCPF.TabIndex = 25;
            this.mtxtCPF.ValidatingType = typeof(int);
            this.mtxtCPF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtxtCPF_KeyDown);
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Confirmar",
            "Feminino",
            "Masculino"});
            this.cmbGenero.Location = new System.Drawing.Point(6, 163);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(161, 21);
            this.cmbGenero.TabIndex = 24;
            this.cmbGenero.Enter += new System.EventHandler(this.cmb_Enter);
            this.cmbGenero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbGenero_KeyDown);
            this.cmbGenero.Leave += new System.EventHandler(this.cmb_Leave);
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)",
            "Viuvo(a)"});
            this.cmbEstadoCivil.Location = new System.Drawing.Point(6, 212);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(161, 21);
            this.cmbEstadoCivil.TabIndex = 23;
            this.cmbEstadoCivil.Enter += new System.EventHandler(this.cmb_Enter);
            this.cmbEstadoCivil.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEstadoCivil_KeyDown);
            this.cmbEstadoCivil.Leave += new System.EventHandler(this.cmb_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 193);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 16);
            this.label16.TabIndex = 19;
            this.label16.Text = "Estado Civil";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(3, 144);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 16);
            this.label17.TabIndex = 18;
            this.label17.Text = "Gênero";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 236);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 16);
            this.label12.TabIndex = 17;
            this.label12.Text = "Data de Nascimento";
            // 
            // dataTimePickerNascimento
            // 
            this.dataTimePickerNascimento.CalendarFont = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTimePickerNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataTimePickerNascimento.Location = new System.Drawing.Point(12, 255);
            this.dataTimePickerNascimento.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dataTimePickerNascimento.MinDate = new System.DateTime(1900, 12, 31, 0, 0, 0, 0);
            this.dataTimePickerNascimento.Name = "dataTimePickerNascimento";
            this.dataTimePickerNascimento.Size = new System.Drawing.Size(81, 20);
            this.dataTimePickerNascimento.TabIndex = 16;
            this.dataTimePickerNascimento.Enter += new System.EventHandler(this.dataTimePickerNascimento_Enter);
            this.dataTimePickerNascimento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataTimePickerNascimento_KeyDown_1);
            this.dataTimePickerNascimento.Leave += new System.EventHandler(this.dataTimePickerNascimento_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCapturar);
            this.groupBox2.Controls.Add(this.pctBoxCliente);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(194, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 277);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Imagem";
            // 
            // btnCapturar
            // 
            this.btnCapturar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCapturar.Location = new System.Drawing.Point(6, 234);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(83, 37);
            this.btnCapturar.TabIndex = 15;
            this.btnCapturar.Text = "CAPTURAR";
            this.btnCapturar.UseVisualStyleBackColor = false;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            this.btnCapturar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnCapturar_KeyDown);
            // 
            // pctBoxCliente
            // 
            this.pctBoxCliente.Location = new System.Drawing.Point(6, 19);
            this.pctBoxCliente.Name = "pctBoxCliente";
            this.pctBoxCliente.Size = new System.Drawing.Size(388, 209);
            this.pctBoxCliente.TabIndex = 0;
            this.pctBoxCliente.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome ";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(6, 35);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(161, 22);
            this.txtNome.TabIndex = 4;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(12, 483);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(83, 47);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            this.btnSalvar.Enter += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(101, 483);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(83, 47);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Tag = "";
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "CEP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Municipio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(339, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "N°";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(341, 42);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(37, 20);
            this.txtNumero.TabIndex = 11;
            this.txtNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumero_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "UF";
            // 
            // cmbUF
            // 
            this.cmbUF.FormattingEnabled = true;
            this.cmbUF.Items.AddRange(new object[] {
            "RS"});
            this.cmbUF.Location = new System.Drawing.Point(12, 83);
            this.cmbUF.Name = "cmbUF";
            this.cmbUF.Size = new System.Drawing.Size(41, 21);
            this.cmbUF.TabIndex = 13;
            this.cmbUF.SelectedIndexChanged += new System.EventHandler(this.cmbUF_SelectedIndexChanged);
            this.cmbUF.Enter += new System.EventHandler(this.cmb_Enter);
            this.cmbUF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbUF_KeyDown);
            this.cmbUF.Leave += new System.EventHandler(this.cmb_Leave);
            // 
            // cmbMunicipio
            // 
            this.cmbMunicipio.FormattingEnabled = true;
            this.cmbMunicipio.Location = new System.Drawing.Point(59, 83);
            this.cmbMunicipio.Name = "cmbMunicipio";
            this.cmbMunicipio.Size = new System.Drawing.Size(112, 21);
            this.cmbMunicipio.TabIndex = 14;
            this.cmbMunicipio.Enter += new System.EventHandler(this.cmb_Enter);
            this.cmbMunicipio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbMunicipio_KeyDown);
            this.cmbMunicipio.Leave += new System.EventHandler(this.cmb_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(175, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Logradouro";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(177, 41);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(158, 20);
            this.txtLogradouro.TabIndex = 16;
            this.txtLogradouro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLogradouro_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtxtCEP);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtComplemento);
            this.groupBox1.Controls.Add(this.txtLogradouro);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbMunicipio);
            this.groupBox1.Controls.Add(this.cmbUF);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 119);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "pes";
            // 
            // mtxtCEP
            // 
            this.mtxtCEP.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxtCEP.Location = new System.Drawing.Point(12, 41);
            this.mtxtCEP.Mask = "00000-9999";
            this.mtxtCEP.Name = "mtxtCEP";
            this.mtxtCEP.Size = new System.Drawing.Size(155, 20);
            this.mtxtCEP.TabIndex = 23;
            this.mtxtCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxtCEP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtxtCEP_KeyDown);
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(494, 42);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(103, 20);
            this.txtBairro.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(491, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 16);
            this.label13.TabIndex = 21;
            this.label13.Text = "Bairro";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnPesquisar.Location = new System.Drawing.Point(84, 13);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(82, 25);
            this.btnPesquisar.TabIndex = 19;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(382, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Complemento";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(385, 42);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(103, 20);
            this.txtComplemento.TabIndex = 17;
            this.txtComplemento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComplemento_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(5, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 18);
            this.label14.TabIndex = 2;
            this.label14.Text = "ID";
            // 
            // frmCadastroPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(953, 545);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpDadosPessoais);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Name = "frmCadastroPessoas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Clientes";
            this.Load += new System.EventHandler(this.frmCadastroPessoas_Load);
            this.grpDadosPessoais.ResumeLayout(false);
            this.grpDadosPessoais.PerformLayout();
            this.pnlListaCEP.ResumeLayout(false);
            this.pnlListaCEP.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox grpDadosPessoais;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbUF;
        private System.Windows.Forms.ComboBox cmbMunicipio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.DateTimePicker dataTimePickerNascimento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbEstadoCivil;
        private System.Windows.Forms.MaskedTextBox mtxtCPF;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.MaskedTextBox mtxtCEP;
        private System.Windows.Forms.MaskedTextBox mtxtTelefone;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.PictureBox pctBoxCliente;
        private System.Windows.Forms.Panel pnlListaCEP;
        private System.Windows.Forms.ListView lswListaCEP;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ColumnHeader CEP;
        private System.Windows.Forms.ColumnHeader Logradouro;
        private System.Windows.Forms.ColumnHeader Bairro;
        private System.Windows.Forms.ColumnHeader Numero;
    }
}

