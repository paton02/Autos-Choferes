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
    public partial class CrearCliente : Form
    {
        CtrlClientes ctrlTodo = new CtrlClientes();
        public CrearCliente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ctrlTodo.Agregar(txtNombre.Text, txtApellido.Text, txtEmail.Text, mskTele.Text,mskDni.Text));
        }
    }
}
