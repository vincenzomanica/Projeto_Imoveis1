using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Imoveis
{
    public partial class ListaDeClientes : Form
    {
        private Pessoas objeto = new Pessoas();
        public ListaDeClientes()
        {
            InitializeComponent();
        }


        private void ListaDeClientes_Load(object sender, EventArgs e)
        {

            lswListaClientes.View = View.Details;
            lswListaClientes.Columns.Add("ID", 100, HorizontalAlignment.Left);
            lswListaClientes.Columns.Add("Nome", 100, HorizontalAlignment.Left);
            lswListaClientes.Columns.Add("Telefone", 100, HorizontalAlignment.Left);
            lswListaClientes.Columns.Add("CPF", 100, HorizontalAlignment.Left);
            lswListaClientes.Columns.Add("CEP", 100, HorizontalAlignment.Left);
            CarregarListaClientes();

        }
        private void CarregarListaClientes()
        {
            lswListaClientes.Items.Clear();
            List<Pessoas> lista = new List<Pessoas>();
            lista = objeto.ListarTodos();
            foreach (Pessoas item in lista)
            {
                ListViewItem lvi = new ListViewItem(item.ID);
                lvi.SubItems.Add(item.Nome);
                lvi.SubItems.Add(item.Telefone);
                lvi.SubItems.Add(item.CPF);
                lvi.SubItems.Add(item.CEP);
                lswListaClientes.Items.Add(lvi);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmCadastroPessoas frmCadastroPessoas = new frmCadastroPessoas();
            frmCadastroPessoas.ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ListViewItem lista = null;
            if (lswListaClientes.SelectedItems.Count > 0)
            {
                lista = lswListaClientes.SelectedItems[0];
                Pessoas pessoa = new Pessoas();
                pessoa = objeto.ListarUm(lista.Text);
                if (pessoa != null)
                {
                    frmCadastroPessoas frmCadastroPessoas = new frmCadastroPessoas(pessoa);
                    frmCadastroPessoas.ShowDialog();
                    CarregarListaClientes();
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ListViewItem listViewItem = new ListViewItem();
            if (lswListaClientes.Items.Count > 0)
            {
                listViewItem = lswListaClientes.SelectedItems[0];
                Pessoas pessoa = new Pessoas();
                pessoa = objeto.ListarUm(listViewItem.Text);
                if (pessoa != null)
                {
                    objeto.deletar(pessoa);
                    CarregarListaClientes();
                }

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lswListaClientes.Items.Clear();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarListaClientes();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)  
            {
                if (txtPesquisar.Text.Length > 0)
                {
                    if ((rbtnCPF.Checked || rbtnID.Checked || rbtnNome.Checked || rbtnTelefone.Checked))
                    {
                        lswListaClientes.Items.Clear();
                        List<Pessoas> lista = objeto.ListarTodos();
                        foreach (Pessoas pessoa in lista)
                            if ((rbtnCPF.Checked && txtPesquisar.Text == pessoa.CPF) ||
                                (rbtnID.Checked && txtPesquisar.Text == pessoa.ID) ||
                                (rbtnTelefone.Checked && txtPesquisar.Text == pessoa.Telefone) ||
                                (rbtnNome.Checked && txtPesquisar.Text == pessoa.Nome))
                            {
                                ListViewItem listViewItem = new ListViewItem(pessoa.ID);
                                listViewItem.SubItems.Add(pessoa.Nome);
                                listViewItem.SubItems.Add(pessoa.Telefone);
                                listViewItem.SubItems.Add(pessoa.CPF);
                                lswListaClientes.Items.Add(listViewItem);
                            }
                    }
                    else
                    {
                        List<Pessoas> lista = objeto.ListarTodos();
                        if (lista.Count > 0)
                        {
                            lswListaClientes.Items.Clear();
                            foreach (Pessoas pessoa in lista)
                            {
                                if (txtPesquisar.Text.Equals(pessoa.ID) || txtPesquisar.Text.Equals(pessoa.Nome) || txtPesquisar.Text.Equals(pessoa.CPF) || txtPesquisar.Text.Equals(pessoa.Telefone))
                                {
                                    ListViewItem listViewItem = new ListViewItem(pessoa.ID);
                                    listViewItem.SubItems.Add(pessoa.Nome);
                                    listViewItem.SubItems.Add(pessoa.Telefone);
                                    listViewItem.SubItems.Add(pessoa.CPF);
                                    lswListaClientes.Items.Add(listViewItem);
                                }
                            }
                        }
                    }
                }
                else
                {
                    CarregarListaClientes();
                }
            }
        }

        private void lswListaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAlterar.PerformClick();
        }
    }
}



