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

namespace Projeto_Imoveis
{
    public partial class frmCadastroPessoas : Form
    {
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
            pessoa.Genero = txtGenero.Text;

            //Incluir pessoa a Lista
            bool Inserir = pessoa.inserir(pessoa);

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
