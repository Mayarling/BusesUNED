namespace BusesUNED_Cliente.Pantallas
{
    partial class PantallaConductores
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
            this.labelInicio = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.campoFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.labelFechaFinal = new System.Windows.Forms.Label();
            this.campoFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDatosConductor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInicio
            // 
            this.labelInicio.AutoSize = true;
            this.labelInicio.Location = new System.Drawing.Point(35, 132);
            this.labelInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInicio.Name = "labelInicio";
            this.labelInicio.Size = new System.Drawing.Size(115, 21);
            this.labelInicio.TabIndex = 0;
            this.labelInicio.Text = "Fecha de inicio:";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.Blue;
            this.labelTitulo.Location = new System.Drawing.Point(263, 42);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(265, 25);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "AUTOTRANSPORTES - UNED";
            // 
            // campoFechaInicio
            // 
            this.campoFechaInicio.CustomFormat = "dd/MM/yyyy";
            this.campoFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.campoFechaInicio.Location = new System.Drawing.Point(157, 124);
            this.campoFechaInicio.Name = "campoFechaInicio";
            this.campoFechaInicio.Size = new System.Drawing.Size(124, 29);
            this.campoFechaInicio.TabIndex = 2;
            // 
            // labelFechaFinal
            // 
            this.labelFechaFinal.AutoSize = true;
            this.labelFechaFinal.Location = new System.Drawing.Point(318, 130);
            this.labelFechaFinal.Name = "labelFechaFinal";
            this.labelFechaFinal.Size = new System.Drawing.Size(87, 21);
            this.labelFechaFinal.TabIndex = 3;
            this.labelFechaFinal.Text = "Fecha final:";
            // 
            // campoFechaFinal
            // 
            this.campoFechaFinal.CustomFormat = "dd/MM/yyyy";
            this.campoFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.campoFechaFinal.Location = new System.Drawing.Point(433, 124);
            this.campoFechaFinal.Name = "campoFechaFinal";
            this.campoFechaFinal.Size = new System.Drawing.Size(127, 29);
            this.campoFechaFinal.TabIndex = 4;
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultar.ForeColor = System.Drawing.Color.Blue;
            this.buttonConsultar.Location = new System.Drawing.Point(586, 115);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(99, 38);
            this.buttonConsultar.TabIndex = 5;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(756, 255);
            this.dataGridView1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(320, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Consulta de Roles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Roles registrados para el conductor:";
            // 
            // labelDatosConductor
            // 
            this.labelDatosConductor.AutoSize = true;
            this.labelDatosConductor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelDatosConductor.Location = new System.Drawing.Point(308, 181);
            this.labelDatosConductor.Name = "labelDatosConductor";
            this.labelDatosConductor.Size = new System.Drawing.Size(68, 21);
            this.labelDatosConductor.TabIndex = 9;
            this.labelDatosConductor.Text = "Nombre";
            // 
            // PantallaConductores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 521);
            this.Controls.Add(this.labelDatosConductor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.campoFechaFinal);
            this.Controls.Add(this.labelFechaFinal);
            this.Controls.Add(this.campoFechaInicio);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.labelInicio);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PantallaConductores";
            this.Text = "PantallaConductores";
            this.Load += new System.EventHandler(this.PantallaConductores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInicio;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.DateTimePicker campoFechaInicio;
        private System.Windows.Forms.Label labelFechaFinal;
        private System.Windows.Forms.DateTimePicker campoFechaFinal;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDatosConductor;
    }
}