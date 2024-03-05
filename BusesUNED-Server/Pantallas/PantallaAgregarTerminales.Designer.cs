namespace BusesUNED_Server.Pantallas
{
    partial class PantallaAgregarTerminales
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.campoNombre = new System.Windows.Forms.TextBox();
            this.campoDireccion = new System.Windows.Forms.TextBox();
            this.campoTelefono = new System.Windows.Forms.TextBox();
            this.campoHoraApertura = new System.Windows.Forms.DateTimePicker();
            this.campoHoraCierre = new System.Windows.Forms.DateTimePicker();
            this.campoEstado = new System.Windows.Forms.ComboBox();
            this.buttonAgregarTerminal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(159, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Terminal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de la terminal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección de la terminal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 211);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teléfono de la terminal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 266);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hora de apertura:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 320);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hora de cierre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 371);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estado:";
            // 
            // campoNombre
            // 
            this.campoNombre.Location = new System.Drawing.Point(260, 97);
            this.campoNombre.MaxLength = 40;
            this.campoNombre.Name = "campoNombre";
            this.campoNombre.Size = new System.Drawing.Size(185, 29);
            this.campoNombre.TabIndex = 7;
            // 
            // campoDireccion
            // 
            this.campoDireccion.Location = new System.Drawing.Point(260, 150);
            this.campoDireccion.MaxLength = 40;
            this.campoDireccion.Name = "campoDireccion";
            this.campoDireccion.Size = new System.Drawing.Size(185, 29);
            this.campoDireccion.TabIndex = 8;
            // 
            // campoTelefono
            // 
            this.campoTelefono.Location = new System.Drawing.Point(260, 208);
            this.campoTelefono.MaxLength = 8;
            this.campoTelefono.Name = "campoTelefono";
            this.campoTelefono.Size = new System.Drawing.Size(92, 29);
            this.campoTelefono.TabIndex = 9;
            // 
            // campoHoraApertura
            // 
            this.campoHoraApertura.CustomFormat = "HH:mm";
            this.campoHoraApertura.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.campoHoraApertura.Location = new System.Drawing.Point(260, 266);
            this.campoHoraApertura.Name = "campoHoraApertura";
            this.campoHoraApertura.ShowUpDown = true;
            this.campoHoraApertura.Size = new System.Drawing.Size(67, 29);
            this.campoHoraApertura.TabIndex = 10;
            this.campoHoraApertura.Value = new System.DateTime(2022, 11, 22, 7, 0, 0, 0);
            // 
            // campoHoraCierre
            // 
            this.campoHoraCierre.CustomFormat = "HH:mm";
            this.campoHoraCierre.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.campoHoraCierre.Location = new System.Drawing.Point(260, 314);
            this.campoHoraCierre.Name = "campoHoraCierre";
            this.campoHoraCierre.ShowUpDown = true;
            this.campoHoraCierre.Size = new System.Drawing.Size(67, 29);
            this.campoHoraCierre.TabIndex = 11;
            this.campoHoraCierre.Value = new System.DateTime(2022, 11, 22, 18, 0, 0, 0);
            // 
            // campoEstado
            // 
            this.campoEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.campoEstado.FormattingEnabled = true;
            this.campoEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.campoEstado.Location = new System.Drawing.Point(260, 368);
            this.campoEstado.Name = "campoEstado";
            this.campoEstado.Size = new System.Drawing.Size(185, 29);
            this.campoEstado.TabIndex = 12;
            // 
            // buttonAgregarTerminal
            // 
            this.buttonAgregarTerminal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarTerminal.ForeColor = System.Drawing.Color.Blue;
            this.buttonAgregarTerminal.Location = new System.Drawing.Point(140, 433);
            this.buttonAgregarTerminal.Name = "buttonAgregarTerminal";
            this.buttonAgregarTerminal.Size = new System.Drawing.Size(204, 43);
            this.buttonAgregarTerminal.TabIndex = 13;
            this.buttonAgregarTerminal.Text = "Agregar Terminal";
            this.buttonAgregarTerminal.UseVisualStyleBackColor = true;
            this.buttonAgregarTerminal.Click += new System.EventHandler(this.buttonAgregarTerminal_Click);
            // 
            // PantallaAgregarTerminales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 494);
            this.Controls.Add(this.buttonAgregarTerminal);
            this.Controls.Add(this.campoEstado);
            this.Controls.Add(this.campoHoraCierre);
            this.Controls.Add(this.campoHoraApertura);
            this.Controls.Add(this.campoTelefono);
            this.Controls.Add(this.campoDireccion);
            this.Controls.Add(this.campoNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PantallaAgregarTerminales";
            this.Text = "Agregar Terminales";
            this.Load += new System.EventHandler(this.PantallaAgregarTerminales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox campoNombre;
        private System.Windows.Forms.TextBox campoDireccion;
        private System.Windows.Forms.TextBox campoTelefono;
        private System.Windows.Forms.DateTimePicker campoHoraApertura;
        private System.Windows.Forms.DateTimePicker campoHoraCierre;
        private System.Windows.Forms.ComboBox campoEstado;
        private System.Windows.Forms.Button buttonAgregarTerminal;
    }
}