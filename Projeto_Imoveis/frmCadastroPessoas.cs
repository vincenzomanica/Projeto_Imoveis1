/*using AForge.Video.DirectShow;
using AForge.Video;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Imoveis
{
    public partial class frmCadastroPessoas : Form
    {
        private Pessoas p = new Pessoas();
        private FilterInfoCollection videoDevices;
        // Dispositivo de captura selecionado
        private VideoCaptureDevice videoSource;

        private int lastGenerateID = 1;
        public frmCadastroPessoas()
        {
            InitializeComponent();




            //Combo Box Opções
            cmbEstadoCivil.Items.Add("Solteiro(a)");
            cmbEstadoCivil.Items.Add("Casado(a)");
            cmbEstadoCivil.Items.Add("Viuvo(a)");
        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Pessoas pessoa = new Pessoas();

            pessoa.Nome = txtNome.Text;
            pessoa.Telefone = txtTelefone.Text;
            pessoa.CEP = txtCEP.Text;
            pessoa.CPF = txtCPF.Text;
            pessoa.Numero = txtNumero.Text;
            pessoa.Logradouro = txtLogradouro.Text;
            pessoa.UF = cmbUF.Text;
            pessoa.Cidade = cmbMunicipio.Text;
            pessoa.ID = txtID.Text;
            pessoa.DataDeNascimento = dataTimePickerNascimento.Text;
            pessoa.EstadoCivil = cmbEstadoCivil.Text;
            pessoa.Genero = cmbGenero.Text;

            //Incluir pessoa a Lista
            bool Inserir = p.inserir(pessoa);
            if (Inserir == true)
                MessageBox.Show("Pessoa Inserida com sucesso");



        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {

        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }


    }
}
/*/
using AForge.Video.DirectShow;
using AForge.Video;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ViaCep;
using System.Net.Http;
using System.Xml.Linq;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;

namespace Projeto_Imoveis
{
    public partial class frmCadastroPessoas : Form
    {
        private Pessoas obj = new Pessoas();
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        public frmCadastroPessoas()
        {
            InitializeComponent();
            InicializarComponentes();
        }

        public frmCadastroPessoas(Pessoas pessoa)
        {
            InitializeComponent();
            InicializarComponentes();
            PreencherCampos(pessoa);
        }

        private void InicializarComponentes()
        {
            // Listar dispositivos de vídeo
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count == 0)
            {
                MessageBox.Show("Nenhum dispositivo de vídeo encontrado.");
                return;
            }

            // Selecionar o primeiro dispositivo de vídeo
            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);

            AdicionarCampos();
            OrdemControles();
        }

        private void PreencherCampos(Pessoas pessoa)
        {
            if (pessoa.ID != null)
            {
                txtID.Text = pessoa.ID;
                txtNome.Text = pessoa.Nome;
                mtxtCPF.Text = pessoa.CPF;
                mtxtTelefone.Text = pessoa.Telefone;
                cmbGenero.Text = pessoa.Genero;
                cmbEstadoCivil.Text = pessoa.EstadoCivil;
                dataTimePickerNascimento.Text = pessoa.DataDeNascimento;
                mtxtCEP.Text = pessoa.CEP;
                txtLogradouro.Text = pessoa.Logradouro;
                txtNumero.Text = pessoa.Numero;
                txtComplemento.Text = pessoa.Complemento;
                cmbMunicipio.Text = pessoa.Cidade;
                cmbUF.Text = pessoa.UF;

                if (!string.IsNullOrEmpty(pessoa.Imagem64))
                {
                    byte[] imagemBytes = Convert.FromBase64String(pessoa.Imagem64);
                    using (MemoryStream ms = new MemoryStream(imagemBytes))
                    {
                        pctBoxCliente.Image = Image.FromStream(ms);
                    }
                }

                btnSalvar.Text = "Atualizar";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Pessoas pessoa = new Pessoas()
            {
                Nome = txtNome.Text,
                Telefone = mtxtTelefone.Text,
                CEP = mtxtCEP.Text,
                CPF = mtxtCPF.Text,
                Numero = txtNumero.Text,
                Logradouro = txtLogradouro.Text,
                UF = cmbUF.Text,
                Cidade = cmbMunicipio.Text,
                DataDeNascimento = dataTimePickerNascimento.Text,
                EstadoCivil = cmbEstadoCivil.Text,
                Genero = cmbGenero.Text,
                Imagem64 = SalvarFoto()
            };

            if (string.IsNullOrEmpty(txtID.Text))
            {
                RandomID();
                pessoa.ID = txtID.Text;
                bool Inserir = obj.inserir(pessoa);
                if (Inserir)
                {
                    MessageBox.Show("Pessoa Inserida com sucesso");
                    DialogResult result = MessageBox.Show("Deseja continuar salvando clientes", "Salvar Clientes", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        LimparCampos();
                        btnSalvar.Text = "Salvar";
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                pessoa.ID = txtID.Text;
                bool Atualizar = obj.alterar(pessoa);
                if (Atualizar)
                    MessageBox.Show("Pessoa Atualizada com sucesso");
            }
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            frmCapturaImagem capturaImagem = new frmCapturaImagem();

            if (capturaImagem.ShowDialog() == DialogResult.OK)
            {
                pctBoxCliente.Image = capturaImagem.CapturedImage;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            mtxtTelefone.Clear();
            mtxtCEP.Clear();
            mtxtCPF.Clear();
            txtNumero.Clear();
            txtLogradouro.Clear();
            cmbUF.SelectedIndex = -1;
            cmbMunicipio.SelectedIndex = -1;
            txtID.Clear();
            dataTimePickerNascimento.Value = DateTime.Now;
            cmbEstadoCivil.SelectedIndex = -1;
            cmbGenero.SelectedIndex = -1;
            pctBoxCliente.Image = null;
        }

        private void RandomID()
        {
            Random random = new Random();
            int id = random.Next(1, 1000000000);
            txtID.Text = id.ToString();
        }

        private async void btnPesquisar_Click(object sender, EventArgs e)
        {
            CEP cep = new CEP();
            CEP resultado = new CEP();
            if (!string.IsNullOrEmpty(mtxtCEP.Text))
            {
                resultado = await cep.PesquisaCepAsync(mtxtCEP.Text);
                txtBairro.Text = resultado.Bairro;
                txtLogradouro.Text = resultado.Logradouro;
                txtComplemento.Text = resultado.Complemento;
                cmbMunicipio.Text = resultado.Localidade;
                cmbUF.Text = resultado.Uf;
            }
            else if (!string.IsNullOrEmpty(txtLogradouro.Text) && !string.IsNullOrEmpty(cmbMunicipio.Text) && !string.IsNullOrEmpty(cmbUF.Text))
            {
            //    List<CEP> ceps = new List<CEP> { cep };
               List<CEP> ceps = await cep.PesquisaEnderecoAsync(txtLogradouro.Text);
                    
                    foreach (CEP resultado in ceps)
                    {
                        if (resultado.Logradouro == txtLogradouro.Text)
                        {
                          
                        }
                    }
            }
            txtBairro.Text = resultado.Bairro;
            txtLogradouro.Text = resultado.Logradouro;
            txtComplemento.Text = resultado.Complemento;
            cmbMunicipio.Text = resultado.Localidade;
            cmbUF.Text = resultado.Uf;
        }

        private string SalvarFoto()
        {
            if (pctBoxCliente != null)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    pctBoxCliente.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] ImagemBytes = stream.ToArray();
                    return Convert.ToBase64String(ImagemBytes);
                }
            }
            return string.Empty;
        }
        private void AdicionarCampos()
        {
            txtNome.KeyDown += TextBox_KeyDown;
            mtxtCPF.KeyDown += TextBox_KeyDown;
            mtxtTelefone.KeyDown += TextBox_KeyDown;
            cmbEstadoCivil.KeyDown += TextBox_KeyDown;
            cmbGenero.KeyDown += TextBox_KeyDown; 
            dataTimePickerNascimento.KeyDown += TextBox_KeyDown;
            btnCapturar.KeyDown += TextBox_KeyDown;
            mtxtCEP.KeyDown +=  TextBox_KeyDown;
            txtLogradouro.KeyDown += TextBox_KeyDown;
            txtBairro.KeyDown +=TextBox_KeyDown;
            cmbUF.KeyDown += TextBox_KeyDown;
            cmbMunicipio.KeyDown += TextBox_KeyDown;
            txtNumero.KeyDown += TextBox_KeyDown;
            txtComplemento.KeyDown += TextBox_KeyDown;
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
                SendKeys.Send("Tab");
            }
        } 
     private void OrdemControles()
        {
            txtNome.TabIndex = 0;
            mtxtTelefone.TabIndex = 1;
            mtxtCPF.TabIndex = 2;
            cmbGenero.TabIndex = 3;
            cmbEstadoCivil.TabIndex = 4;
            dataTimePickerNascimento.TabIndex = 5;
            btnCapturar.TabIndex = 6;
            mtxtCEP.TabIndex = 7;
            btnPesquisar.TabIndex = 8;
            txtLogradouro.TabIndex = 9;
            txtNumero.TabIndex = 10;
            txtComplemento.TabIndex = 11;
            txtBairro.TabIndex = 12;
            cmbUF.TabIndex = 13;
            cmbMunicipio.TabIndex = 14;
        }
    }
}
