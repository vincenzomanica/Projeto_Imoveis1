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
        public ListaDeClientes()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ListaDeClientes_Load(object sender, EventArgs e)
        {
            Carregarlsw();
        }
        private void Carregarlsw()
          {
            lswListaClientes.Items.Add(new ListViewItem())
          }
    }
}

