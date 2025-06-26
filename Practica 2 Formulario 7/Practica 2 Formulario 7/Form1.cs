using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2_Formulario_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnContar_Click(object sender, EventArgs e)
        {
            // Obtener la oración del TextBox

            string oracion = txtOracion.Text;

            // Separar las palabras por espacios,
            //
            // y quitar entradas vacías

            string[ ] palabras = oracion.Split(new char[ ] 
            
            { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            // Contar cuántas palabras hay

            int cantidad =
                
                palabras.Length;

            // Mostrar el resultado en el Label
            lblResultado.Text = "Cantidad de palabras: " + cantidad;
        }
    }
}
