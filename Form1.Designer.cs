namespace Productos
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtDisponibilidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbClave = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbDisponibilidad = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.btPagarEfectivo = new System.Windows.Forms.Button();
            this.btPagarTarjeta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(177, 95);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(177, 130);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(100, 22);
            this.txtClave.TabIndex = 1;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(177, 161);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 2;
            // 
            // txtDisponibilidad
            // 
            this.txtDisponibilidad.Location = new System.Drawing.Point(177, 204);
            this.txtDisponibilidad.Name = "txtDisponibilidad";
            this.txtDisponibilidad.Size = new System.Drawing.Size(100, 22);
            this.txtDisponibilidad.TabIndex = 3;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(177, 251);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtPrecio.TabIndex = 4;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(68, 98);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(58, 17);
            this.lbNombre.TabIndex = 5;
            this.lbNombre.Text = "Nombre";
            // 
            // lbClave
            // 
            this.lbClave.AutoSize = true;
            this.lbClave.Location = new System.Drawing.Point(68, 135);
            this.lbClave.Name = "lbClave";
            this.lbClave.Size = new System.Drawing.Size(43, 17);
            this.lbClave.TabIndex = 6;
            this.lbClave.Text = "Clave";
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Location = new System.Drawing.Point(68, 164);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(64, 17);
            this.lbCantidad.TabIndex = 7;
            this.lbCantidad.Text = "Cantidad";
            // 
            // lbDisponibilidad
            // 
            this.lbDisponibilidad.AutoSize = true;
            this.lbDisponibilidad.Location = new System.Drawing.Point(68, 209);
            this.lbDisponibilidad.Name = "lbDisponibilidad";
            this.lbDisponibilidad.Size = new System.Drawing.Size(96, 17);
            this.lbDisponibilidad.TabIndex = 8;
            this.lbDisponibilidad.Text = "Disponibilidad";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(68, 251);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(48, 17);
            this.lbPrecio.TabIndex = 9;
            this.lbPrecio.Text = "Precio";
            // 
            // btPagarEfectivo
            // 
            this.btPagarEfectivo.Location = new System.Drawing.Point(177, 304);
            this.btPagarEfectivo.Name = "btPagarEfectivo";
            this.btPagarEfectivo.Size = new System.Drawing.Size(100, 62);
            this.btPagarEfectivo.TabIndex = 10;
            this.btPagarEfectivo.Text = "Pagar en efectivo";
            this.btPagarEfectivo.UseVisualStyleBackColor = true;
            this.btPagarEfectivo.Click += new System.EventHandler(this.btPagar_Click);
            // 
            // btPagarTarjeta
            // 
            this.btPagarTarjeta.Location = new System.Drawing.Point(177, 395);
            this.btPagarTarjeta.Name = "btPagarTarjeta";
            this.btPagarTarjeta.Size = new System.Drawing.Size(100, 51);
            this.btPagarTarjeta.TabIndex = 11;
            this.btPagarTarjeta.Text = "Pagar con tarjeta";
            this.btPagarTarjeta.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 542);
            this.Controls.Add(this.btPagarTarjeta);
            this.Controls.Add(this.btPagarEfectivo);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbDisponibilidad);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.lbClave);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDisponibilidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtDisponibilidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbClave;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label lbDisponibilidad;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Button btPagarEfectivo;
        private System.Windows.Forms.Button btPagarTarjeta;
    }
}

