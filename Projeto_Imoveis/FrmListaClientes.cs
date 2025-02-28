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
    public partial class ListaDeClientes : Form
    {
         private Pessoas objeto = new Pessoas();
        public ListaDeClientes()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ListaDeClientes_Load(object sender, EventArgs e)
        {
            
            lswListaClientes.View = View.Details;
            lswListaClientes.Columns.Add("ID", 50, HorizontalAlignment.Left);
            lswListaClientes.Columns.Add("Nome", 100, HorizontalAlignment.Left);
            lswListaClientes.Columns.Add("Telefone", 100, HorizontalAlignment.Left);
            lswListaClientes.Columns.Add("CPF", 100, HorizontalAlignment.Left);
            Carregarlsw();

        }
        private void Carregarlsw()
        {
            List<Pessoas> lista = new List<Pessoas>();
            lista = objeto.ListarTodos();
            foreach (Pessoas item in lista)
            {
                ListViewItem lvi = new ListViewItem(item.ID);
                lvi.SubItems.Add(item.Nome);
                lvi.SubItems.Add(item.Telefone);
                lvi.SubItems.Add(item.CPF);
                lswListaClientes.Items.Add(lvi);
            }
        }
    }
}

