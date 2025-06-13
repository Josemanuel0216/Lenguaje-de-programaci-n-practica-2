namespace Practica_2_formulario_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblMinutos = new Label();
            txtMinutos = new TextBox();
            lblSegundos = new Label();
            txtSegundos = new TextBox();
            btnIniciar = new Button();
            lblTiempoRestante = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblMinutos
            // 
            lblMinutos.AutoSize = true;
            lblMinutos.BackColor = Color.FromArgb(224, 224, 224);
            lblMinutos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMinutos.Location = new Point(12, 20);
            lblMinutos.Name = "lblMinutos";
            lblMinutos.Size = new Size(66, 19);
            lblMinutos.TabIndex = 0;
            lblMinutos.Text = "Minutos:";
            // 
            // txtMinutos
            // 
            txtMinutos.BackColor = Color.FromArgb(224, 224, 224);
            txtMinutos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtMinutos.Location = new Point(100, 20);
            txtMinutos.Name = "txtMinutos";
            txtMinutos.Size = new Size(40, 25);
            txtMinutos.TabIndex = 1;
            txtMinutos.Text = "0";
            // 
            // lblSegundos
            // 
            lblSegundos.AutoSize = true;
            lblSegundos.BackColor = Color.FromArgb(224, 224, 224);
            lblSegundos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSegundos.Location = new Point(12, 74);
            lblSegundos.Name = "lblSegundos";
            lblSegundos.Size = new Size(78, 19);
            lblSegundos.TabIndex = 2;
            lblSegundos.Text = "Segundos:";
            // 
            // txtSegundos
            // 
            txtSegundos.BackColor = Color.FromArgb(224, 224, 224);
            txtSegundos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtSegundos.Location = new Point(100, 74);
            txtSegundos.Name = "txtSegundos";
            txtSegundos.Size = new Size(40, 25);
            txtSegundos.TabIndex = 3;
            txtSegundos.Text = "0";
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.FromArgb(224, 224, 224);
            btnIniciar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIniciar.Location = new Point(12, 133);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(84, 28);
            btnIniciar.TabIndex = 4;
            btnIniciar.Text = "Iniciar Temporizador";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // lblTiempoRestante
            // 
            lblTiempoRestante.AutoSize = true;
            lblTiempoRestante.BackColor = Color.White;
            lblTiempoRestante.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTiempoRestante.Location = new Point(12, 193);
            lblTiempoRestante.Name = "lblTiempoRestante";
            lblTiempoRestante.Size = new Size(17, 20);
            lblTiempoRestante.TabIndex = 5;
            lblTiempoRestante.Text = "  ";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(271, 263);
            Controls.Add(lblTiempoRestante);
            Controls.Add(btnIniciar);
            Controls.Add(txtSegundos);
            Controls.Add(lblSegundos);
            Controls.Add(txtMinutos);
            Controls.Add(lblMinutos);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMinutos;
        private TextBox txtMinutos;
        private Label lblSegundos;
        private TextBox txtSegundos;
        private Button btnIniciar;
        private Label lblTiempoRestante;
        private System.Windows.Forms.Timer timer1;
    }
}
