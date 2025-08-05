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
    public partial class FemMostrarEmpleados : Form
    {
        public FemMostrarEmpleados()
        {
            InitializeComponent();
        }


        private void FemMostrarEmpleados_Load(object sender, EventArgs e)
        {

            CargarEmpleados();
        }

        private void CargarEmpleados()
        {
            dgvEmpleados.Rows.Clear();
            dgvEmpleados.Columns.Clear();

            dgvEmpleados.Columns.Add("ID", "ID");
            dgvEmpleados.Columns.Add("Nombre", "Nombre");
            dgvEmpleados.Columns.Add("Departamento", "Departamento");
            dgvEmpleados.Columns.Add("Cargo", "Cargo");
            dgvEmpleados.Columns.Add("FechaInicio", "Fecha Inicio");
            dgvEmpleados.Columns.Add("Salario", "Salario");
            dgvEmpleados.Columns.Add("Estado", "Estado");
            dgvEmpleados.Columns.Add("Tiempo", "Tiempo");
            dgvEmpleados.Columns.Add("AFP", "AFP");
            dgvEmpleados.Columns.Add("ARS", "ARS");
            dgvEmpleados.Columns.Add("ISR", "ISR");

            var empleados = Controladores.ObtenerEmpleados();
            foreach (var emp in empleados)
            {
                dgvEmpleados.Rows.Add(
                    emp.ID,
                    emp.Nombre,
                    emp.Departamento,
                    emp.Cargo,
                    emp.FechaInicio.ToShortDateString(),
                    emp.Salario.ToString("F2"),
                    emp.Estado,
                    emp.TiempoEmpresa,
                    emp.AFP.ToString("F2"),
                    emp.ARS.ToString("F2"),
                    emp.ISR.ToString("F2")
                );
            }
        }



        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            CargarEmpleados();
        }
    }
}
