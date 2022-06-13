namespace Cliente_Distribuidas
{
    partial class Form_Pacientes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_numeroIESS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_GUARDAR = new System.Windows.Forms.Button();
            this.textBox_NOMBRE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_APELLIDO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_CEDULA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_TELEFONO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_DIRECCION = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_PACIENTES = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PACIENTES)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_numeroIESS);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button_GUARDAR);
            this.groupBox1.Controls.Add(this.textBox_NOMBRE);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_APELLIDO);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_CEDULA);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_TELEFONO);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_DIRECCION);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_ID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 656);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS PACIENTE";
            // 
            // textBox_numeroIESS
            // 
            this.textBox_numeroIESS.Location = new System.Drawing.Point(17, 467);
            this.textBox_numeroIESS.MaxLength = 10;
            this.textBox_numeroIESS.Name = "textBox_numeroIESS";
            this.textBox_numeroIESS.Size = new System.Drawing.Size(220, 20);
            this.textBox_numeroIESS.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 451);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Numero IESS";
            // 
            // button_GUARDAR
            // 
            this.button_GUARDAR.Location = new System.Drawing.Point(107, 586);
            this.button_GUARDAR.Name = "button_GUARDAR";
            this.button_GUARDAR.Size = new System.Drawing.Size(98, 39);
            this.button_GUARDAR.TabIndex = 8;
            this.button_GUARDAR.Text = "GUARDAR";
            this.button_GUARDAR.UseVisualStyleBackColor = true;
            this.button_GUARDAR.Click += new System.EventHandler(this.button_GUARDAR_Click);
            // 
            // textBox_NOMBRE
            // 
            this.textBox_NOMBRE.Location = new System.Drawing.Point(17, 101);
            this.textBox_NOMBRE.MaxLength = 50;
            this.textBox_NOMBRE.Name = "textBox_NOMBRE";
            this.textBox_NOMBRE.Size = new System.Drawing.Size(220, 20);
            this.textBox_NOMBRE.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "NOMBRE";
            // 
            // textBox_APELLIDO
            // 
            this.textBox_APELLIDO.Location = new System.Drawing.Point(17, 163);
            this.textBox_APELLIDO.MaxLength = 50;
            this.textBox_APELLIDO.Name = "textBox_APELLIDO";
            this.textBox_APELLIDO.Size = new System.Drawing.Size(220, 20);
            this.textBox_APELLIDO.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "APELLIDO";
            // 
            // textBox_CEDULA
            // 
            this.textBox_CEDULA.Location = new System.Drawing.Point(17, 230);
            this.textBox_CEDULA.MaxLength = 10;
            this.textBox_CEDULA.Name = "textBox_CEDULA";
            this.textBox_CEDULA.Size = new System.Drawing.Size(220, 20);
            this.textBox_CEDULA.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "CEDULA";
            // 
            // textBox_TELEFONO
            // 
            this.textBox_TELEFONO.Location = new System.Drawing.Point(17, 287);
            this.textBox_TELEFONO.MaxLength = 10;
            this.textBox_TELEFONO.Name = "textBox_TELEFONO";
            this.textBox_TELEFONO.Size = new System.Drawing.Size(220, 20);
            this.textBox_TELEFONO.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "TELEFONO";
            // 
            // textBox_DIRECCION
            // 
            this.textBox_DIRECCION.Location = new System.Drawing.Point(17, 350);
            this.textBox_DIRECCION.MaxLength = 100;
            this.textBox_DIRECCION.Multiline = true;
            this.textBox_DIRECCION.Name = "textBox_DIRECCION";
            this.textBox_DIRECCION.Size = new System.Drawing.Size(220, 83);
            this.textBox_DIRECCION.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DIRECCION";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(17, 46);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.ReadOnly = true;
            this.textBox_ID.Size = new System.Drawing.Size(220, 20);
            this.textBox_ID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_PACIENTES);
            this.groupBox2.Location = new System.Drawing.Point(406, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(728, 655);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LISTADO DE PACIENTES";
            // 
            // dataGridView_PACIENTES
            // 
            this.dataGridView_PACIENTES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PACIENTES.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_PACIENTES.Name = "dataGridView_PACIENTES";
            this.dataGridView_PACIENTES.Size = new System.Drawing.Size(716, 630);
            this.dataGridView_PACIENTES.TabIndex = 0;
            this.dataGridView_PACIENTES.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_PACIENTES_CellClick);
            // 
            // Form_Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1146, 680);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Pacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_Pacientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PACIENTES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_GUARDAR;
        private System.Windows.Forms.TextBox textBox_NOMBRE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_APELLIDO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_CEDULA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_TELEFONO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_DIRECCION;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_PACIENTES;
        private System.Windows.Forms.TextBox textBox_numeroIESS;
        private System.Windows.Forms.Label label7;
    }
}

