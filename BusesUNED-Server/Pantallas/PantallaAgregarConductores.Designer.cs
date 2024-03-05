namespace BusesUNED_Server.Pantallas
{
    partial class PantallaAgregarConductores
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
            this.labelIdentificacion = new System.Windows.Forms.Label();
            this.campoIdentificacion = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.campoNombre = new System.Windows.Forms.TextBox();
            this.labelPrimerApellido = new System.Windows.Forms.Label();
            this.campoPrimerApellido = new System.Windows.Forms.TextBox();
            this.labelSegundoApellido = new System.Windows.Forms.Label();
            this.campoSegundoApellido = new System.Windows.Forms.TextBox();
            this.labelFechaNacimiento = new System.Windows.Forms.Label();
            this.labelGenero = new System.Windows.Forms.Label();
            this.campoGenero = new System.Windows.Forms.ComboBox();
            this.buttonAgregarConductor = new System.Windows.Forms.Button();
            this.campoFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.checkSupervisor = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.Blue;
            this.labelTitulo.Location = new System.Drawing.Point(84, 43);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(250, 25);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Agregar Nuevo Conductor";
            // 
            // labelIdentificacion
            // 
            this.labelIdentificacion.AutoSize = true;
            this.labelIdentificacion.Location = new System.Drawing.Point(26, 101);
            this.labelIdentificacion.Name = "labelIdentificacion";
            this.labelIdentificacion.Size = new System.Drawing.Size(118, 21);
            this.labelIdentificacion.TabIndex = 1;
            this.labelIdentificacion.Text = "# Identificación:";
            // 
            // campoIdentificacion
            // 
            this.campoIdentificacion.Location = new System.Drawing.Point(190, 98);
            this.campoIdentificacion.MaxLength = 15;
            this.campoIdentificacion.Name = "campoIdentificacion";
            this.campoIdentificacion.Size = new System.Drawing.Size(125, 29);
            this.campoIdentificacion.TabIndex = 2;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(26, 154);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(71, 21);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "Nombre:";
            // 
            // campoNombre
            // 
            this.campoNombre.Location = new System.Drawing.Point(190, 146);
            this.campoNombre.MaxLength = 40;
            this.campoNombre.Name = "campoNombre";
            this.campoNombre.Size = new System.Drawing.Size(125, 29);
            this.campoNombre.TabIndex = 4;
            // 
            // labelPrimerApellido
            // 
            this.labelPrimerApellido.AutoSize = true;
            this.labelPrimerApellido.Location = new System.Drawing.Point(26, 210);
            this.labelPrimerApellido.Name = "labelPrimerApellido";
            this.labelPrimerApellido.Size = new System.Drawing.Size(125, 21);
            this.labelPrimerApellido.TabIndex = 5;
            this.labelPrimerApellido.Text = "Primer Apellido: ";
            // 
            // campoPrimerApellido
            // 
            this.campoPrimerApellido.Location = new System.Drawing.Point(190, 202);
            this.campoPrimerApellido.MaxLength = 40;
            this.campoPrimerApellido.Name = "campoPrimerApellido";
            this.campoPrimerApellido.Size = new System.Drawing.Size(125, 29);
            this.campoPrimerApellido.TabIndex = 6;
            // 
            // labelSegundoApellido
            // 
            this.labelSegundoApellido.AutoSize = true;
            this.labelSegundoApellido.Location = new System.Drawing.Point(26, 261);
            this.labelSegundoApellido.Name = "labelSegundoApellido";
            this.labelSegundoApellido.Size = new System.Drawing.Size(136, 21);
            this.labelSegundoApellido.TabIndex = 7;
            this.labelSegundoApellido.Text = "Segundo Apellido:";
            // 
            // campoSegundoApellido
            // 
            this.campoSegundoApellido.Location = new System.Drawing.Point(190, 253);
            this.campoSegundoApellido.MaxLength = 40;
            this.campoSegundoApellido.Name = "campoSegundoApellido";
            this.campoSegundoApellido.Size = new System.Drawing.Size(125, 29);
            this.campoSegundoApellido.TabIndex = 8;
            // 
            // labelFechaNacimiento
            // 
            this.labelFechaNacimiento.AutoSize = true;
            this.labelFechaNacimiento.Location = new System.Drawing.Point(26, 310);
            this.labelFechaNacimiento.Name = "labelFechaNacimiento";
            this.labelFechaNacimiento.Size = new System.Drawing.Size(158, 21);
            this.labelFechaNacimiento.TabIndex = 9;
            this.labelFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Location = new System.Drawing.Point(26, 362);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(64, 21);
            this.labelGenero.TabIndex = 11;
            this.labelGenero.Text = "Género:";
            // 
            // campoGenero
            // 
            this.campoGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.campoGenero.FormattingEnabled = true;
            this.campoGenero.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.campoGenero.Location = new System.Drawing.Point(190, 359);
            this.campoGenero.Name = "campoGenero";
            this.campoGenero.Size = new System.Drawing.Size(121, 29);
            this.campoGenero.TabIndex = 12;
            // 
            // buttonAgregarConductor
            // 
            this.buttonAgregarConductor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarConductor.ForeColor = System.Drawing.Color.Blue;
            this.buttonAgregarConductor.Location = new System.Drawing.Point(82, 457);
            this.buttonAgregarConductor.Name = "buttonAgregarConductor";
            this.buttonAgregarConductor.Size = new System.Drawing.Size(200, 42);
            this.buttonAgregarConductor.TabIndex = 13;
            this.buttonAgregarConductor.Text = "Agregar Conductor";
            this.buttonAgregarConductor.UseVisualStyleBackColor = true;
            this.buttonAgregarConductor.Click += new System.EventHandler(this.buttonAgregarConductor_Click);
            // 
            // campoFechaNacimiento
            // 
            this.campoFechaNacimiento.CustomFormat = "dd/MM/yyyy";
            this.campoFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.campoFechaNacimiento.Location = new System.Drawing.Point(190, 304);
            this.campoFechaNacimiento.MaxDate = new System.DateTime(2004, 12, 15, 0, 0, 0, 0);
            this.campoFechaNacimiento.Name = "campoFechaNacimiento";
            this.campoFechaNacimiento.Size = new System.Drawing.Size(120, 29);
            this.campoFechaNacimiento.TabIndex = 14;
            this.campoFechaNacimiento.Value = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            // 
            // checkSupervisor
            // 
            this.checkSupervisor.AutoSize = true;
            this.checkSupervisor.Location = new System.Drawing.Point(104, 411);
            this.checkSupervisor.Name = "checkSupervisor";
            this.checkSupervisor.Size = new System.Drawing.Size(157, 25);
            this.checkSupervisor.TabIndex = 15;
            this.checkSupervisor.Text = "¿Es un supervisor?";
            this.checkSupervisor.UseVisualStyleBackColor = true;
            // 
            // PantallaAgregarConductores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 511);
            this.Controls.Add(this.checkSupervisor);
            this.Controls.Add(this.campoFechaNacimiento);
            this.Controls.Add(this.buttonAgregarConductor);
            this.Controls.Add(this.campoGenero);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.labelFechaNacimiento);
            this.Controls.Add(this.campoSegundoApellido);
            this.Controls.Add(this.labelSegundoApellido);
            this.Controls.Add(this.campoPrimerApellido);
            this.Controls.Add(this.labelPrimerApellido);
            this.Controls.Add(this.campoNombre);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.campoIdentificacion);
            this.Controls.Add(this.labelIdentificacion);
            this.Controls.Add(this.labelTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PantallaAgregarConductores";
            this.Text = "Agregar Conductores";
            this.Load += new System.EventHandler(this.PantallaAgregarConductores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelIdentificacion;
        private System.Windows.Forms.TextBox campoIdentificacion;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox campoNombre;
        private System.Windows.Forms.Label labelPrimerApellido;
        private System.Windows.Forms.TextBox campoPrimerApellido;
        private System.Windows.Forms.Label labelSegundoApellido;
        private System.Windows.Forms.TextBox campoSegundoApellido;
        private System.Windows.Forms.Label labelFechaNacimiento;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.ComboBox campoGenero;
        private System.Windows.Forms.Button buttonAgregarConductor;
        private System.Windows.Forms.DateTimePicker campoFechaNacimiento;
        private System.Windows.Forms.CheckBox checkSupervisor;
    }
}