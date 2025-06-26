using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2_Formulario_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            // Verifica que no esté vacío

            if (string.IsNullOrWhiteSpace(maskedTextBoxNumero.Text))

            {
                MessageBox.Show("Por favor, ingrese un número.", "Advertencia",
                    
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Intenta convertir el texto a número
            if (int.TryParse(maskedTextBoxNumero.Text, out int numero))
            {
                if (EsPrimo(numero))
                {
                    MessageBox.Show($"{numero} es un número primo.", "Resultado",
                        
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{numero} NO es un número primo.", "Resultado",
                        
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Entrada inválida. Solo se permiten números.", "Error",
                    
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Función para verificar si un número es primo

        private bool EsPrimo(int numero)
        {
            if (numero < 2) return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }
            return true;
        }
    }
}

    
