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
            this.mtxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataTimePickerNascimento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlListaCEP = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lswListaCEP = new System.Windows.Forms.ListView();
            this.CEP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Logradouro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bairro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Numero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCapturar = new System.Windows.Forms.Button();
            this.pctBoxCliente = new System.Windows.Forms.PictureBox();
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
            this.groupBox2.SuspendLayout();
            this.pnlListaCEP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(47, 10);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(191, 26);
            this.txtID.TabIndex = 3;
            // 
            // grpDadosPessoais
            // 
            this.grpDadosPessoais.Controls.Add(this.mtxtTelefone);
            this.grpDadosPessoais.Controls.Add(this.mtxtCPF);
            this.grpDadosPessoais.Controls.Add(this.cmbGenero);
            this.grpDadosPessoais.Controls.Add(this.cmbEstadoCivil);
            this.grpDadosPessoais.Controls.Add(this.label16);
            this.grpDadosPessoais.Controls.Add(this.label17);
            this.grpDadosPessoais.Controls.Add(this.label12);
            this.grpDadosPessoais.Controls.Add(this.dataTimePickerNascimento);
            this.grpDadosPessoais.Controls.Add(this.label5);
            this.grpDadosPessoais.Controls.Add(this.label4);
            this.grpDadosPessoais.Controls.Add(this.label3);
            this.grpDadosPessoais.Controls.Add(this.txtNome);
            this.grpDadosPessoais.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpDadosPessoais.Location = new System.Drawing.Point(16, 46);
            this.grpDadosPessoais.Margin = new System.Windows.Forms.Padding(4);
            this.grpDadosPessoais.Name = "grpDadosPessoais";
            this.grpDadosPessoais.Padding = new System.Windows.Forms.Padding(4);
            this.grpDadosPessoais.Size = new System.Drawing.Size(261, 368);
            this.grpDadosPessoais.TabIndex = 4;
            this.grpDadosPessoais.TabStop = false;
            this.grpDadosPessoais.Text = "Dados Pessoais";
            // 
            // mtxtTelefone
            // 
            this.mtxtTelefone.Location = new System.Drawing.Point(8, 97);
            this.mtxtTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtTelefone.Mask = "+99 (99) 0000-0000";
            this.mtxtTelefone.Name = "mtxtTelefone";
            this.mtxtTelefone.Size = new System.Drawing.Size(213, 22);
            this.mtxtTelefone.TabIndex = 26;
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.Location = new System.Drawing.Point(8, 150);
            this.mtxtCPF.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtCPF.Mask = "000,000,000-00";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(213, 22);
            this.mtxtCPF.TabIndex = 25;
            this.mtxtCPF.ValidatingType = typeof(int);
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Confirmar",
            "Feminino",
            "Masculino"});
            this.cmbGenero.Location = new System.Drawing.Point(8, 201);
            this.cmbGenero.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(213, 24);
            this.cmbGenero.TabIndex = 24;
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)",
            "Viuvo(a)"});
            this.cmbEstadoCivil.Location = new System.Drawing.Point(8, 261);
            this.cmbEstadoCivil.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(213, 24);
            this.cmbEstadoCivil.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(4, 238);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 20);
            this.label16.TabIndex = 19;
            this.label16.Text = "Estado Civil";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(4, 177);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 20);
            this.label17.TabIndex = 18;
            this.label17.Text = "Gênero";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 290);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Data de Nascimento";
            // 
            // dataTimePickerNascimento
            // 
            this.dataTimePickerNascimento.CalendarFont = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTimePickerNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataTimePickerNascimento.Location = new System.Drawing.Point(16, 314);
            this.dataTimePickerNascimento.Margin = new System.Windows.Forms.Padding(4);
            this.dataTimePickerNascimento.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dataTimePickerNascimento.MinDate = new System.DateTime(1900, 12, 31, 0, 0, 0, 0);
            this.dataTimePickerNascimento.Name = "dataTimePickerNascimento";
            this.dataTimePickerNascimento.Size = new System.Drawing.Size(107, 22);
            this.dataTimePickerNascimento.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome ";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(8, 43);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(213, 26);
            this.txtNome.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnlListaCEP);
            this.groupBox2.Controls.Add(this.btnCapturar);
            this.groupBox2.Controls.Add(this.pctBoxCliente);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(587, 46);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(533, 341);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Imagem";
            // 
            // pnlListaCEP
            // 
            this.pnlListaCEP.Controls.Add(this.label15);
            this.pnlListaCEP.Controls.Add(this.btnFechar);
            this.pnlListaCEP.Controls.Add(this.lswListaCEP);
            this.pnlListaCEP.Location = new System.Drawing.Point(0, 0);
            this.pnlListaCEP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlListaCEP.Name = "pnlListaCEP";
            this.pnlListaCEP.Size = new System.Drawing.Size(683, 341);
            this.pnlListaCEP.TabIndex = 13;
            this.pnlListaCEP.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 25);
            this.label15.TabIndex = 14;
            this.label15.Text = "Lista CEP";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFechar.Location = new System.Drawing.Point(8, 273);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(121, 54);
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
            this.lswListaCEP.Location = new System.Drawing.Point(3, 39);
            this.lswListaCEP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lswListaCEP.Name = "lswListaCEP";
            this.lswListaCEP.Size = new System.Drawing.Size(663, 228);
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
            // btnCapturar
            // 
            this.btnCapturar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCapturar.Location = new System.Drawing.Point(8, 288);
            this.btnCapturar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(111, 46);
            this.btnCapturar.TabIndex = 15;
            this.btnCapturar.Text = "CAPTURAR";
            this.btnCapturar.UseVisualStyleBackColor = false;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // pctBoxCliente
            // 
            this.pctBoxCliente.Location = new System.Drawing.Point(8, 23);
            this.pctBoxCliente.Margin = new System.Windows.Forms.Padding(4);
            this.pctBoxCliente.Name = "pctBoxCliente";
            this.pctBoxCliente.Size = new System.Drawing.Size(517, 257);
            this.pctBoxCliente.TabIndex = 0;
            this.pctBoxCliente.TabStop = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(16, 480);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(111, 58);
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
            this.btnLimpar.Location = new System.Drawing.Point(135, 480);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(111, 58);
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
            this.label7.Location = new System.Drawing.Point(7, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "CEP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Municipio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 286);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "N°";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(8, 309);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(48, 22);
            this.txtNumero.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 79);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "UF";
            // 
            // cmbUF
            // 
            this.cmbUF.FormattingEnabled = true;
            this.cmbUF.Items.AddRange(new object[] {
            "RS"});
            this.cmbUF.Location = new System.Drawing.Point(8, 102);
            this.cmbUF.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUF.Name = "cmbUF";
            this.cmbUF.Size = new System.Drawing.Size(53, 24);
            this.cmbUF.TabIndex = 13;
            this.cmbUF.SelectionChangeCommitted += new System.EventHandler(this.cmbUF_SelectionChangeCommitted);
            // 
            // cmbMunicipio
            // 
            this.cmbMunicipio.FormattingEnabled = true;
            this.cmbMunicipio.Location = new System.Drawing.Point(8, 155);
            this.cmbMunicipio.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMunicipio.Name = "cmbMunicipio";
            this.cmbMunicipio.Size = new System.Drawing.Size(148, 24);
            this.cmbMunicipio.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 238);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Logradouro";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(8, 261);
            this.txtLogradouro.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(209, 22);
            this.txtLogradouro.TabIndex = 16;
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
            this.groupBox1.Location = new System.Drawing.Point(293, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(273, 395);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            // 
            // mtxtCEP
            // 
            this.mtxtCEP.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxtCEP.Location = new System.Drawing.Point(8, 50);
            this.mtxtCEP.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtCEP.Mask = "00000-9999";
            this.mtxtCEP.Name = "mtxtCEP";
            this.mtxtCEP.Size = new System.Drawing.Size(205, 22);
            this.mtxtCEP.TabIndex = 23;
            this.mtxtCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(8, 209);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(136, 22);
            this.txtBairro.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 185);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "Bairro";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnPesquisar.Location = new System.Drawing.Point(112, 16);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(109, 31);
            this.btnPesquisar.TabIndex = 19;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 338);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Complemento";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(8, 361);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(4);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(136, 22);
            this.txtComplemento.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 11);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 24);
            this.label14.TabIndex = 2;
            this.label14.Text = "ID";
            // 
            // frmCadastroPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1297, 553);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpDadosPessoais);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtID);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCadastroPessoas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Clientes";
            this.Load += new System.EventHandler(this.frmCadastroPessoas_Load);
            this.grpDadosPessoais.ResumeLayout(false);
            this.grpDadosPessoais.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.pnlListaCEP.ResumeLayout(false);
            this.pnlListaCEP.PerformLayout();
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

