namespace TallerPractica2GUI
{
    partial class Form1
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
            this.txtnumerodeliquidacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbtipodeafilacion = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtValorservicio = new System.Windows.Forms.TextBox();
            this.txtTarifa = new System.Windows.Forms.TextBox();
            this.txtTopemaximo = new System.Windows.Forms.TextBox();
            this.txtCuotamoderadorareal = new System.Windows.Forms.TextBox();
            this.txtCuotamoderadora = new System.Windows.Forms.TextBox();
            this.txtSalariodevengado = new System.Windows.Forms.TextBox();
            this.txtidentificaciondelpaciente = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFechadeAfiliacion = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtnumerodeliquidacion
            // 
            this.txtnumerodeliquidacion.Location = new System.Drawing.Point(162, 25);
            this.txtnumerodeliquidacion.Name = "txtnumerodeliquidacion";
            this.txtnumerodeliquidacion.Size = new System.Drawing.Size(100, 20);
            this.txtnumerodeliquidacion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Liquidacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(311, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tope Maximo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tarifa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Valor Servicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Salario Devengado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-4, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Identificacion del Paciente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cuota Moderada";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Cuota Moderada Real";
            // 
            // cmbtipodeafilacion
            // 
            this.cmbtipodeafilacion.FormattingEnabled = true;
            this.cmbtipodeafilacion.Items.AddRange(new object[] {
            "Contributivo",
            "Subsidiado"});
            this.cmbtipodeafilacion.Location = new System.Drawing.Point(450, 75);
            this.cmbtipodeafilacion.Name = "cmbtipodeafilacion";
            this.cmbtipodeafilacion.Size = new System.Drawing.Size(121, 21);
            this.cmbtipodeafilacion.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(329, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Tipo de Afiliacion";
            // 
            // txtValorservicio
            // 
            this.txtValorservicio.Location = new System.Drawing.Point(162, 137);
            this.txtValorservicio.Name = "txtValorservicio";
            this.txtValorservicio.Size = new System.Drawing.Size(100, 20);
            this.txtValorservicio.TabIndex = 11;
            // 
            // txtTarifa
            // 
            this.txtTarifa.Location = new System.Drawing.Point(150, 43);
            this.txtTarifa.Name = "txtTarifa";
            this.txtTarifa.Size = new System.Drawing.Size(100, 21);
            this.txtTarifa.TabIndex = 12;
            // 
            // txtTopemaximo
            // 
            this.txtTopemaximo.Location = new System.Drawing.Point(421, 26);
            this.txtTopemaximo.Name = "txtTopemaximo";
            this.txtTopemaximo.Size = new System.Drawing.Size(100, 21);
            this.txtTopemaximo.TabIndex = 13;
            // 
            // txtCuotamoderadorareal
            // 
            this.txtCuotamoderadorareal.Location = new System.Drawing.Point(159, 101);
            this.txtCuotamoderadorareal.Name = "txtCuotamoderadorareal";
            this.txtCuotamoderadorareal.Size = new System.Drawing.Size(100, 21);
            this.txtCuotamoderadorareal.TabIndex = 14;
            // 
            // txtCuotamoderadora
            // 
            this.txtCuotamoderadora.Location = new System.Drawing.Point(421, 81);
            this.txtCuotamoderadora.Name = "txtCuotamoderadora";
            this.txtCuotamoderadora.Size = new System.Drawing.Size(100, 21);
            this.txtCuotamoderadora.TabIndex = 15;
            // 
            // txtSalariodevengado
            // 
            this.txtSalariodevengado.Location = new System.Drawing.Point(450, 130);
            this.txtSalariodevengado.Name = "txtSalariodevengado";
            this.txtSalariodevengado.Size = new System.Drawing.Size(100, 20);
            this.txtSalariodevengado.TabIndex = 16;
            // 
            // txtidentificaciondelpaciente
            // 
            this.txtidentificaciondelpaciente.Location = new System.Drawing.Point(162, 76);
            this.txtidentificaciondelpaciente.Name = "txtidentificaciondelpaciente";
            this.txtidentificaciondelpaciente.Size = new System.Drawing.Size(100, 20);
            this.txtidentificaciondelpaciente.TabIndex = 17;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(38, 376);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(208, 375);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(357, 376);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 20;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(208, 441);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 21;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(38, 441);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(357, 441);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTarifa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTopemaximo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCuotamoderadorareal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCuotamoderadora);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 165);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RESULTADOS";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(324, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Fecha de Afiliacion";
            // 
            // txtFechadeAfiliacion
            // 
            this.txtFechadeAfiliacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechadeAfiliacion.Location = new System.Drawing.Point(450, 19);
            this.txtFechadeAfiliacion.Name = "txtFechadeAfiliacion";
            this.txtFechadeAfiliacion.Size = new System.Drawing.Size(137, 20);
            this.txtFechadeAfiliacion.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 476);
            this.Controls.Add(this.txtFechadeAfiliacion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtidentificaciondelpaciente);
            this.Controls.Add(this.txtSalariodevengado);
            this.Controls.Add(this.txtValorservicio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbtipodeafilacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnumerodeliquidacion);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtnumerodeliquidacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbtipodeafilacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtValorservicio;
        private System.Windows.Forms.TextBox txtTarifa;
        private System.Windows.Forms.TextBox txtTopemaximo;
        private System.Windows.Forms.TextBox txtCuotamoderadorareal;
        private System.Windows.Forms.TextBox txtCuotamoderadora;
        private System.Windows.Forms.TextBox txtSalariodevengado;
        private System.Windows.Forms.TextBox txtidentificaciondelpaciente;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker txtFechadeAfiliacion;
    }
}

