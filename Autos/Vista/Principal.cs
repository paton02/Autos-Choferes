using Autos.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autos
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            CrearCliente crearCliente = new CrearCliente();
            crearCliente.Show();
        }

        private void btnCrearEmpleado_Click(object sender, EventArgs e)
        {
            CrearEmpleado crearEmpleado = new CrearEmpleado();
            crearEmpleado.Show();
        }

        private void btnListarCliente_Click(object sender, EventArgs e)
        {
            ListarCliente listarCliente=new ListarCliente();
            listarCliente.Show();
        }

        private void btnListarEmpleado_Click(object sender, EventArgs e)
        {
            ListarEmple listarEmpleado=new ListarEmple();
            listarEmpleado.Show();
        }
    }
}
