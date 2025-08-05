using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEmpleados
{
    public partial class FormActualizar : Form
    {
        private Empleado empleadoOriginal;

        public FormActualizar()
        {
         
            InitializeComponent();

            txtID.Enabled = false;
            HabilitarCampos(false);

        }

        private void NuevoInicio()
        {
            txtBuscarID.Text = "";
            txtID.Text = "";
            txtNombre.Text = "";
            txtDepartamento.Text = "";
            txtCargo.Text = "";
            txtSalario.Text = "";
            cmbEstado.SelectedItem = "";

            HabilitarCampos(false);
        }

        private void HabilitarCampos(bool habilitar)
        {
            txtNombre.Enabled = habilitar;
            txtDepartamento.Enabled = habilitar;
            txtCargo.Enabled = habilitar;
            dtpFechaInicio.Enabled = habilitar;
            txtSalario.Enabled = habilitar;
            cmbEstado.Enabled = habilitar;
            btnActualizar.Enabled = habilitar;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if(txtBuscarID.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un ID para buscar");
                return;
            }

            string id = txtBuscarID.Text.Trim();
            empleadoOriginal = Controladores.ObtenerEmpleados().FirstOrDefault(enm => enm.ID == id);



            if (empleadoOriginal == null)
            {
                MessageBox.Show("Empleado no encontrado");
                return;
            }
            txtID.Text = empleadoOriginal.ID;
            txtNombre.Text = empleadoOriginal.Nombre;
            txtDepartamento.Text = empleadoOriginal.Departamento;
            txtCargo.Text = empleadoOriginal.Cargo;
            dtpFechaInicio.Value = empleadoOriginal.FechaInicio;
            txtSalario.Text = empleadoOriginal.Salario.ToString();
            cmbEstado.SelectedItem = empleadoOriginal.Estado;

            txtID.Enabled = false;

            HabilitarCampos(true);

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            string idBuscado = txtID.Text;

            if (!decimal.TryParse(txtSalario.Text, out decimal salario) || salario < 0)
            {
                MessageBox.Show("Salario inválido");
                txtSalario.Clear();
                return;
            }

            if (idBuscado == "")
            {
                MessageBox.Show("Ingrese un ID");
                return;
            }

            Empleado emp = null;

            foreach (var em in Controladores.ObtenerEmpleados())
            {
                if (em.ID == idBuscado)
                {
                    emp = em;
                    break;
                }
            }

            if (emp == null)
            {
                MessageBox.Show("Empleado no encontrado");
                return;
            }

            if (txtNombre.Text == "" || txtDepartamento.Text == "" || txtCargo.Text == "" || txtSalario.Text == "")
            {
                MessageBox.Show("Todos los campos son obligatorios");
                return;
            }

            emp.Nombre = txtNombre.Text;
            emp.Departamento = txtDepartamento.Text;
            emp.Cargo = txtCargo.Text;

            try
            {
                emp.FechaInicio = dtpFechaInicio.Value.Date;
            }
            catch
            {
                MessageBox.Show("Fecha inválida");
                return;
            }

            emp.Estado = cmbEstado.SelectedItem.ToString();

            if (emp.Estado == "")
            {
                MessageBox.Show("Seleccione un estado");
                return;
            }

            try
            {
                emp.Salario = decimal.Parse(txtSalario.Text);
            }
            catch
            {
                MessageBox.Show("Salario inválido");
                return;
            }

            Controladores.ActualizarEmpleado(emp.ID, emp);

            MessageBox.Show("Empleado actualizado!");

            NuevoInicio();



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }

}
