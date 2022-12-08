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
    public partial class ListarEmple : Form
    {
        CtrlEmpleados ctrlEmpleados = new CtrlEmpleados();
        public ListarEmple()
        {
            InitializeComponent();
            lstEmpleados.DataSource = null;
            lstEmpleados.DataSource = ctrlEmpleados.Listar();
        }
    }
}
