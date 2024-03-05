namespace BusesUNED_Cliente.Pantallas
{
    partial class PantallaSupervisor
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
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.labelFechaFinal = new System.Windows.Forms.Label();
            this.campoFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.campoFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.labelIdRuta = new System.Windows.Forms.Label();
            this.comboBuscaConductores = new System.Windows.Forms.ComboBox();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBuscaAutobuses = new System.Windows.Forms.ComboBox();
            this.comboBuscaRutas = new System.Windows.Forms.ComboBox();
            this.campoAutobus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lableDatosSupervisor = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboAgregarAutbuses = new System.Windows.Forms.ComboBox();
            this.comboAgregarRutas = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.campoFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboAgregarConductores = new System.Windows.Forms.ComboBox();
            this.campoHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(306, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "AUTOTRANSPORTES - UNED";
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Location = new System.Drawing.Point(5, 33);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(94, 21);
            this.labelFechaInicio.TabIndex = 1;
            this.labelFechaInicio.Text = "Fecha inicio:";
            // 
            // labelFechaFinal
            // 
            this.labelFechaFinal.AutoSize = true;
            this.labelFechaFinal.Location = new System.Drawing.Point(333, 33);
            this.labelFechaFinal.Name = "labelFechaFinal";
            this.labelFechaFinal.Size = new System.Drawing.Size(87, 21);
            this.labelFechaFinal.TabIndex = 2;
            this.labelFechaFinal.Text = "Fecha final:";
            // 
            // campoFechaInicio
            // 
            this.campoFechaInicio.CustomFormat = "dd/MM/yyyy";
            this.campoFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.campoFechaInicio.Location = new System.Drawing.Point(105, 28);
            this.campoFechaInicio.Name = "campoFechaInicio";
            this.campoFechaInicio.Size = new System.Drawing.Size(121, 29);
            this.campoFechaInicio.TabIndex = 3;
            // 
            // campoFechaFinal
            // 
            this.campoFechaFinal.CustomFormat = "dd/MM/yyyy";
            this.campoFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.campoFechaFinal.Location = new System.Drawing.Point(426, 27);
            this.campoFechaFinal.Name = "campoFechaFinal";
            this.campoFechaFinal.Size = new System.Drawing.Size(128, 29);
            this.campoFechaFinal.TabIndex = 4;
            // 
            // labelIdRuta
            // 
            this.labelIdRuta.AutoSize = true;
            this.labelIdRuta.Location = new System.Drawing.Point(580, 110);
            this.labelIdRuta.Name = "labelIdRuta";
            this.labelIdRuta.Size = new System.Drawing.Size(0, 21);
            this.labelIdRuta.TabIndex = 5;
            // 
            // comboBuscaConductores
            // 
            this.comboBuscaConductores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBuscaConductores.FormattingEnabled = true;
            this.comboBuscaConductores.Location = new System.Drawing.Point(95, 119);
            this.comboBuscaConductores.Name = "comboBuscaConductores";
            this.comboBuscaConductores.Size = new System.Drawing.Size(719, 29);
            this.comboBuscaConductores.TabIndex = 8;
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonConsultar.Location = new System.Drawing.Point(720, 25);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(94, 31);
            this.buttonConsultar.TabIndex = 9;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(820, 240);
            this.dataGridView1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBuscaAutobuses);
            this.groupBox1.Controls.Add(this.comboBuscaRutas);
            this.groupBox1.Controls.Add(this.campoAutobus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.campoFechaInicio);
            this.groupBox1.Controls.Add(this.buttonConsultar);
            this.groupBox1.Controls.Add(this.labelFechaInicio);
            this.groupBox1.Controls.Add(this.labelFechaFinal);
            this.groupBox1.Controls.Add(this.comboBuscaConductores);
            this.groupBox1.Controls.Add(this.campoFechaFinal);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 203);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criterios de Busqueda";
            // 
            // comboBuscaAutobuses
            // 
            this.comboBuscaAutobuses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBuscaAutobuses.FormattingEnabled = true;
            this.comboBuscaAutobuses.Location = new System.Drawing.Point(95, 161);
            this.comboBuscaAutobuses.Name = "comboBuscaAutobuses";
            this.comboBuscaAutobuses.Size = new System.Drawing.Size(719, 29);
            this.comboBuscaAutobuses.TabIndex = 13;
            // 
            // comboBuscaRutas
            // 
            this.comboBuscaRutas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBuscaRutas.FormattingEnabled = true;
            this.comboBuscaRutas.Location = new System.Drawing.Point(95, 77);
            this.comboBuscaRutas.Name = "comboBuscaRutas";
            this.comboBuscaRutas.Size = new System.Drawing.Size(719, 29);
            this.comboBuscaRutas.TabIndex = 12;
            // 
            // campoAutobus
            // 
            this.campoAutobus.AutoSize = true;
            this.campoAutobus.Location = new System.Drawing.Point(5, 162);
            this.campoAutobus.Name = "campoAutobus";
            this.campoAutobus.Size = new System.Drawing.Size(71, 21);
            this.campoAutobus.TabIndex = 11;
            this.campoAutobus.Text = "Autobus:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ruta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Conductor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Supervisor:";
            // 
            // lableDatosSupervisor
            // 
            this.lableDatosSupervisor.AutoSize = true;
            this.lableDatosSupervisor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lableDatosSupervisor.Location = new System.Drawing.Point(102, 51);
            this.lableDatosSupervisor.Name = "lableDatosSupervisor";
            this.lableDatosSupervisor.Size = new System.Drawing.Size(68, 21);
            this.lableDatosSupervisor.TabIndex = 13;
            this.lableDatosSupervisor.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboAgregarAutbuses);
            this.groupBox2.Controls.Add(this.comboAgregarRutas);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.campoFechaSalida);
            this.groupBox2.Controls.Add(this.buttonAgregar);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.comboAgregarConductores);
            this.groupBox2.Controls.Add(this.campoHoraSalida);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(820, 203);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar Roles";
            // 
            // comboAgregarAutbuses
            // 
            this.comboAgregarAutbuses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAgregarAutbuses.FormattingEnabled = true;
            this.comboAgregarAutbuses.Location = new System.Drawing.Point(98, 162);
            this.comboAgregarAutbuses.Name = "comboAgregarAutbuses";
            this.comboAgregarAutbuses.Size = new System.Drawing.Size(716, 29);
            this.comboAgregarAutbuses.TabIndex = 13;
            // 
            // comboAgregarRutas
            // 
            this.comboAgregarRutas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAgregarRutas.FormattingEnabled = true;
            this.comboAgregarRutas.Location = new System.Drawing.Point(98, 77);
            this.comboAgregarRutas.Name = "comboAgregarRutas";
            this.comboAgregarRutas.Size = new System.Drawing.Size(716, 29);
            this.comboAgregarRutas.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Autobus:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ruta:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 21);
            this.label9.TabIndex = 9;
            this.label9.Text = "Conductor:";
            // 
            // campoFechaSalida
            // 
            this.campoFechaSalida.CustomFormat = "dd/MM/yyyy";
            this.campoFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.campoFechaSalida.Location = new System.Drawing.Point(129, 28);
            this.campoFechaSalida.Name = "campoFechaSalida";
            this.campoFechaSalida.Size = new System.Drawing.Size(121, 29);
            this.campoFechaSalida.TabIndex = 3;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonAgregar.Location = new System.Drawing.Point(720, 28);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(94, 30);
            this.buttonAgregar.TabIndex = 9;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 21);
            this.label10.TabIndex = 1;
            this.label10.Text = "Fecha de salida:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(256, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 21);
            this.label11.TabIndex = 2;
            this.label11.Text = "Hora:";
            // 
            // comboAgregarConductores
            // 
            this.comboAgregarConductores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAgregarConductores.FormattingEnabled = true;
            this.comboAgregarConductores.Location = new System.Drawing.Point(98, 118);
            this.comboAgregarConductores.Name = "comboAgregarConductores";
            this.comboAgregarConductores.Size = new System.Drawing.Size(716, 29);
            this.comboAgregarConductores.TabIndex = 8;
            // 
            // campoHoraSalida
            // 
            this.campoHoraSalida.CustomFormat = "HH:mm";
            this.campoHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.campoHoraSalida.Location = new System.Drawing.Point(309, 28);
            this.campoHoraSalida.Name = "campoHoraSalida";
            this.campoHoraSalida.ShowUpDown = true;
            this.campoHoraSalida.Size = new System.Drawing.Size(71, 29);
            this.campoHoraSalida.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 298);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(836, 274);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Roles Encontrados";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 75);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(842, 249);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(834, 215);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Criterios de Busqueda";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(834, 215);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Agregar Roles";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PantallaSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 581);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lableDatosSupervisor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelIdRuta);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PantallaSupervisor";
            this.Text = "PantallaSupervisor";
            this.Load += new System.EventHandler(this.PantallaSupervisor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.Label labelFechaFinal;
        private System.Windows.Forms.DateTimePicker campoFechaInicio;
        private System.Windows.Forms.DateTimePicker campoFechaFinal;
        private System.Windows.Forms.Label labelIdRuta;
        private System.Windows.Forms.ComboBox comboBuscaConductores;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBuscaAutobuses;
        private System.Windows.Forms.ComboBox comboBuscaRutas;
        private System.Windows.Forms.Label campoAutobus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lableDatosSupervisor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboAgregarAutbuses;
        private System.Windows.Forms.ComboBox comboAgregarRutas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker campoFechaSalida;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboAgregarConductores;
        private System.Windows.Forms.DateTimePicker campoHoraSalida;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}