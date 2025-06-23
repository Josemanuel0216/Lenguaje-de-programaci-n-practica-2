using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2_foemulario_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)

        {
            if (double.TryParse(txtCantidad.Text, out double cantidad))

            {
                double metros = ConvertirAMetros(cantidad, cmbEntrada.Text);


                double resultado = ConvertirDesdeMetros(metros, cmbSalida.Text);


                lblResultado.Text = $"Resultado: {resultado:F2} {cmbSalida.Text}";

            }

            else

            {
                MessageBox.Show("Introduce una cantidad válida.");
            }
        }
        private double ConvertirAMetros(double valor, string unidad)
        {
            switch (unidad)
            {
                case "Metro":

                    return valor;

                case "Centímetro":
                    return valor / 100;

                case "Pulgada":

                    return valor * 0.0254;

                default:

                    return valor;
            }
        }

        private double ConvertirDesdeMetros(double metros, string unidad)
        {
            switch (unidad)
            {
                case "Metro":

                    return metros;

                case "Centímetro":


                    return metros * 100;

                case "Pulgada":


                    return metros / 0.0254;

                default:

                    return metros;
            }
        }
    }
}
