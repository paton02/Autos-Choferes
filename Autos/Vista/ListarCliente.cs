using Autos.Ctrl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autos.Vista
{
    public partial class ListarCliente : Form
    {
        CtrlClientes ctrlTodo = new CtrlClientes();
        public ListarCliente()
        {
            InitializeComponent();
            lstClientes.DataSource = null;
            lstClientes.DataSource = ctrlTodo.Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            lstClientes.DataSource = null;
            lstClientes.DataSource = ctrlTodo.Listar();
        }
    }
}
