namespace BusesUNED_Cliente
{
    partial class PantallaInicio
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
            this.labelIdentificación = new System.Windows.Forms.Label();
            this.campoIdentificacion = new System.Windows.Forms.TextBox();
            this.buttonConectar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDesconectar = new System.Windows.Forms.Button();
            this.labelEstadoConexion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelIdentificación
            // 
            this.labelIdentificación.AutoSize = true;
            this.labelIdentificación.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdentificación.Location = new System.Drawing.Point(36, 94);
            this.labelIdentificación.Name = "labelIdentificación";
            this.labelIdentificación.Size = new System.Drawing.Size(126, 21);
            this.labelIdentificación.TabIndex = 0;
            this.labelIdentificación.Text = "# identificación:";
            // 
            // campoIdentificacion
            // 
            this.campoIdentificacion.Location = new System.Drawing.Point(168, 91);
            this.campoIdentificacion.MaxLength = 15;
            this.campoIdentificacion.Name = "campoIdentificacion";
            this.campoIdentificacion.Size = new System.Drawing.Size(118, 29);
            this.campoIdentificacion.TabIndex = 1;
            this.campoIdentificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.campoIdentificacion.TextChanged += new System.EventHandler(this.campoIdentificacion_TextChanged);
            // 
            // buttonConectar
            // 
            this.buttonConectar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConectar.ForeColor = System.Drawing.Color.Blue;
            this.buttonConectar.Location = new System.Drawing.Point(97, 184);
            this.buttonConectar.Name = "buttonConectar";
            this.buttonConectar.Size = new System.Drawing.Size(201, 32);
            this.buttonConectar.TabIndex = 2;
            this.buttonConectar.Text = "Conectar";
            this.buttonConectar.UseVisualStyleBackColor = true;
            this.buttonConectar.Click += new System.EventHandler(this.buttonConectar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(70, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "AUTOTRANSPORTES - UNED";
            // 
            // buttonDesconectar
            // 
            this.buttonDesconectar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDesconectar.ForeColor = System.Drawing.Color.Red;
            this.buttonDesconectar.Location = new System.Drawing.Point(97, 231);
            this.buttonDesconectar.Name = "buttonDesconectar";
            this.buttonDesconectar.Size = new System.Drawing.Size(201, 35);
            this.buttonDesconectar.TabIndex = 4;
            this.buttonDesconectar.Text = "Desconectar";
            this.buttonDesconectar.UseVisualStyleBackColor = true;
            this.buttonDesconectar.Click += new System.EventHandler(this.buttonDesconectar_Click);
            // 
            // labelEstadoConexion
            // 
            this.labelEstadoConexion.AutoSize = true;
            this.labelEstadoConexion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstadoConexion.Location = new System.Drawing.Point(36, 143);
            this.labelEstadoConexion.Name = "labelEstadoConexion";
            this.labelEstadoConexion.Size = new System.Drawing.Size(68, 21);
            this.labelEstadoConexion.TabIndex = 5;
            this.labelEstadoConexion.Text = "Inactivo";
            // 
            // PantallaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 278);
            this.Controls.Add(this.labelEstadoConexion);
            this.Controls.Add(this.buttonDesconectar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConectar);
            this.Controls.Add(this.campoIdentificacion);
            this.Controls.Add(this.labelIdentificación);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PantallaInicio";
            this.Text = "Autotransportes UNED - Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIdentificación;
        private System.Windows.Forms.TextBox campoIdentificacion;
        private System.Windows.Forms.Button buttonConectar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDesconectar;
        private System.Windows.Forms.Label labelEstadoConexion;
    }
}

