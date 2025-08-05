namespace SistemaEmpleados
{
    partial class FormExportar
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelRuta = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // labelRuta
            // 
            this.labelRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRuta.Location = new System.Drawing.Point(30, 20);
            this.labelRuta.Name = "labelRuta";
            this.labelRuta.Size = new System.Drawing.Size(120, 15);
            this.labelRuta.TabIndex = 0;
            this.labelRuta.Text = "Ruta del archivo";
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(30, 40);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(220, 20);
            this.txtRuta.TabIndex = 1;
            // 
            // btnExaminar
            // 
            this.btnExaminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExaminar.Location = new System.Drawing.Point(260, 38);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(90, 25);
            this.btnExaminar.TabIndex = 2;
            this.btnExaminar.Text = "Examinar...";
            this.btnExaminar.UseVisualStyleBackColor = false;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.btnExportar.Location = new System.Drawing.Point(33, 90);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(80, 30);
            this.btnExportar.TabIndex = 3;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnCancelar.Location = new System.Drawing.Point(170, 90);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 30);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormExportar
            // 
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(380, 150);
            this.Controls.Add(this.labelRuta);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormExportar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exportar Datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRuta;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
