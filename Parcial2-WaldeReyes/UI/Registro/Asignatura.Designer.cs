namespace Parcial2_WaldeReyes.UI.Registro
{
    partial class Asignatura
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
            this.Credito = new System.Windows.Forms.NumericUpDown();
            this.Limpiar = new System.Windows.Forms.Button();
            this.AsignaturaId = new System.Windows.Forms.NumericUpDown();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.Descripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Credito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsignaturaId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Credito
            // 
            this.Credito.Location = new System.Drawing.Point(115, 154);
            this.Credito.Name = "Credito";
            this.Credito.Size = new System.Drawing.Size(191, 20);
            this.Credito.TabIndex = 43;
            // 
            // Limpiar
            // 
            this.Limpiar.BackColor = System.Drawing.Color.DarkOrange;
            this.Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Limpiar.ForeColor = System.Drawing.Color.Black;
            this.Limpiar.Location = new System.Drawing.Point(27, 214);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 42;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = false;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // AsignaturaId
            // 
            this.AsignaturaId.Location = new System.Drawing.Point(115, 63);
            this.AsignaturaId.Name = "AsignaturaId";
            this.AsignaturaId.Size = new System.Drawing.Size(94, 20);
            this.AsignaturaId.TabIndex = 41;
            // 
            // Eliminar
            // 
            this.Eliminar.BackColor = System.Drawing.Color.DarkOrange;
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminar.ForeColor = System.Drawing.Color.Black;
            this.Eliminar.Location = new System.Drawing.Point(231, 214);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Eliminar.TabIndex = 40;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = false;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.Color.DarkOrange;
            this.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardar.ForeColor = System.Drawing.Color.Black;
            this.Guardar.Location = new System.Drawing.Point(134, 214);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 39;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Buscar
            // 
            this.Buscar.BackColor = System.Drawing.Color.DarkOrange;
            this.Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscar.ForeColor = System.Drawing.Color.Black;
            this.Buscar.Location = new System.Drawing.Point(231, 61);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 38;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = false;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Descripcion
            // 
            this.Descripcion.Location = new System.Drawing.Point(115, 110);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(191, 20);
            this.Descripcion.TabIndex = 37;
            this.Descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Descripcion_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Credito";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "AsignaturaId";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Registro Asignatura";
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // Asignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 253);
            this.Controls.Add(this.Credito);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.AsignaturaId);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Asignatura";
            this.Text = "Asignatura";
            ((System.ComponentModel.ISupportInitialize)(this.Credito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsignaturaId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Credito;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.NumericUpDown AsignaturaId;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.TextBox Descripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}