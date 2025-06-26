namespace Practica_2_Formulario_7
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtOracion = new System.Windows.Forms.TextBox();
            this.btnContar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOracion
            // 
            this.txtOracion.BackColor = System.Drawing.Color.Cyan;
            this.txtOracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOracion.Location = new System.Drawing.Point(89, 29);
            this.txtOracion.Name = "txtOracion";
            this.txtOracion.Size = new System.Drawing.Size(128, 21);
            this.txtOracion.TabIndex = 0;
            // 
            // btnContar
            // 
            this.btnContar.BackColor = System.Drawing.Color.Cyan;
            this.btnContar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContar.Location = new System.Drawing.Point(89, 85);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(128, 49);
            this.btnContar.TabIndex = 1;
            this.btnContar.Text = "Contar Plalabras";
            this.btnContar.UseVisualStyleBackColor = false;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Cyan;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(70, 177);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(168, 17);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Cantidad de palabras:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(309, 300);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.txtOracion);
            this.Name = "Form1";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOracion;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.Label lblResultado;
    }
}

