namespace Ejercicio1_PreParcial
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
            this.btnAltaEnvio = new System.Windows.Forms.Button();
            this.btnListarEnvios = new System.Windows.Forms.Button();
            this.lbxVerDetalles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAltaEnvio
            // 
            this.btnAltaEnvio.Location = new System.Drawing.Point(465, 30);
            this.btnAltaEnvio.Name = "btnAltaEnvio";
            this.btnAltaEnvio.Size = new System.Drawing.Size(75, 38);
            this.btnAltaEnvio.TabIndex = 0;
            this.btnAltaEnvio.Text = "Alta Envío";
            this.btnAltaEnvio.UseVisualStyleBackColor = true;
            this.btnAltaEnvio.Click += new System.EventHandler(this.btnAltaEnvio_Click);
            // 
            // btnListarEnvios
            // 
            this.btnListarEnvios.Location = new System.Drawing.Point(465, 93);
            this.btnListarEnvios.Name = "btnListarEnvios";
            this.btnListarEnvios.Size = new System.Drawing.Size(75, 38);
            this.btnListarEnvios.TabIndex = 1;
            this.btnListarEnvios.Text = "Listar Envíos";
            this.btnListarEnvios.UseVisualStyleBackColor = true;
            this.btnListarEnvios.Click += new System.EventHandler(this.btnListarEnvios_Click);
            // 
            // lbxVerDetalles
            // 
            this.lbxVerDetalles.FormattingEnabled = true;
            this.lbxVerDetalles.Location = new System.Drawing.Point(13, 13);
            this.lbxVerDetalles.Name = "lbxVerDetalles";
            this.lbxVerDetalles.Size = new System.Drawing.Size(446, 147);
            this.lbxVerDetalles.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 168);
            this.Controls.Add(this.lbxVerDetalles);
            this.Controls.Add(this.btnListarEnvios);
            this.Controls.Add(this.btnAltaEnvio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAltaEnvio;
        private System.Windows.Forms.Button btnListarEnvios;
        private System.Windows.Forms.ListBox lbxVerDetalles;
    }
}

