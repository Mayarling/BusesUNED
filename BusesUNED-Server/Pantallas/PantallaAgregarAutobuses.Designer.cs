namespace BusesUNED_Server.Pantallas
{
    partial class PantallaAgregarAutobuses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelPlaca = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelCapacidad = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.campoPlaca = new System.Windows.Forms.TextBox();
            this.campoMarca = new System.Windows.Forms.TextBox();
            this.campoModelo = new System.Windows.Forms.TextBox();
            this.campoCapacidad = new System.Windows.Forms.TextBox();
            this.campoEstado = new System.Windows.Forms.ComboBox();
            this.buttonAgregarAutobus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.Blue;
            this.labelTitulo.Location = new System.Drawing.Point(81, 43);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(166, 25);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Agregar Autobús";
            // 
            // labelPlaca
            // 
            this.labelPlaca.AutoSize = true;
            this.labelPlaca.Location = new System.Drawing.Point(42, 90);
            this.labelPlaca.Name = "labelPlaca";
            this.labelPlaca.Size = new System.Drawing.Size(83, 21);
            this.labelPlaca.TabIndex = 1;
            this.labelPlaca.Text = "# de Placa:";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(42, 143);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(56, 21);
            this.labelMarca.TabIndex = 2;
            this.labelMarca.Text = "Marca:";
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(42, 199);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(66, 21);
            this.labelModelo.TabIndex = 3;
            this.labelModelo.Text = "Modelo:";
            // 
            // labelCapacidad
            // 
            this.labelCapacidad.AutoSize = true;
            this.labelCapacidad.Location = new System.Drawing.Point(42, 249);
            this.labelCapacidad.Name = "labelCapacidad";
            this.labelCapacidad.Size = new System.Drawing.Size(85, 21);
            this.labelCapacidad.TabIndex = 4;
            this.labelCapacidad.Text = "Capacidad:";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(39, 305);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(59, 21);
            this.labelEstado.TabIndex = 5;
            this.labelEstado.Text = "Estado:";
            // 
            // campoPlaca
            // 
            this.campoPlaca.Location = new System.Drawing.Point(133, 90);
            this.campoPlaca.MaxLength = 10;
            this.campoPlaca.Name = "campoPlaca";
            this.campoPlaca.Size = new System.Drawing.Size(100, 29);
            this.campoPlaca.TabIndex = 6;
            // 
            // campoMarca
            // 
            this.campoMarca.Location = new System.Drawing.Point(133, 140);
            this.campoMarca.MaxLength = 30;
            this.campoMarca.Name = "campoMarca";
            this.campoMarca.Size = new System.Drawing.Size(100, 29);
            this.campoMarca.TabIndex = 7;
            // 
            // campoModelo
            // 
            this.campoModelo.Location = new System.Drawing.Point(133, 191);
            this.campoModelo.MaxLength = 4;
            this.campoModelo.Name = "campoModelo";
            this.campoModelo.Size = new System.Drawing.Size(100, 29);
            this.campoModelo.TabIndex = 8;
            // 
            // campoCapacidad
            // 
            this.campoCapacidad.Location = new System.Drawing.Point(133, 246);
            this.campoCapacidad.MaxLength = 3;
            this.campoCapacidad.Name = "campoCapacidad";
            this.campoCapacidad.Size = new System.Drawing.Size(100, 29);
            this.campoCapacidad.TabIndex = 9;
            // 
            // campoEstado
            // 
            this.campoEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.campoEstado.FormattingEnabled = true;
            this.campoEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.campoEstado.Location = new System.Drawing.Point(133, 302);
            this.campoEstado.Name = "campoEstado";
            this.campoEstado.Size = new System.Drawing.Size(100, 29);
            this.campoEstado.TabIndex = 10;
            // 
            // buttonAgregarAutobus
            // 
            this.buttonAgregarAutobus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarAutobus.ForeColor = System.Drawing.Color.Blue;
            this.buttonAgregarAutobus.Location = new System.Drawing.Point(73, 368);
            this.buttonAgregarAutobus.Name = "buttonAgregarAutobus";
            this.buttonAgregarAutobus.Size = new System.Drawing.Size(183, 33);
            this.buttonAgregarAutobus.TabIndex = 11;
            this.buttonAgregarAutobus.Text = "Agregar Autobús";
            this.buttonAgregarAutobus.UseVisualStyleBackColor = true;
            this.buttonAgregarAutobus.Click += new System.EventHandler(this.buttonAgregarAutobus_Click);
            // 
            // PantallaAgregarAutobuses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 413);
            this.Controls.Add(this.buttonAgregarAutobus);
            this.Controls.Add(this.campoEstado);
            this.Controls.Add(this.campoCapacidad);
            this.Controls.Add(this.campoModelo);
            this.Controls.Add(this.campoMarca);
            this.Controls.Add(this.campoPlaca);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelCapacidad);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.labelPlaca);
            this.Controls.Add(this.labelTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PantallaAgregarAutobuses";
            this.Text = "Agregar Autobúses";
            this.Load += new System.EventHandler(this.PantallaAgregarAutobuses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelPlaca;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Label labelCapacidad;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.TextBox campoPlaca;
        private System.Windows.Forms.TextBox campoMarca;
        private System.Windows.Forms.TextBox campoModelo;
        private System.Windows.Forms.TextBox campoCapacidad;
        private System.Windows.Forms.ComboBox campoEstado;
        private System.Windows.Forms.Button buttonAgregarAutobus;
    }
}