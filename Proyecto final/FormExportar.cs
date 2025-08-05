using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEmpleados
{
    public partial class FormExportar : Form
    {
        public FormExportar()
        {
            InitializeComponent();
            txtRuta.ReadOnly = true;
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = "Archivo CSV (*.csv)|*.csv",
                Title = "Guardar archivo CSV",
                FileName = "Empleados.csv"
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = saveFileDialog1.FileName;
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {

            try
            {
                using (StreamWriter sw = new StreamWriter(txtRuta.Text))
                {

                    sw.WriteLine("ID;Nombre;Departamento;Cargo;FechaInicio;TiempoEmpresa;Estado;Salario;AFP;ARS;ISR");


                    foreach (var emp in Controladores.ObtenerEmpleados())
                    {
                        string linea = 
                                   emp.ID + ";" +
                                   emp.Nombre + ";" +
                                   emp.Departamento + ";" +
                                   emp.Cargo + ";" +
                                   emp.FechaInicio.ToShortDateString() + ";" +
                                   emp.TiempoEmpresa.ToString() + ";" +
                                   emp.Estado + ";" +
                                   emp.Salario.ToString("F2") + ";" +
                                   emp.AFP.ToString("F2") + ";" +
                                   emp.ARS.ToString("F2") + ";" +
                                   emp.ISR.ToString("F2") + ";";

                        sw.WriteLine(linea);
                    }
                }

                MessageBox.Show("Empleados exportados con éxito.");
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema al exportar el archivo.");
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
