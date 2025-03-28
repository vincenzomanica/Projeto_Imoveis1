
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


        private readonly IBGEApiService _ibgeApiService;

        private readonly frmCapturaImagem _frmCapturaImagem;
        public frmCadastroPessoas()
        {
            InitializeComponent();
            InicializarComponentes();
            _ibgeApiService = new IBGEApiService();
            _frmCapturaImagem = new frmCapturaImagem();
        }

        public frmCadastroPessoas(Pessoas pessoa)
        {
            InitializeComponent();
            InicializarComponentes();
            PreencherCampos(pessoa);
            _ibgeApiService = new IBGEApiService();
            _frmCapturaImagem = new frmCapturaImagem();
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
            // Adicionar evento para colunas
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
            ViaCepClient cep = new ViaCepClient();
            CEP resultado = new CEP();

            if (!string.IsNullOrEmpty(mtxtCEP.Text))
            {
                resultado = await cep.SearchAsync(mtxtCEP.Text);
                txtBairro.Text = resultado.Bairro;
                txtLogradouro.Text = resultado.Logradouro;
                txtComplemento.Text = resultado.Complemento;
                cmbMunicipio.Text = resultado.Localidade;
                cmbUF.Text = resultado.Uf;
                txtNumero.Focus();

            }
            else if (!string.IsNullOrEmpty(txtLogradouro.Text) && !string.IsNullOrEmpty(cmbUF.Text) && !string.IsNullOrEmpty(cmbMunicipio.Text))
            {
                List<CEP> endereco = await cep.SearchByAddressAsync(cmbUF.Text, cmbMunicipio.Text, txtLogradouro.Text);
                if (endereco.Count > 0)
                {
                    pnlListaCEP.Visible = true;

                    foreach (CEP item in endereco)
                    {
                        ListViewItem listViewItem = new ListViewItem(item.Cep);
                        listViewItem.SubItems.Add(item.Logradouro);
                        listViewItem.SubItems.Add(item.Bairro);
                        listViewItem.SubItems.Add(item.Complemento);
                        lswListaCEP.Items.Add(listViewItem);

                    }
                }
                else
                {
                    MessageBox.Show("Endereço não encontrado");
                }
            }
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            pnlListaCEP.Visible = false;
        }


        private void dataTimePickerNascimento_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mtxtCEP.Focus();
            }
        }

        private void mtxtCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(mtxtCEP.Text.Length > 0)
                {
                    btnPesquisar.PerformClick();
                }
                else
                {
                    txtLogradouro.Focus();
                }
            }
        }



        private void txtLogradouro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (mtxtCEP.Text.Length == 0 && cmbUF.Text.Length > 0 && cmbMunicipio.Text.Length > 0 && txtLogradouro.Text.Length > 0)
                {
                    btnPesquisar.PerformClick();
                }
                else if(!string.IsNullOrEmpty(mtxtCEP.Text) && cmbUF.Text.Length > 0 && cmbMunicipio.Text.Length > 0 && txtLogradouro.Text.Length > 0) {
                    txtNumero.Focus();
                }
                else
                {
                    cmbUF.Focus();
                }
            }
        }
        private void cmbMunicipio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(mtxtCEP.Text.Length == 0 && cmbUF.Text.Length > 0 && cmbMunicipio.Text.Length > 0 && txtLogradouro.Text.Length > 0)
                {
                    btnPesquisar.PerformClick();
                }
                else if (!string.IsNullOrEmpty(mtxtCEP.Text) && cmbUF.Text.Length > 0 && cmbMunicipio.Text.Length > 0 && txtLogradouro.Text.Length > 0)
                {
                    btnCapturar.Focus();
                }     
            }
        }

        private void dataTimePickerNascimento_Leave(object sender, EventArgs e)
        {
            SendKeys.Send("{F4}");
        }

        private void lswListaCEP_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem item = lswListaCEP.SelectedItems[0]; // Pega o item selecionado

            mtxtCEP.Text = item.Text; // Preenche o campo CEP
            txtLogradouro.Text = item.SubItems[1].Text; // Preenche o campo Logradouro
            txtBairro.Text = item.SubItems[2].Text; // Preench3e o campo Bairro
            txtNumero.Focus(); // Foca no campo Número
            pnlListaCEP.Visible = false;  // Esconde o painel de listagem de CEPs
        }


        private void cmb_Leave(object sender, EventArgs e)
        {
            SendKeys.Send("{F4}");
        }
        private void cmb_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("{F4}");
        }

        private void dataTimePickerNascimento_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("{F4}");
        }

        private void btnCapturar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (_frmCapturaImagem.ShowDialog() == DialogResult.OK && pctBoxCliente != null)
                {
                    btnSalvar.Focus();
                }
            }
        }

        private void cmbUF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbMunicipio.Focus();
            }   
        }

       

        private async Task CarregarEstados()
        {
            try
            {
                List<Estado> estados = await _ibgeApiService.GetEstadosAsync();

                cmbUF.DataSource = estados;
                cmbUF.DisplayMember = "Sigla";
                cmbUF.ValueMember = "Sigla";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar estados: " + ex.Message);
            }
        }

        private async void cmbUF_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ufSelecionada = cmbUF.SelectedValue?.ToString();
            if (!string.IsNullOrEmpty(ufSelecionada))
            {
                await CarregarMunicipios( ufSelecionada);
            }
        }
        private async Task CarregarMunicipios(string ufSigla)
        {
            try
            {
                List<Municipio> municipios = await _ibgeApiService.GetMuncipioPorEstadoAsync(ufSigla);
                cmbMunicipio.DataSource = municipios;
                cmbMunicipio.DisplayMember = "Nome";
                cmbMunicipio.ValueMember = "Nome";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar municípios: " + ex.Message);
            }
        }

        private void cmbEstadoCivil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataTimePickerNascimento.Focus();
            }
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            mtxtTelefone.Focus();
        }

        private void mtxtTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            mtxtCPF.Focus();
        }

        private void mtxtCPF_KeyDown(object sender, KeyEventArgs e)
        {
            cmbGenero.Focus();
        }

        private void cmbGenero_KeyDown(object sender, KeyEventArgs e)
        {
            cmbEstadoCivil.Focus();
        }

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            txtComplemento.Focus();
        }

        private void txtComplemento_KeyDown(object sender, KeyEventArgs e)
        {
            txtBairro.Focus();
        }

        private void frmCadastroPessoas_Load(object sender, EventArgs e)
        {
            CarregarEstados();
        }
    }
} 
