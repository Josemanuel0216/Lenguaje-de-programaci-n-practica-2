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
    public partial class FormEliminar : Form
    {
        public FormEliminar()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;

            if (id == "")
            {
                MessageBox.Show("Debe ingresar un ID");
                return;
            }

            bool encontrado = false;

            foreach (var emp in Controladores.ObtenerEmpleados())
            {
                if (emp.ID == id)
                {
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("Empleado no encontrado");
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar este empleado?", "Confirma", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                Controladores.EliminarEmpleado(id);
                MessageBox.Show("Empleado eliminado");
                this.Close();
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
