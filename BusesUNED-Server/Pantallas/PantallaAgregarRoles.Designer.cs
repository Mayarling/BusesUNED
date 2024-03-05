namespace BusesUNED_Server.Pantallas
{
    partial class PantallaAgregarRoles
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelHoraSalida = new System.Windows.Forms.Label();
            this.labelIdRuta = new System.Windows.Forms.Label();
            this.labelIdAutobus = new System.Windows.Forms.Label();
            this.labelIdConductor = new System.Windows.Forms.Label();
            this.campoFecha = new System.Windows.Forms.DateTimePicker();
            this.campoHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.campoRuta = new System.Windows.Forms.ComboBox();
            this.campoAutobus = new System.Windows.Forms.ComboBox();
            this.campoConductor = new System.Windows.Forms.ComboBox();
            this.buttonAgregarRol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(183, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Rol";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(49, 82);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(53, 21);
            this.labelFecha.TabIndex = 1;
            this.labelFecha.Text = "Fecha:";
            // 
            // labelHoraSalida
            // 
            this.labelHoraSalida.AutoSize = true;
            this.labelHoraSalida.Location = new System.Drawing.Point(49, 129);
            this.labelHoraSalida.Name = "labelHoraSalida";
            this.labelHoraSalida.Size = new System.Drawing.Size(112, 21);
            this.labelHoraSalida.TabIndex = 2;
            this.labelHoraSalida.Text = "Hora de salida:";
            // 
            // labelIdRuta
            // 
            this.labelIdRuta.AutoSize = true;
            this.labelIdRuta.Location = new System.Drawing.Point(49, 187);
            this.labelIdRuta.Name = "labelIdRuta";
            this.labelIdRuta.Size = new System.Drawing.Size(49, 21);
            this.labelIdRuta.TabIndex = 3;
            this.labelIdRuta.Text = "Ruta: ";
            // 
            // labelIdAutobus
            // 
            this.labelIdAutobus.AutoSize = true;
            this.labelIdAutobus.Location = new System.Drawing.Point(49, 236);
            this.labelIdAutobus.Name = "labelIdAutobus";
            this.labelIdAutobus.Size = new System.Drawing.Size(71, 21);
            this.labelIdAutobus.TabIndex = 4;
            this.labelIdAutobus.Text = "Autobús:";
            // 
            // labelIdConductor
            // 
            this.labelIdConductor.AutoSize = true;
            this.labelIdConductor.Location = new System.Drawing.Point(49, 294);
            this.labelIdConductor.Name = "labelIdConductor";
            this.labelIdConductor.Size = new System.Drawing.Size(86, 21);
            this.labelIdConductor.TabIndex = 5;
            this.labelIdConductor.Text = "Conductor:";
            // 
            // campoFecha
            // 
            this.campoFecha.CustomFormat = "dd/MM/yyyy";
            this.campoFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.campoFecha.Location = new System.Drawing.Point(171, 76);
            this.campoFecha.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.campoFecha.MinDate = new System.DateTime(2022, 10, 26, 0, 0, 0, 0);
            this.campoFecha.Name = "campoFecha";
            this.campoFecha.Size = new System.Drawing.Size(126, 29);
            this.campoFecha.TabIndex = 6;
            // 
            // campoHoraSalida
            // 
            this.campoHoraSalida.CustomFormat = "HH:mm";
            this.campoHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.campoHoraSalida.Location = new System.Drawing.Point(171, 129);
            this.campoHoraSalida.Name = "campoHoraSalida";
            this.campoHoraSalida.ShowUpDown = true;
            this.campoHoraSalida.Size = new System.Drawing.Size(66, 29);
            this.campoHoraSalida.TabIndex = 7;
            this.campoHoraSalida.Value = new System.DateTime(2022, 11, 22, 8, 0, 0, 0);
            // 
            // campoRuta
            // 
            this.campoRuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.campoRuta.FormattingEnabled = true;
            this.campoRuta.Location = new System.Drawing.Point(171, 187);
            this.campoRuta.Name = "campoRuta";
            this.campoRuta.Size = new System.Drawing.Size(284, 29);
            this.campoRuta.TabIndex = 8;
            // 
            // campoAutobus
            // 
            this.campoAutobus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.campoAutobus.FormattingEnabled = true;
            this.campoAutobus.Location = new System.Drawing.Point(171, 236);
            this.campoAutobus.Name = "campoAutobus";
            this.campoAutobus.Size = new System.Drawing.Size(284, 29);
            this.campoAutobus.TabIndex = 9;
            // 
            // campoConductor
            // 
            this.campoConductor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.campoConductor.FormattingEnabled = true;
            this.campoConductor.Location = new System.Drawing.Point(171, 286);
            this.campoConductor.Name = "campoConductor";
            this.campoConductor.Size = new System.Drawing.Size(284, 29);
            this.campoConductor.TabIndex = 10;
            // 
            // buttonAgregarRol
            // 
            this.buttonAgregarRol.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarRol.ForeColor = System.Drawing.Color.Blue;
            this.buttonAgregarRol.Location = new System.Drawing.Point(145, 348);
            this.buttonAgregarRol.Name = "buttonAgregarRol";
            this.buttonAgregarRol.Size = new System.Drawing.Size(186, 37);
            this.buttonAgregarRol.TabIndex = 11;
            this.buttonAgregarRol.Text = "Agregar Rol";
            this.buttonAgregarRol.UseVisualStyleBackColor = true;
            this.buttonAgregarRol.Click += new System.EventHandler(this.buttonAgregarRol_Click);
            // 
            // PantallaAgregarRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 400);
            this.Controls.Add(this.buttonAgregarRol);
            this.Controls.Add(this.campoConductor);
            this.Controls.Add(this.campoAutobus);
            this.Controls.Add(this.campoRuta);
            this.Controls.Add(this.campoHoraSalida);
            this.Controls.Add(this.campoFecha);
            this.Controls.Add(this.labelIdConductor);
            this.Controls.Add(this.labelIdAutobus);
            this.Controls.Add(this.labelIdRuta);
            this.Controls.Add(this.labelHoraSalida);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PantallaAgregarRoles";
            this.Text = "Agregar Roles";
            this.Load += new System.EventHandler(this.PantallaAgregarRoles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelHoraSalida;
        private System.Windows.Forms.Label labelIdRuta;
        private System.Windows.Forms.Label labelIdAutobus;
        private System.Windows.Forms.Label labelIdConductor;
        private System.Windows.Forms.DateTimePicker campoFecha;
        private System.Windows.Forms.DateTimePicker campoHoraSalida;
        private System.Windows.Forms.ComboBox campoRuta;
        private System.Windows.Forms.ComboBox campoAutobus;
        private System.Windows.Forms.ComboBox campoConductor;
        private System.Windows.Forms.Button buttonAgregarRol;
    }
}