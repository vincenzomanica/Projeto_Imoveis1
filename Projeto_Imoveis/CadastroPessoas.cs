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
    public partial class CadastroPessoas : Form
    {
        public CadastroPessoas()
        {
            InitializeComponent();
        }

        private void CadastroPessoas_Load(object sender, EventArgs e)
        {

        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Pessoas pessoa 
                = new Pessoas();
            pessoa.Nome = txtNome.Text;
            pessoa.Telefone = txtTelefone.Text;
            pessoa.CEP = txtCEP.Text;
            pessoa.CPF = txtCPF.Text;
            pessoa.Numero = txtNumero.Text;
            pessoa.Logradouro = txtLogradouro.Text;
            pessoa.UF = cmbUF.Text;
            pessoa.Cidade = cmbMunicipio.Text;
            pessoa.ID = txtID.Text;

            //Incluir pessoa a Lista
            bool Inserir = Pessoas.inserir(pessoa);

            MessageBox.Show("Pessoa Inserida com sucesso");

        }


    }
}
