namespace Practica_2_formulario_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int tiempoRestante; // en segundos 

        private void MostrarTiempoRestante()
        {
            int minutos = tiempoRestante / 60;
            int segundos = tiempoRestante % 60;
            lblTiempoRestante.Text = $"Tiempo restante: {minutos:D2}:{segundos:D2}";
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int minutos, segundos;

            // Validar entrada de minutos y segundos
            if (int.TryParse(txtMinutos.Text, out minutos) && int.TryParse(txtSegundos.Text, out segundos))
            {
                tiempoRestante = (minutos * 60) + segundos;

                if (tiempoRestante > 0)
                {
                    timer1.Start();
                    MostrarTiempoRestante();
                }
                else
                {
                    MessageBox.Show("Ingrese un tiempo mayor a cero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tiempoRestante > 0)
            {
                tiempoRestante--;
                MostrarTiempoRestante();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("¡El tiempo se ha agotado!", "Temporizador", MessageBoxButtons.OK, MessageBoxIcon.Information);


                int minutos = tiempoRestante / 60;
                int segundos = tiempoRestante % 60;
                lblTiempoRestante.Text = $"Tiempo restante: {minutos:D2}:{segundos:D2}";
            }
        }
    }
} 
