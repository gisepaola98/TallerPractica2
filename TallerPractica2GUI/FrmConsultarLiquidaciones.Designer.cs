namespace TallerPractica2GUI
{
    partial class FrmConsultarLiquidaciones
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltrarfecha = new System.Windows.Forms.Button();
            this.cmbConsultartipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnFiltar = new System.Windows.Forms.Button();
            this.txtNumeroliquidaciones = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.txtRegimensubsidiado = new System.Windows.Forms.TextBox();
            this.txtLiquidaciones = new System.Windows.Forms.TextBox();
            this.txtRegimencontributivo = new System.Windows.Forms.TextBox();
            this.dgtLiquidaciones = new System.Windows.Forms.DataGridView();
            this.txtTotalSubsidiado = new System.Windows.Forms.TextBox();
            this.txtTotalcontributivo = new System.Windows.Forms.TextBox();
            this.txtTotalliquidaciones = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgtLiquidaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(847, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(149, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(86, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha De  Afiliacion";
            // 
            // btnFiltrarfecha
            // 
            this.btnFiltrarfecha.Location = new System.Drawing.Point(281, 56);
            this.btnFiltrarfecha.Name = "btnFiltrarfecha";
            this.btnFiltrarfecha.Size = new System.Drawing.Size(94, 23);
            this.btnFiltrarfecha.TabIndex = 5;
            this.btnFiltrarfecha.Text = "Filtar Por Fecha";
            this.btnFiltrarfecha.UseVisualStyleBackColor = true;
            // 
            // cmbConsultartipo
            // 
            this.cmbConsultartipo.FormattingEnabled = true;
            this.cmbConsultartipo.Items.AddRange(new object[] {
            "Regimen Subsidiado",
            "Regimen Contributivo",
            "Ambos"});
            this.cmbConsultartipo.Location = new System.Drawing.Point(149, 94);
            this.cmbConsultartipo.Name = "cmbConsultartipo";
            this.cmbConsultartipo.Size = new System.Drawing.Size(86, 21);
            this.cmbConsultartipo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Numero De Liquidaciones";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(281, 94);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(94, 23);
            this.btnConsultar.TabIndex = 9;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnFiltar
            // 
            this.btnFiltar.Location = new System.Drawing.Point(281, 133);
            this.btnFiltar.Name = "btnFiltar";
            this.btnFiltar.Size = new System.Drawing.Size(94, 23);
            this.btnFiltar.TabIndex = 10;
            this.btnFiltar.Text = "Filtrar ";
            this.btnFiltar.UseVisualStyleBackColor = true;
            // 
            // txtNumeroliquidaciones
            // 
            this.txtNumeroliquidaciones.Location = new System.Drawing.Point(144, 136);
            this.txtNumeroliquidaciones.Name = "txtNumeroliquidaciones";
            this.txtNumeroliquidaciones.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroliquidaciones.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(507, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total Regimen Subsidiado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(507, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Total Regimen Contributivo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(522, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Total Liquidaciones";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(470, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Liquidaciones";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(459, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Regimen Contributivo";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(459, 56);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(104, 13);
            this.l.TabIndex = 19;
            this.l.Text = "Regimen Subsidiado";
            // 
            // txtRegimensubsidiado
            // 
            this.txtRegimensubsidiado.Location = new System.Drawing.Point(614, 48);
            this.txtRegimensubsidiado.Name = "txtRegimensubsidiado";
            this.txtRegimensubsidiado.Size = new System.Drawing.Size(100, 20);
            this.txtRegimensubsidiado.TabIndex = 20;
            // 
            // txtLiquidaciones
            // 
            this.txtLiquidaciones.Location = new System.Drawing.Point(614, 126);
            this.txtLiquidaciones.Name = "txtLiquidaciones";
            this.txtLiquidaciones.Size = new System.Drawing.Size(100, 20);
            this.txtLiquidaciones.TabIndex = 21;
            // 
            // txtRegimencontributivo
            // 
            this.txtRegimencontributivo.Location = new System.Drawing.Point(614, 87);
            this.txtRegimencontributivo.Name = "txtRegimencontributivo";
            this.txtRegimencontributivo.Size = new System.Drawing.Size(100, 20);
            this.txtRegimencontributivo.TabIndex = 22;
            // 
            // dgtLiquidaciones
            // 
            this.dgtLiquidaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtLiquidaciones.Location = new System.Drawing.Point(12, 175);
            this.dgtLiquidaciones.Name = "dgtLiquidaciones";
            this.dgtLiquidaciones.Size = new System.Drawing.Size(823, 164);
            this.dgtLiquidaciones.TabIndex = 2;
            // 
            // txtTotalSubsidiado
            // 
            this.txtTotalSubsidiado.Location = new System.Drawing.Point(657, 434);
            this.txtTotalSubsidiado.Name = "txtTotalSubsidiado";
            this.txtTotalSubsidiado.Size = new System.Drawing.Size(100, 20);
            this.txtTotalSubsidiado.TabIndex = 23;
            // 
            // txtTotalcontributivo
            // 
            this.txtTotalcontributivo.Location = new System.Drawing.Point(657, 401);
            this.txtTotalcontributivo.Name = "txtTotalcontributivo";
            this.txtTotalcontributivo.Size = new System.Drawing.Size(100, 20);
            this.txtTotalcontributivo.TabIndex = 24;
            // 
            // txtTotalliquidaciones
            // 
            this.txtTotalliquidaciones.Location = new System.Drawing.Point(657, 362);
            this.txtTotalliquidaciones.Name = "txtTotalliquidaciones";
            this.txtTotalliquidaciones.Size = new System.Drawing.Size(100, 20);
            this.txtTotalliquidaciones.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Consultar Por Tipo";
            // 
            // FrmConsultarLiquidaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 459);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalliquidaciones);
            this.Controls.Add(this.txtTotalcontributivo);
            this.Controls.Add(this.txtTotalSubsidiado);
            this.Controls.Add(this.txtRegimencontributivo);
            this.Controls.Add(this.txtLiquidaciones);
            this.Controls.Add(this.txtRegimensubsidiado);
            this.Controls.Add(this.l);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNumeroliquidaciones);
            this.Controls.Add(this.btnFiltar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbConsultartipo);
            this.Controls.Add(this.btnFiltrarfecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgtLiquidaciones);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmConsultarLiquidaciones";
            this.Text = "FrmConsultarLiquidaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgtLiquidaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrarfecha;
        private System.Windows.Forms.ComboBox cmbConsultartipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnFiltar;
        private System.Windows.Forms.TextBox txtNumeroliquidaciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.TextBox txtRegimensubsidiado;
        private System.Windows.Forms.TextBox txtLiquidaciones;
        private System.Windows.Forms.TextBox txtRegimencontributivo;
        private System.Windows.Forms.DataGridView dgtLiquidaciones;
        private System.Windows.Forms.TextBox txtTotalSubsidiado;
        private System.Windows.Forms.TextBox txtTotalcontributivo;
        private System.Windows.Forms.TextBox txtTotalliquidaciones;
        private System.Windows.Forms.Label label2;
    }
}