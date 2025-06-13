namespace Practica_2_formulario_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDesarrollar_Click(object sender, EventArgs e)
        {
            lstTabla.Items.Clear();  // Borra lalista antes de agregar valores nuevos 
        
            if (int.TryParse(txtNumero.Text, out int numero))
            {
                for (int i = 1; i <= 10; i++)
                {
                    int resultado = numero * i;
                    lstTabla.Items.Add($"{numero} x {i} = {resultado}");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }  
}
