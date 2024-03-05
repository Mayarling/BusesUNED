namespace BusesUNED_Server
{
    partial class PantallaPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeTerminalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeConductoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeAutobúsesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeRutasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitácoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarBitácoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBitacora = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelEstadoServidor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botonDetenerServidor = new System.Windows.Forms.Button();
            this.botonIniciarServidor = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstClientesConectados = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.bitácoraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(984, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónDeTerminalesToolStripMenuItem,
            this.gestiónDeConductoresToolStripMenuItem,
            this.gestiónDeAutobúsesToolStripMenuItem,
            this.gestiónDeRutasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.opcionesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // gestiónDeTerminalesToolStripMenuItem
            // 
            this.gestiónDeTerminalesToolStripMenuItem.Name = "gestiónDeTerminalesToolStripMenuItem";
            this.gestiónDeTerminalesToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.gestiónDeTerminalesToolStripMenuItem.Text = "Gestión de terminales";
            this.gestiónDeTerminalesToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeTerminalesToolStripMenuItem_Click);
            // 
            // gestiónDeConductoresToolStripMenuItem
            // 
            this.gestiónDeConductoresToolStripMenuItem.Name = "gestiónDeConductoresToolStripMenuItem";
            this.gestiónDeConductoresToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.gestiónDeConductoresToolStripMenuItem.Text = "Gestión de Conductores";
            this.gestiónDeConductoresToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeConductoresToolStripMenuItem_Click);
            // 
            // gestiónDeAutobúsesToolStripMenuItem
            // 
            this.gestiónDeAutobúsesToolStripMenuItem.Name = "gestiónDeAutobúsesToolStripMenuItem";
            this.gestiónDeAutobúsesToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.gestiónDeAutobúsesToolStripMenuItem.Text = "Gestión de Autobúses";
            this.gestiónDeAutobúsesToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeAutobúsesToolStripMenuItem_Click);
            // 
            // gestiónDeRutasToolStripMenuItem
            // 
            this.gestiónDeRutasToolStripMenuItem.Name = "gestiónDeRutasToolStripMenuItem";
            this.gestiónDeRutasToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.gestiónDeRutasToolStripMenuItem.Text = "Gestión de Rutas";
            this.gestiónDeRutasToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeRutasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // bitácoraToolStripMenuItem
            // 
            this.bitácoraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limpiarBitácoraToolStripMenuItem});
            this.bitácoraToolStripMenuItem.Name = "bitácoraToolStripMenuItem";
            this.bitácoraToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.bitácoraToolStripMenuItem.Text = "Bitácora";
            // 
            // limpiarBitácoraToolStripMenuItem
            // 
            this.limpiarBitácoraToolStripMenuItem.Name = "limpiarBitácoraToolStripMenuItem";
            this.limpiarBitácoraToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.limpiarBitácoraToolStripMenuItem.Text = "Limpiar Bitácora";
            this.limpiarBitácoraToolStripMenuItem.Click += new System.EventHandler(this.limpiarBitácoraToolStripMenuItem_Click);
            // 
            // txtBitacora
            // 
            this.txtBitacora.Location = new System.Drawing.Point(8, 32);
            this.txtBitacora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBitacora.Multiline = true;
            this.txtBitacora.Name = "txtBitacora";
            this.txtBitacora.ReadOnly = true;
            this.txtBitacora.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBitacora.Size = new System.Drawing.Size(661, 472);
            this.txtBitacora.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBitacora);
            this.groupBox1.Location = new System.Drawing.Point(294, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(677, 514);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bitácora de eventos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelEstadoServidor);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.botonDetenerServidor);
            this.groupBox2.Controls.Add(this.botonIniciarServidor);
            this.groupBox2.Location = new System.Drawing.Point(12, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 155);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gestión del Servidor";
            // 
            // labelEstadoServidor
            // 
            this.labelEstadoServidor.AutoSize = true;
            this.labelEstadoServidor.Location = new System.Drawing.Point(4, 125);
            this.labelEstadoServidor.Name = "labelEstadoServidor";
            this.labelEstadoServidor.Size = new System.Drawing.Size(64, 21);
            this.labelEstadoServidor.TabIndex = 3;
            this.labelEstadoServidor.Text = "Inactivo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Estado del servidor";
            // 
            // botonDetenerServidor
            // 
            this.botonDetenerServidor.Location = new System.Drawing.Point(48, 67);
            this.botonDetenerServidor.Name = "botonDetenerServidor";
            this.botonDetenerServidor.Size = new System.Drawing.Size(179, 33);
            this.botonDetenerServidor.TabIndex = 1;
            this.botonDetenerServidor.Text = "Detener Servidor";
            this.botonDetenerServidor.UseVisualStyleBackColor = true;
            this.botonDetenerServidor.Click += new System.EventHandler(this.botonDetenerServidor_Click);
            // 
            // botonIniciarServidor
            // 
            this.botonIniciarServidor.Location = new System.Drawing.Point(48, 28);
            this.botonIniciarServidor.Name = "botonIniciarServidor";
            this.botonIniciarServidor.Size = new System.Drawing.Size(179, 33);
            this.botonIniciarServidor.TabIndex = 0;
            this.botonIniciarServidor.Text = "Iniciar Servidor";
            this.botonIniciarServidor.UseVisualStyleBackColor = true;
            this.botonIniciarServidor.Click += new System.EventHandler(this.botonIniciarServidor_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstClientesConectados);
            this.groupBox3.Location = new System.Drawing.Point(12, 194);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 353);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Clientes Conectados";
            // 
            // lstClientesConectados
            // 
            this.lstClientesConectados.FormattingEnabled = true;
            this.lstClientesConectados.ItemHeight = 21;
            this.lstClientesConectados.Location = new System.Drawing.Point(6, 28);
            this.lstClientesConectados.Name = "lstClientesConectados";
            this.lstClientesConectados.Size = new System.Drawing.Size(263, 319);
            this.lstClientesConectados.TabIndex = 0;
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PantallaPrincipal";
            this.Text = "Autotransportes UNED - Servidor";
            this.Load += new System.EventHandler(this.PantallaPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeTerminalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.TextBox txtBitacora;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeConductoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeRutasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeAutobúsesToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelEstadoServidor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonDetenerServidor;
        private System.Windows.Forms.Button botonIniciarServidor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem bitácoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarBitácoraToolStripMenuItem;
        private System.Windows.Forms.ListBox lstClientesConectados;
    }
}