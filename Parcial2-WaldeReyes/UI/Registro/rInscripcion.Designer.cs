namespace Parcial2_WaldeReyes.UI.Registro
{
    partial class rInscripcion
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
            this.components = new System.ComponentModel.Container();
            this.Limpiar = new System.Windows.Forms.Button();
            this.InscripcionIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.FechaDateTime = new System.Windows.Forms.DateTimePicker();
            this.MontoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Inscripcion = new System.Windows.Forms.GroupBox();
            this.Agregar = new System.Windows.Forms.Button();
            this.Removerbutton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.BalanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.CreditoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.EstudiantecomboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AsignaturaComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PrecioCreditoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InscripcionIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MontoNumericUpDown)).BeginInit();
            this.Inscripcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioCreditoNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(50, 465);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 55;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // InscripcionIdNumericUpDown
            // 
            this.InscripcionIdNumericUpDown.Location = new System.Drawing.Point(134, 60);
            this.InscripcionIdNumericUpDown.Name = "InscripcionIdNumericUpDown";
            this.InscripcionIdNumericUpDown.Size = new System.Drawing.Size(186, 20);
            this.InscripcionIdNumericUpDown.TabIndex = 54;
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(254, 465);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Eliminar.TabIndex = 53;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(157, 465);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 52;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(337, 58);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(80, 23);
            this.Buscar.TabIndex = 51;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Monto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "InscripcinId";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Regsitro Inscripcion";
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // FechaDateTime
            // 
            this.FechaDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTime.Location = new System.Drawing.Point(134, 155);
            this.FechaDateTime.Name = "FechaDateTime";
            this.FechaDateTime.Size = new System.Drawing.Size(283, 20);
            this.FechaDateTime.TabIndex = 56;
            // 
            // MontoNumericUpDown
            // 
            this.MontoNumericUpDown.Location = new System.Drawing.Point(67, 14);
            this.MontoNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.MontoNumericUpDown.Name = "MontoNumericUpDown";
            this.MontoNumericUpDown.Size = new System.Drawing.Size(62, 20);
            this.MontoNumericUpDown.TabIndex = 57;
            // 
            // Inscripcion
            // 
            this.Inscripcion.Controls.Add(this.Agregar);
            this.Inscripcion.Controls.Add(this.Removerbutton);
            this.Inscripcion.Controls.Add(this.dataGridView);
            this.Inscripcion.Controls.Add(this.BalanceNumericUpDown);
            this.Inscripcion.Controls.Add(this.label6);
            this.Inscripcion.Controls.Add(this.CreditoNumericUpDown);
            this.Inscripcion.Controls.Add(this.label5);
            this.Inscripcion.Controls.Add(this.MontoNumericUpDown);
            this.Inscripcion.Controls.Add(this.label4);
            this.Inscripcion.Location = new System.Drawing.Point(12, 216);
            this.Inscripcion.Name = "Inscripcion";
            this.Inscripcion.Size = new System.Drawing.Size(447, 243);
            this.Inscripcion.TabIndex = 58;
            this.Inscripcion.TabStop = false;
            this.Inscripcion.Text = "Inscripcion";
            this.Inscripcion.Enter += new System.EventHandler(this.Inscripcion_Enter);
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(422, 11);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(18, 23);
            this.Agregar.TabIndex = 30;
            this.Agregar.Text = "+";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Removerbutton
            // 
            this.Removerbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Removerbutton.Location = new System.Drawing.Point(6, 206);
            this.Removerbutton.Name = "Removerbutton";
            this.Removerbutton.Size = new System.Drawing.Size(114, 23);
            this.Removerbutton.TabIndex = 29;
            this.Removerbutton.Text = "- Remover Fila";
            this.Removerbutton.Click += new System.EventHandler(this.Removerbutton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(6, 43);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(435, 157);
            this.dataGridView.TabIndex = 4;
            // 
            // BalanceNumericUpDown
            // 
            this.BalanceNumericUpDown.Location = new System.Drawing.Point(346, 14);
            this.BalanceNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.BalanceNumericUpDown.Name = "BalanceNumericUpDown";
            this.BalanceNumericUpDown.Size = new System.Drawing.Size(70, 20);
            this.BalanceNumericUpDown.TabIndex = 3;
            this.BalanceNumericUpDown.ValueChanged += new System.EventHandler(this.BalanceNumericUpDown_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Balance";
            // 
            // CreditoNumericUpDown
            // 
            this.CreditoNumericUpDown.Location = new System.Drawing.Point(203, 14);
            this.CreditoNumericUpDown.Name = "CreditoNumericUpDown";
            this.CreditoNumericUpDown.Size = new System.Drawing.Size(68, 20);
            this.CreditoNumericUpDown.TabIndex = 1;
            this.CreditoNumericUpDown.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Credito";
            // 
            // EstudiantecomboBox
            // 
            this.EstudiantecomboBox.FormattingEnabled = true;
            this.EstudiantecomboBox.Location = new System.Drawing.Point(134, 93);
            this.EstudiantecomboBox.Name = "EstudiantecomboBox";
            this.EstudiantecomboBox.Size = new System.Drawing.Size(283, 21);
            this.EstudiantecomboBox.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "Estudiante";
            // 
            // AsignaturaComboBox
            // 
            this.AsignaturaComboBox.FormattingEnabled = true;
            this.AsignaturaComboBox.Location = new System.Drawing.Point(134, 128);
            this.AsignaturaComboBox.Name = "AsignaturaComboBox";
            this.AsignaturaComboBox.Size = new System.Drawing.Size(283, 21);
            this.AsignaturaComboBox.TabIndex = 62;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 63;
            this.label8.Text = "Materia";
            // 
            // PrecioCreditoNumericUpDown
            // 
            this.PrecioCreditoNumericUpDown.Location = new System.Drawing.Point(134, 190);
            this.PrecioCreditoNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.PrecioCreditoNumericUpDown.Name = "PrecioCreditoNumericUpDown";
            this.PrecioCreditoNumericUpDown.Size = new System.Drawing.Size(280, 20);
            this.PrecioCreditoNumericUpDown.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Monto Credito";
            // 
            // rInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 565);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PrecioCreditoNumericUpDown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AsignaturaComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EstudiantecomboBox);
            this.Controls.Add(this.Inscripcion);
            this.Controls.Add(this.FechaDateTime);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.InscripcionIdNumericUpDown);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rInscripcion";
            this.Text = "rInscripcion";
            ((System.ComponentModel.ISupportInitialize)(this.InscripcionIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MontoNumericUpDown)).EndInit();
            this.Inscripcion.ResumeLayout(false);
            this.Inscripcion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioCreditoNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.NumericUpDown InscripcionIdNumericUpDown;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.DateTimePicker FechaDateTime;
        private System.Windows.Forms.NumericUpDown MontoNumericUpDown;
        private System.Windows.Forms.GroupBox Inscripcion;
        private System.Windows.Forms.NumericUpDown CreditoNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown BalanceNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Removerbutton;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.ComboBox EstudiantecomboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox AsignaturaComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown PrecioCreditoNumericUpDown;
        private System.Windows.Forms.Label label9;
    }
}