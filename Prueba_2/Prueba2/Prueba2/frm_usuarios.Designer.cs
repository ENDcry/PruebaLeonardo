namespace Prueba2
{
    partial class frm_usuarios
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
            this.Dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.Txt_Paterno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Materno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Sueldo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_actualziar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Txt_Fecha_Ingresa = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_usuarios
            // 
            this.Dgv_usuarios.AllowUserToAddRows = false;
            this.Dgv_usuarios.AllowUserToDeleteRows = false;
            this.Dgv_usuarios.AllowUserToOrderColumns = true;
            this.Dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_usuarios.Location = new System.Drawing.Point(12, 132);
            this.Dgv_usuarios.Name = "Dgv_usuarios";
            this.Dgv_usuarios.ReadOnly = true;
            this.Dgv_usuarios.Size = new System.Drawing.Size(754, 283);
            this.Dgv_usuarios.TabIndex = 0;
            this.Dgv_usuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_usuarios_CellClick);
            this.Dgv_usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(77, 16);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(100, 20);
            this.Txt_Name.TabIndex = 2;
            this.Txt_Name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Txt_Paterno
            // 
            this.Txt_Paterno.Location = new System.Drawing.Point(245, 16);
            this.Txt_Paterno.Name = "Txt_Paterno";
            this.Txt_Paterno.Size = new System.Drawing.Size(100, 20);
            this.Txt_Paterno.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Paterno";
            // 
            // Txt_Materno
            // 
            this.Txt_Materno.Location = new System.Drawing.Point(403, 16);
            this.Txt_Materno.Name = "Txt_Materno";
            this.Txt_Materno.Size = new System.Drawing.Size(100, 20);
            this.Txt_Materno.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Materno";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Txt_Sueldo
            // 
            this.Txt_Sueldo.Location = new System.Drawing.Point(149, 54);
            this.Txt_Sueldo.Name = "Txt_Sueldo";
            this.Txt_Sueldo.Size = new System.Drawing.Size(100, 20);
            this.Txt_Sueldo.TabIndex = 8;
            this.Txt_Sueldo.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sueldo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "FechaIngreso";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.Location = new System.Drawing.Point(199, 93);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_cancelar.TabIndex = 11;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.UseVisualStyleBackColor = true;
            this.Btn_cancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(301, 93);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Guardar.TabIndex = 12;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.Location = new System.Drawing.Point(530, 25);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(109, 85);
            this.Btn_Nuevo.TabIndex = 13;
            this.Btn_Nuevo.Text = "Nuevo";
            this.Btn_Nuevo.UseVisualStyleBackColor = true;
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // Btn_actualziar
            // 
            this.Btn_actualziar.Location = new System.Drawing.Point(512, 164);
            this.Btn_actualziar.Name = "Btn_actualziar";
            this.Btn_actualziar.Size = new System.Drawing.Size(109, 85);
            this.Btn_actualziar.TabIndex = 14;
            this.Btn_actualziar.Text = "Actualizar";
            this.Btn_actualziar.UseVisualStyleBackColor = true;
            this.Btn_actualziar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Location = new System.Drawing.Point(657, 25);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(109, 85);
            this.Btn_eliminar.TabIndex = 15;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // Txt_Fecha_Ingresa
            // 
            this.Txt_Fecha_Ingresa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Txt_Fecha_Ingresa.Location = new System.Drawing.Point(382, 61);
            this.Txt_Fecha_Ingresa.Name = "Txt_Fecha_Ingresa";
            this.Txt_Fecha_Ingresa.Size = new System.Drawing.Size(112, 20);
            this.Txt_Fecha_Ingresa.TabIndex = 17;
            this.Txt_Fecha_Ingresa.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // frm_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Txt_Fecha_Ingresa);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_Sueldo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Materno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Paterno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_usuarios);
            this.Controls.Add(this.Btn_actualziar);
            this.Name = "frm_usuarios";
            this.Text = "frm_usuarios";
            this.Load += new System.EventHandler(this.frm_usuarios_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_usuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.TextBox Txt_Paterno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Materno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Sueldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_actualziar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.DateTimePicker Txt_Fecha_Ingresa;
    }
}