using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preactica_2_Formulario_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            {
                // Validar que el campo no esté vacío
                if (string.IsNullOrWhiteSpace(maskedTextBoxNumero.Text))
                {
                    MessageBox.Show("Por favor, ingrese un número.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Convertir a entero
                if (int.TryParse(maskedTextBoxNumero.Text, out int numero))
                {
                    if (numero <= 0)
                    {
                        MessageBox.Show("Ingrese un número entero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (EsNumeroPerfecto(numero))
                    {
                        MessageBox.Show($"{numero} es un número perfecto.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"{numero} no es un número perfecto.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Entrada no válida. Solo se permiten números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool EsNumeroPerfecto(int numero)
        {
            int suma = 0;
            for (int i = 1; i <= numero / 2; i++)
            {
                if (numero % i == 0)
                {
                    suma += i;
                }
            }
            return suma == numero;
        }
    }
}
        
    

