namespace BusesUNED_Server.Pantallas
{
    partial class PantallaGestionConductores
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
            this.buttonAgregarConductor = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.Blue;
            this.labelTitulo.Location = new System.Drawing.Point(191, 41);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(228, 25);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Conductores Agregados";
            // 
            // buttonAgregarConductor
            // 
            this.buttonAgregarConductor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarConductor.ForeColor = System.Drawing.Color.Blue;
            this.buttonAgregarConductor.Location = new System.Drawing.Point(188, 421);
            this.buttonAgregarConductor.Name = "buttonAgregarConductor";
            this.buttonAgregarConductor.Size = new System.Drawing.Size(234, 46);
            this.buttonAgregarConductor.TabIndex = 1;
            this.buttonAgregarConductor.Text = "Agregar Nuevo Conductor";
            this.buttonAgregarConductor.UseVisualStyleBackColor = true;
            this.buttonAgregarConductor.Click += new System.EventHandler(this.buttonAgregarConductor_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(551, 307);
            this.dataGridView1.TabIndex = 2;
            // 
            // PantallaGestionConductores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 487);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAgregarConductor);
            this.Controls.Add(this.labelTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PantallaGestionConductores";
            this.Text = "Gestion de Conductores";
            this.Load += new System.EventHandler(this.PantallaGestionConductores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonAgregarConductor;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}