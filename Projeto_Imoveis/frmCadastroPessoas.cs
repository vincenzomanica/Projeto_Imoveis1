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

namespace Projeto_Imoveis
{
    public partial class frmCadastroPessoas : Form
    {
        private Pessoas p = new Pessoas();
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        public frmCadastroPessoas()
        {
            InitializeComponent();

            // Listar dispositivos de vídeo
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count == 0)
            {
                MessageBox.Show("Nenhum dispositivo de vídeo encontrado.");
                return;
            }

            // Selecionar o primeiro dispositivo de vídeo
            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);

            // Combo Box Opções
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

            if (pctBoxCliente.Image != null)
            {
                using (System.IO.MemoryStream ms = new MemoryStream())
                {

                    pctBoxCliente.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] ImagemBytes = ms.ToArray();
                    pessoa.Imagem64 = Convert.ToBase64String(ImagemBytes);
                }
            }

            // Incluir pessoa a Lista
            bool Inserir = p.inserir(pessoa);
            if (Inserir == true)
                MessageBox.Show("Pessoa Inserida com sucesso");
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            frmCapturaImagem capturaImagem = new frmCapturaImagem();
           
            if(capturaImagem.ShowDialog() == DialogResult.OK)
            {
                pctBoxCliente.Image = capturaImagem.CapturedImage;
            }   
        }

        
        private void frmCadastroPessoas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpar os campos do formulário
            txtNome.Clear();
            txtTelefone.Clear();
            txtCEP.Clear();
            txtCPF.Clear();
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
    }
}