namespace Practica_2_formulario_1
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
            lblNumero = new Label();
            btnDesarrollar = new Button();
            txtNumero = new TextBox();
            lstTabla = new ListBox();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.BackColor = Color.FromArgb(224, 224, 224);
            lblNumero.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNumero.Location = new Point(14, 15);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(147, 19);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Agregue un numero:\r\n";
            lblNumero.Click += label1_Click;
            // 
            // btnDesarrollar
            // 
            btnDesarrollar.BackColor = Color.Cyan;
            btnDesarrollar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDesarrollar.Location = new Point(100, 68);
            btnDesarrollar.Name = "btnDesarrollar";
            btnDesarrollar.Size = new Size(150, 33);
            btnDesarrollar.TabIndex = 1;
            btnDesarrollar.Text = "Desarrollar Tabla";
            btnDesarrollar.UseVisualStyleBackColor = false;
            btnDesarrollar.Click += btnDesarrollar_Click;
            // 
            // txtNumero
            // 
            txtNumero.BackColor = Color.FromArgb(224, 224, 224);
            txtNumero.Location = new Point(206, 15);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(120, 23);
            txtNumero.TabIndex = 2;
            // 
            // lstTabla
            // 
            lstTabla.BackColor = Color.FromArgb(224, 224, 224);
            lstTabla.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lstTabla.FormattingEnabled = true;
            lstTabla.ItemHeight = 15;
            lstTabla.Location = new Point(100, 130);
            lstTabla.Name = "lstTabla";
            lstTabla.Size = new Size(150, 154);
            lstTabla.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(343, 348);
            Controls.Add(lstTabla);
            Controls.Add(txtNumero);
            Controls.Add(btnDesarrollar);
            Controls.Add(lblNumero);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private Button btnDesarrollar;
        private TextBox txtNumero;
        private ListBox lstTabla;
    }
}
