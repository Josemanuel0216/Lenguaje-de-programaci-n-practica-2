using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEmpleados;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace SistemaEmpleados
{
    public partial class FrmAgregarEmpleado : Form
    {
        public FrmAgregarEmpleado()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
   
            if (txtID.Text == "" || txtNombre.Text == "" || txtDepartamento.Text == "" || txtCargo.Text == "" || txtSalario.Text == "" || cbEstado.SelectedItem == null)
            {
                MessageBox.Show("Todos los campos son obligatorios");
                return;
            }

            if (!int.TryParse(txtID.Text, out int idNumerico))
            {
                MessageBox.Show("ID inválido (debe ser numérico)");
                txtID.Clear();
                return;
            }

            foreach (var emp in Controladores.ObtenerEmpleados())
            {
                if (emp.ID == txtID.Text)
                {
                    MessageBox.Show("Ya hay un empleado con ese ID");
                    return;
                }
            }

     
            if (!decimal.TryParse(txtSalario.Text, out decimal salario) || salario < 0)
            {
                MessageBox.Show("Salario inválido");
                txtSalario.Clear();
                return;
            }

            
            Empleado nuevoEmpleado = new Empleado
            {
                ID = txtID.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Departamento = txtDepartamento.Text.Trim(),
                Cargo = txtCargo.Text.Trim(),
                FechaInicio = dtpFechaInicio.Value.Date,
                Estado = cbEstado.SelectedItem.ToString(),
                Salario = salario
            };

           
            Controladores.AgregarEmpleado(nuevoEmpleado);
            MessageBox.Show("Empleado agregado correctamente");


            habilitarCampos(false);
            btmnuevo.Visible = true;

        }
        private void habilitarCampos(bool habilitar)
        {
            txtID.Enabled = habilitar;
            txtNombre.Enabled = habilitar;
            txtDepartamento.Enabled = habilitar;
            txtCargo.Enabled = habilitar;
            dtpFechaInicio.Enabled = habilitar;
            txtSalario.Enabled = habilitar;
            cbEstado.Enabled = habilitar;
            btnGuardar.Enabled = habilitar;
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmnuevo_Click(object sender, EventArgs e)
        {

            txtID.Clear();
            txtNombre.Clear();
            txtDepartamento.Clear();
            txtCargo.Clear();
            txtSalario.Clear();
            cbEstado.SelectedIndex = -1;
            dtpFechaInicio.Value = DateTime.Now;
            habilitarCampos(true);

            txtID.Focus();

            btmnuevo.Visible = false;
        }

        private void FrmAgregarEmpleado_Load(object sender, EventArgs e)
        {
            
            btmnuevo.Visible = false;


        }
    }
}
