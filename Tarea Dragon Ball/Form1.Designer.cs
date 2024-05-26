namespace Tarea_Dragon_Ball
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
            this.ID = new System.Windows.Forms.Label();
            this.crear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Boxid = new System.Windows.Forms.TextBox();
            this.Boxnombre = new System.Windows.Forms.TextBox();
            this.textBoxhistoria = new System.Windows.Forms.TextBox();
            this.comboBox1raza = new System.Windows.Forms.ComboBox();
            this.nivelpoder = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewPersonajes = new System.Windows.Forms.DataGridView();
            this.buttoneliminar = new System.Windows.Forms.Button();
            this.buttonbuscar = new System.Windows.Forms.Button();
            this.buttonactu = new System.Windows.Forms.Button();
            this.cargar = new System.Windows.Forms.Button();
            this.prueba = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nivelpoder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).BeginInit();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(208, 9);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(36, 27);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID";
            this.ID.Click += new System.EventHandler(this.label1_Click);
            // 
            // crear
            // 
            this.crear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crear.Location = new System.Drawing.Point(24, 286);
            this.crear.Name = "crear";
            this.crear.Size = new System.Drawing.Size(131, 44);
            this.crear.TabIndex = 1;
            this.crear.Text = "Crear";
            this.crear.UseVisualStyleBackColor = true;
            this.crear.Click += new System.EventHandler(this.crear_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Raza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nivel de Poder";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(143, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Historia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha de Creación";
            // 
            // Boxid
            // 
            this.Boxid.Location = new System.Drawing.Point(278, 15);
            this.Boxid.Name = "Boxid";
            this.Boxid.Size = new System.Drawing.Size(122, 22);
            this.Boxid.TabIndex = 7;
            // 
            // Boxnombre
            // 
            this.Boxnombre.Location = new System.Drawing.Point(278, 58);
            this.Boxnombre.Name = "Boxnombre";
            this.Boxnombre.Size = new System.Drawing.Size(122, 22);
            this.Boxnombre.TabIndex = 8;
            // 
            // textBoxhistoria
            // 
            this.textBoxhistoria.Location = new System.Drawing.Point(277, 185);
            this.textBoxhistoria.Name = "textBoxhistoria";
            this.textBoxhistoria.Size = new System.Drawing.Size(122, 22);
            this.textBoxhistoria.TabIndex = 9;
            // 
            // comboBox1raza
            // 
            this.comboBox1raza.FormattingEnabled = true;
            this.comboBox1raza.Location = new System.Drawing.Point(278, 103);
            this.comboBox1raza.Name = "comboBox1raza";
            this.comboBox1raza.Size = new System.Drawing.Size(121, 24);
            this.comboBox1raza.TabIndex = 10;
            // 
            // nivelpoder
            // 
            this.nivelpoder.Location = new System.Drawing.Point(277, 145);
            this.nivelpoder.Name = "nivelpoder";
            this.nivelpoder.Size = new System.Drawing.Size(120, 22);
            this.nivelpoder.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(277, 232);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(267, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // dataGridViewPersonajes
            // 
            this.dataGridViewPersonajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonajes.Location = new System.Drawing.Point(24, 336);
            this.dataGridViewPersonajes.Name = "dataGridViewPersonajes";
            this.dataGridViewPersonajes.RowHeadersWidth = 51;
            this.dataGridViewPersonajes.RowTemplate.Height = 24;
            this.dataGridViewPersonajes.Size = new System.Drawing.Size(974, 206);
            this.dataGridViewPersonajes.TabIndex = 13;
            // 
            // buttoneliminar
            // 
            this.buttoneliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoneliminar.Location = new System.Drawing.Point(867, 286);
            this.buttoneliminar.Name = "buttoneliminar";
            this.buttoneliminar.Size = new System.Drawing.Size(131, 44);
            this.buttoneliminar.TabIndex = 14;
            this.buttoneliminar.Text = "Elminar";
            this.buttoneliminar.UseVisualStyleBackColor = true;
            this.buttoneliminar.Click += new System.EventHandler(this.buttoneliminar_Click_1);
            // 
            // buttonbuscar
            // 
            this.buttonbuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonbuscar.Location = new System.Drawing.Point(675, 286);
            this.buttonbuscar.Name = "buttonbuscar";
            this.buttonbuscar.Size = new System.Drawing.Size(131, 44);
            this.buttonbuscar.TabIndex = 15;
            this.buttonbuscar.Text = "Buscar";
            this.buttonbuscar.UseVisualStyleBackColor = true;
            this.buttonbuscar.Click += new System.EventHandler(this.buttonbuscar_Click_1);
            // 
            // buttonactu
            // 
            this.buttonactu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonactu.Location = new System.Drawing.Point(213, 286);
            this.buttonactu.Name = "buttonactu";
            this.buttonactu.Size = new System.Drawing.Size(146, 44);
            this.buttonactu.TabIndex = 16;
            this.buttonactu.Text = "Actualizar";
            this.buttonactu.UseVisualStyleBackColor = true;
            this.buttonactu.Click += new System.EventHandler(this.buttonactu_Click_1);
            // 
            // cargar
            // 
            this.cargar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargar.Location = new System.Drawing.Point(445, 286);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(131, 44);
            this.cargar.TabIndex = 17;
            this.cargar.Text = "Cargar";
            this.cargar.UseVisualStyleBackColor = true;
            this.cargar.Click += new System.EventHandler(this.cargar_Click_1);
            // 
            // prueba
            // 
            this.prueba.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prueba.Location = new System.Drawing.Point(758, 20);
            this.prueba.Name = "prueba";
            this.prueba.Size = new System.Drawing.Size(220, 181);
            this.prueba.TabIndex = 18;
            this.prueba.Text = "Prueba de Conexion";
            this.prueba.UseVisualStyleBackColor = true;
            this.prueba.Click += new System.EventHandler(this.prueba_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 554);
            this.Controls.Add(this.prueba);
            this.Controls.Add(this.cargar);
            this.Controls.Add(this.buttonactu);
            this.Controls.Add(this.buttonbuscar);
            this.Controls.Add(this.buttoneliminar);
            this.Controls.Add(this.dataGridViewPersonajes);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.nivelpoder);
            this.Controls.Add(this.comboBox1raza);
            this.Controls.Add(this.textBoxhistoria);
            this.Controls.Add(this.Boxnombre);
            this.Controls.Add(this.Boxid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crear);
            this.Controls.Add(this.ID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nivelpoder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button crear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Boxid;
        private System.Windows.Forms.TextBox Boxnombre;
        private System.Windows.Forms.TextBox textBoxhistoria;
        private System.Windows.Forms.ComboBox comboBox1raza;
        private System.Windows.Forms.NumericUpDown nivelpoder;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridViewPersonajes;
        private System.Windows.Forms.Button buttoneliminar;
        private System.Windows.Forms.Button buttonbuscar;
        private System.Windows.Forms.Button buttonactu;
        private System.Windows.Forms.Button cargar;
        private System.Windows.Forms.Button prueba;
    }
}

