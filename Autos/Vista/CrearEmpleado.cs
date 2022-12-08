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
    public partial class CrearEmpleado : Form
    {
        CtrlEmpleados ctrlEmpleados = new CtrlEmpleados();
        public CrearEmpleado()
        {
            InitializeComponent();
            pnlDatosPersonales.Enabled = true;
            pnlAuto.Enabled = false;
            pnlRegistro.Enabled = false;
        }

        private void btnSiguiente1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text=="" || txtApellido.Text == ""|| txtEmail.Text=="" || mskTele.Text=="" || mskDni.Text=="")
            {
                MessageBox.Show("Faltan completar campos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                pnlAuto.Enabled=true;
            }
        }

        private void btnSiguiente2_Click(object sender, EventArgs e)
        {
            if (txtMarca.Text==""||txtModelo.Text==""||numAnio.Value == 2005 || mskPateVieja==null && mskPateNueva==null)
            {
                MessageBox.Show("Faltan completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pnlRegistro.Enabled = true;
            }
        }

        private void btnGuardaEmple_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ctrlEmpleados.Agregar(txtNombre.Text, txtApellido.Text, txtEmail.Text, mskTele.Text, mskDni.Text, txtMarca.Text, txtModelo.Text, (int)numAnio.Value,mskPateVieja.Text,cmbTipo.Text , mskFechaVen.Text));
        }

        private void CrearEmpleado_Load(object sender, EventArgs e)
        {
            cmbTipo.DataSource = ctrlEmpleados.traerTipos();
        }
    }
}
