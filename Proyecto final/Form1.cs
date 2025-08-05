using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEmpleados
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {       
            FemMostrarEmpleados frm = new FemMostrarEmpleados { MdiParent = this };
            frm.Show();
            
        }


        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormEliminar().ShowDialog();
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormExportar().ShowDialog();

        }
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarEmpleado frm = new FrmAgregarEmpleado { MdiParent = this };
            frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormActualizar frm = new FormActualizar { MdiParent = this };
            frm.Show();            
        }



    }
}
