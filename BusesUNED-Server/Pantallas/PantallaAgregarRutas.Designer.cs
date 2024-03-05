namespace BusesUNED_Server.Pantallas
{
    partial class PantallaAgregarRutas
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
            this.labelTerminalSalida = new System.Windows.Forms.Label();
            this.labelTerminalLlegada = new System.Windows.Forms.Label();
            this.labelTarifa = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelTipoRuta = new System.Windows.Forms.Label();
            this.CampoIdTerminalSalida = new System.Windows.Forms.ComboBox();
            this.campoTerminalLlegada = new System.Windows.Forms.ComboBox();
            this.campoTarifa = new System.Windows.Forms.TextBox();
            this.campoDescripcion = new System.Windows.Forms.TextBox();
            this.campoTipoRuta = new System.Windows.Forms.ComboBox();
            this.campoEstado = new System.Windows.Forms.ComboBox();
            this.buttonAgregarRuta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(129, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Rutas";
            // 
            // labelTerminalSalida
            // 
            this.labelTerminalSalida.AutoSize = true;
            this.labelTerminalSalida.Location = new System.Drawing.Point(53, 86);
            this.labelTerminalSalida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTerminalSalida.Name = "labelTerminalSalida";
            this.labelTerminalSalida.Size = new System.Drawing.Size(137, 21);
            this.labelTerminalSalida.TabIndex = 1;
            this.labelTerminalSalida.Text = "Terminal de salida:";
            // 
            // labelTerminalLlegada
            // 
            this.labelTerminalLlegada.AutoSize = true;
            this.labelTerminalLlegada.Location = new System.Drawing.Point(53, 135);
            this.labelTerminalLlegada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTerminalLlegada.Name = "labelTerminalLlegada";
            this.labelTerminalLlegada.Size = new System.Drawing.Size(147, 21);
            this.labelTerminalLlegada.TabIndex = 2;
            this.labelTerminalLlegada.Text = "Terminal de llegada:";
            // 
            // labelTarifa
            // 
            this.labelTarifa.AutoSize = true;
            this.labelTarifa.Location = new System.Drawing.Point(53, 186);
            this.labelTarifa.Name = "labelTarifa";
            this.labelTarifa.Size = new System.Drawing.Size(50, 21);
            this.labelTarifa.TabIndex = 3;
            this.labelTarifa.Text = "Tarifa:";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(53, 237);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(163, 21);
            this.labelDescripcion.TabIndex = 4;
            this.labelDescripcion.Text = "Descripción de la ruta:";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(53, 324);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(59, 21);
            this.labelEstado.TabIndex = 5;
            this.labelEstado.Text = "Estado:";
            // 
            // labelTipoRuta
            // 
            this.labelTipoRuta.AutoSize = true;
            this.labelTipoRuta.Location = new System.Drawing.Point(53, 281);
            this.labelTipoRuta.Name = "labelTipoRuta";
            this.labelTipoRuta.Size = new System.Drawing.Size(96, 21);
            this.labelTipoRuta.TabIndex = 6;
            this.labelTipoRuta.Text = "Tipo de ruta:";
            // 
            // CampoIdTerminalSalida
            // 
            this.CampoIdTerminalSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CampoIdTerminalSalida.FormattingEnabled = true;
            this.CampoIdTerminalSalida.Location = new System.Drawing.Point(222, 83);
            this.CampoIdTerminalSalida.Name = "CampoIdTerminalSalida";
            this.CampoIdTerminalSalida.Size = new System.Drawing.Size(163, 29);
            this.CampoIdTerminalSalida.TabIndex = 7;
            // 
            // campoTerminalLlegada
            // 
            this.campoTerminalLlegada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.campoTerminalLlegada.FormattingEnabled = true;
            this.campoTerminalLlegada.Location = new System.Drawing.Point(222, 132);
            this.campoTerminalLlegada.Name = "campoTerminalLlegada";
            this.campoTerminalLlegada.Size = new System.Drawing.Size(163, 29);
            this.campoTerminalLlegada.TabIndex = 8;
            // 
            // campoTarifa
            // 
            this.campoTarifa.Location = new System.Drawing.Point(222, 183);
            this.campoTarifa.MaxLength = 8;
            this.campoTarifa.Name = "campoTarifa";
            this.campoTarifa.Size = new System.Drawing.Size(163, 29);
            this.campoTarifa.TabIndex = 9;
            // 
            // campoDescripcion
            // 
            this.campoDescripcion.Location = new System.Drawing.Point(222, 234);
            this.campoDescripcion.MaxLength = 40;
            this.campoDescripcion.Name = "campoDescripcion";
            this.campoDescripcion.Size = new System.Drawing.Size(163, 29);
            this.campoDescripcion.TabIndex = 10;
            // 
            // campoTipoRuta
            // 
            this.campoTipoRuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.campoTipoRuta.FormattingEnabled = true;
            this.campoTipoRuta.Items.AddRange(new object[] {
            "DIRECTO",
            "REGULAR"});
            this.campoTipoRuta.Location = new System.Drawing.Point(222, 278);
            this.campoTipoRuta.Name = "campoTipoRuta";
            this.campoTipoRuta.Size = new System.Drawing.Size(163, 29);
            this.campoTipoRuta.TabIndex = 11;
            // 
            // campoEstado
            // 
            this.campoEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.campoEstado.FormattingEnabled = true;
            this.campoEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.campoEstado.Location = new System.Drawing.Point(222, 321);
            this.campoEstado.Name = "campoEstado";
            this.campoEstado.Size = new System.Drawing.Size(163, 29);
            this.campoEstado.TabIndex = 12;
            // 
            // buttonAgregarRuta
            // 
            this.buttonAgregarRuta.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarRuta.ForeColor = System.Drawing.Color.Blue;
            this.buttonAgregarRuta.Location = new System.Drawing.Point(125, 370);
            this.buttonAgregarRuta.Name = "buttonAgregarRuta";
            this.buttonAgregarRuta.Size = new System.Drawing.Size(146, 42);
            this.buttonAgregarRuta.TabIndex = 13;
            this.buttonAgregarRuta.Text = "Agregar Ruta";
            this.buttonAgregarRuta.UseVisualStyleBackColor = true;
            this.buttonAgregarRuta.Click += new System.EventHandler(this.buttonAgregarRuta_Click);
            // 
            // PantallaAgregarRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 446);
            this.Controls.Add(this.buttonAgregarRuta);
            this.Controls.Add(this.campoEstado);
            this.Controls.Add(this.campoTipoRuta);
            this.Controls.Add(this.campoDescripcion);
            this.Controls.Add(this.campoTarifa);
            this.Controls.Add(this.campoTerminalLlegada);
            this.Controls.Add(this.CampoIdTerminalSalida);
            this.Controls.Add(this.labelTipoRuta);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelTarifa);
            this.Controls.Add(this.labelTerminalLlegada);
            this.Controls.Add(this.labelTerminalSalida);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PantallaAgregarRutas";
            this.Text = "Agregar Ruta";
            this.Load += new System.EventHandler(this.PantallaAgregarRutas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTerminalSalida;
        private System.Windows.Forms.Label labelTerminalLlegada;
        private System.Windows.Forms.Label labelTarifa;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelTipoRuta;
        private System.Windows.Forms.ComboBox CampoIdTerminalSalida;
        private System.Windows.Forms.ComboBox campoTerminalLlegada;
        private System.Windows.Forms.TextBox campoTarifa;
        private System.Windows.Forms.TextBox campoDescripcion;
        private System.Windows.Forms.ComboBox campoTipoRuta;
        private System.Windows.Forms.ComboBox campoEstado;
        private System.Windows.Forms.Button buttonAgregarRuta;
    }
}