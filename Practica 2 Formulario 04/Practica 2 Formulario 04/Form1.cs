using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2_Formulario_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string texto = txtPalabra.Text.Trim().ToLower();
            string invertido = new string(texto.Reverse().ToArray());

            if (texto == invertido && texto.Length > 0)
            {
                MessageBox.Show("Es un palindroma", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No es un palindroma", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
