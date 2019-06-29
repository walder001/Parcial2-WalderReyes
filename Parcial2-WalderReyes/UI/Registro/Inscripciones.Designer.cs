namespace Parcial2_WalderReyes.UI.Registro
{
    partial class Inscripciones
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
            this.EstudiantecomboBox = new System.Windows.Forms.ComboBox();
            this.Inscripcion = new System.Windows.Forms.GroupBox();
            this.Agregar = new System.Windows.Forms.Button();
            this.Removerbutton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.BalanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.CreditoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.MontoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FechaDateTime = new System.Windows.Forms.DateTimePicker();
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
            this.Inscripcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MontoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InscripcionIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // EstudiantecomboBox
            // 
            this.EstudiantecomboBox.FormattingEnabled = true;
            this.EstudiantecomboBox.Location = new System.Drawing.Point(105, 83);
            this.EstudiantecomboBox.Name = "EstudiantecomboBox";
            this.EstudiantecomboBox.Size = new System.Drawing.Size(121, 21);
            this.EstudiantecomboBox.TabIndex = 73;
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
            this.Inscripcion.Location = new System.Drawing.Point(15, 183);
            this.Inscripcion.Name = "Inscripcion";
            this.Inscripcion.Size = new System.Drawing.Size(325, 139);
            this.Inscripcion.TabIndex = 72;
            this.Inscripcion.TabStop = false;
            this.Inscripcion.Text = "groupBox1";
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(304, 11);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(18, 23);
            this.Agregar.TabIndex = 30;
            this.Agregar.Text = "+";
            this.Agregar.UseVisualStyleBackColor = true;
            // 
            // Removerbutton
            // 
            this.Removerbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Removerbutton.Location = new System.Drawing.Point(6, 110);
            this.Removerbutton.Name = "Removerbutton";
            this.Removerbutton.Size = new System.Drawing.Size(114, 23);
            this.Removerbutton.TabIndex = 29;
            this.Removerbutton.Text = "- Remover Fila";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(6, 43);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(292, 61);
            this.dataGridView.TabIndex = 4;
            // 
            // BalanceNumericUpDown
            // 
            this.BalanceNumericUpDown.Location = new System.Drawing.Point(228, 14);
            this.BalanceNumericUpDown.Name = "BalanceNumericUpDown";
            this.BalanceNumericUpDown.Size = new System.Drawing.Size(70, 20);
            this.BalanceNumericUpDown.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Balance";
            // 
            // CreditoNumericUpDown
            // 
            this.CreditoNumericUpDown.Location = new System.Drawing.Point(68, 14);
            this.CreditoNumericUpDown.Name = "CreditoNumericUpDown";
            this.CreditoNumericUpDown.Size = new System.Drawing.Size(106, 20);
            this.CreditoNumericUpDown.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Credito";
            // 
            // MontoNumericUpDown
            // 
            this.MontoNumericUpDown.Location = new System.Drawing.Point(108, 147);
            this.MontoNumericUpDown.Name = "MontoNumericUpDown";
            this.MontoNumericUpDown.Size = new System.Drawing.Size(188, 20);
            this.MontoNumericUpDown.TabIndex = 71;
            // 
            // FechaDateTime
            // 
            this.FechaDateTime.Location = new System.Drawing.Point(105, 110);
            this.FechaDateTime.Name = "FechaDateTime";
            this.FechaDateTime.Size = new System.Drawing.Size(191, 20);
            this.FechaDateTime.TabIndex = 70;
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(17, 328);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 69;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            // 
            // InscripcionIdNumericUpDown
            // 
            this.InscripcionIdNumericUpDown.Location = new System.Drawing.Point(105, 56);
            this.InscripcionIdNumericUpDown.Name = "InscripcionIdNumericUpDown";
            this.InscripcionIdNumericUpDown.Size = new System.Drawing.Size(94, 20);
            this.InscripcionIdNumericUpDown.TabIndex = 68;
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(221, 328);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Eliminar.TabIndex = 67;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(124, 328);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 66;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(221, 54);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 65;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Monto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "InscripcinId";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Regsitro Inscripcion";
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // Inscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 371);
            this.Controls.Add(this.EstudiantecomboBox);
            this.Controls.Add(this.Inscripcion);
            this.Controls.Add(this.MontoNumericUpDown);
            this.Controls.Add(this.FechaDateTime);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.InscripcionIdNumericUpDown);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Inscripciones";
            this.Text = "Inscripciones";
            this.Inscripcion.ResumeLayout(false);
            this.Inscripcion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MontoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InscripcionIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox EstudiantecomboBox;
        private System.Windows.Forms.GroupBox Inscripcion;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button Removerbutton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.NumericUpDown BalanceNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown CreditoNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown MontoNumericUpDown;
        private System.Windows.Forms.DateTimePicker FechaDateTime;
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
    }
}