
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
        Pessoas objPessoa = new Pessoas();

        List<Control> _ordemDeNavegacao;
        IBGEApiService _ibgeApiService;

        public frmCadastroPessoas(Pessoas pessoa = null)
        {
            InitializeComponent();
            
            this.objPessoa = pessoa;
            
        }

        private void Ctrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Control currentControl = sender as Control;
                int index = _ordemDeNavegacao.IndexOf(currentControl);
                if (currentControl == mtxtCEP && !string.IsNullOrEmpty(mtxtCEP.Text))
                {
                    btnPesquisar.PerformClick();
                    return;
                }
                if (currentControl == txtLogradouro && !string.IsNullOrEmpty(txtLogradouro.Text) && string.IsNullOrEmpty(mtxtCEP.Text) &&
                    !string.IsNullOrEmpty(cmbUF.Text) && !string.IsNullOrEmpty(cmbMunicipio.Text))
                {
                    btnPesquisar.PerformClick();
                    return;
                }
                if (index >= 0 && index < _ordemDeNavegacao.Count - 1)
                {
                    Control nextControl = _ordemDeNavegacao[index + 1];
                    nextControl.Focus();

                    if (nextControl is ComboBox cmb)
                    {
                        cmb.DroppedDown = true;
                    }
                    else if (nextControl is DateTimePicker dtp)
                    {
                        dtp.ShowDropDown();
                    }
                }
            }
        }

        private async Task PreencherCampos(Pessoas pessoa)
        {
            if (!string.IsNullOrEmpty(pessoa.ID))
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
                txtBairro.Text = pessoa.Bairro;
                txtComplemento.Text = pessoa.Complemento;
                cmbUF.SelectedValue = pessoa.UF;
                await CarregarMunicipios(pessoa.UF);
                cmbMunicipio.SelectedValue = pessoa.Cidade;

                if (!string.IsNullOrEmpty(pessoa.Imagem64))
                {
                    byte[] imagemBytes = Convert.FromBase64String(pessoa.Imagem64);
                    using (MemoryStream ms = new MemoryStream(imagemBytes))
                    {
                        pctBoxCliente.Image = Image.FromStream(ms);
                    }
                    pctBoxCliente.SizeMode = PictureBoxSizeMode.StretchImage;

                }
                btnSalvar.Text = "Atualizar";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoas pessoa = new Pessoas()
                {
                    Nome = txtNome.Text,
                    Telefone = mtxtTelefone.Text,
                    CEP = mtxtCEP.Text,
                    CPF = mtxtCPF.Text,
                    Numero = txtNumero.Text,
                    Complemento = txtComplemento.Text,
                    Bairro = txtBairro.Text,
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
                    if (string.IsNullOrEmpty(txtNome.Text)
                        || string.IsNullOrEmpty(mtxtCPF.Text)
                        || string.IsNullOrEmpty(mtxtTelefone.Text)
                        || string.IsNullOrEmpty(cmbGenero.Text)
                        || string.IsNullOrEmpty(cmbEstadoCivil.Text)
                        || string.IsNullOrEmpty(dataTimePickerNascimento.Text))
                    {
                        MessageBox.Show("Todos os campos dos Dados Pessoais são obrigatórios!");
                        return;
                    }
                    else if (pessoa.Imagem64.Length <= 0)
                    {
                        MessageBox.Show("Imagem é obrigatório");
                        return;
                    }
                    else if (string.IsNullOrEmpty(mtxtCEP.Text) ||
                        string.IsNullOrEmpty(txtLogradouro.Text) ||
                        string.IsNullOrEmpty(txtNumero.Text) ||
                        string.IsNullOrEmpty(cmbMunicipio.Text) ||
                        string.IsNullOrEmpty(cmbUF.Text) ||
                        string.IsNullOrEmpty(txtBairro.Text) ||
                        string.IsNullOrEmpty(txtComplemento.Text))
                    {
                        MessageBox.Show("Todos os campos do Endereço é obrigatório");
                        return;
                    }


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
                    else
                    {
                        MessageBox.Show("Falha ao inserir pessoa.");
                    }
                }
                else
                {
                    pessoa.ID = txtID.Text;
                    bool Atualizar = obj.alterar(pessoa);
                    if (Atualizar)
                        MessageBox.Show("Pessoa Atualizada com sucesso");
                    else
                        MessageBox.Show("Falha ao atualizar pessoa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar: {ex.Message}");
            }
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            using (frmCapturaImagem capturaImagem = new frmCapturaImagem())
            {
                if (capturaImagem.ShowDialog() == DialogResult.OK)
                {
               
                    pctBoxCliente.Image = capturaImagem.CapturedImage;
                   
                }
            }
            pctBoxCliente.SizeMode = PictureBoxSizeMode.StretchImage;
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
            /*
            Random random = new Random();
            int id = random.Next(1, 1000000000);
            txtID.Text = id.ToString();
            /*/
            txtID.Text = Guid.NewGuid().ToString("N°").Substring(0,10000000);
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
            if (pctBoxCliente != null && pctBoxCliente.Image != null)
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

        private void dataTimePickerNascimento_Leave(object sender, EventArgs e)
        {
            SendKeys.Send("{F4}");
        }

        private void lswListaCEP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lswListaCEP.Items.Count > 0 && lswListaCEP.SelectedItems.Count > 0)
            {
                ListViewItem item = lswListaCEP.SelectedItems[0];
                mtxtCEP.Text = item.Text;
                txtLogradouro.Text = item.SubItems[1].Text;
                txtBairro.Text = item.SubItems[2].Text;
                pnlListaCEP.Visible = false;

            }
            else
            {
                MessageBox.Show("Nenhum item na lista CEP selecionado");
            }
            txtNumero.Focus();
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

        private async void frmCadastroPessoas_Load(object sender, EventArgs e)
        {

            _ibgeApiService = new IBGEApiService();
            await CarregarEstados();
            cmbUF.SelectedValue = "RS";
            await CarregarMunicipios(cmbUF.SelectedValue.ToString());
            cmbMunicipio.SelectedValue = "Porto Alegre";
            if (objPessoa != null)
            {
                PreencherCampos(objPessoa);
            }
            NavegacaoControles();

           
        }

        private async void cmbUF_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbUF.SelectedValue != null && cmbUF.SelectedValue.ToString() != "RS")
            {
                string ufSelecionada = cmbUF.SelectedValue?.ToString();
                if (!string.IsNullOrEmpty(ufSelecionada))
                {
                    await CarregarMunicipios(ufSelecionada);
                }
            }
            if (cmbUF.SelectedValue != null && cmbUF.SelectedValue.ToString() == "RS")
            {
                await CarregarMunicipios(cmbUF.SelectedValue.ToString());
                cmbMunicipio.SelectedValue = "Porto Alegre";
            }
        }
        private async void 
            NavegacaoControles()
        {
            _ordemDeNavegacao = new List<Control>
            {
                txtNome,
                mtxtTelefone,
                mtxtCPF,
                cmbGenero,
                cmbEstadoCivil,
                dataTimePickerNascimento,
                mtxtCEP,
                cmbUF,
                cmbMunicipio,
                txtLogradouro,
                txtBairro,
                txtNumero,
                txtComplemento,
                btnCapturar,
                btnSalvar,
                btnLimpar
            };
            foreach (Control ctrl in _ordemDeNavegacao)
            {
                ctrl.KeyDown += Ctrl_KeyDown;
            }
        }
    }
    public static class ControlExtensions
    {
        public static void ShowDropDown(this DateTimePicker dtp)
        {
            SendKeys.Send("{F4}");
        }
    }
    
}
