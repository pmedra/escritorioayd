namespace NegocioLucero.FormsAdmin
{
    partial class FormularioUsuarios
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
            this.botonbuscar = new System.Windows.Forms.Button();
            this.botonmodificar = new System.Windows.Forms.Button();
            this.botonagregar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textonombre = new System.Windows.Forms.TextBox();
            this.textocontrasena = new System.Windows.Forms.TextBox();
            this.textocontrasena2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.botoneliminar = new System.Windows.Forms.Button();
            this.textobuscar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // botonbuscar
            // 
            this.botonbuscar.Location = new System.Drawing.Point(218, 257);
            this.botonbuscar.Name = "botonbuscar";
            this.botonbuscar.Size = new System.Drawing.Size(75, 23);
            this.botonbuscar.TabIndex = 0;
            this.botonbuscar.Text = "Buscar";
            this.botonbuscar.UseVisualStyleBackColor = true;
            this.botonbuscar.Click += new System.EventHandler(this.botonbuscar_Click);
            // 
            // botonmodificar
            // 
            this.botonmodificar.Location = new System.Drawing.Point(539, 67);
            this.botonmodificar.Name = "botonmodificar";
            this.botonmodificar.Size = new System.Drawing.Size(75, 23);
            this.botonmodificar.TabIndex = 1;
            this.botonmodificar.Text = "Modificar";
            this.botonmodificar.UseVisualStyleBackColor = true;
            this.botonmodificar.Click += new System.EventHandler(this.botonmodificar_Click);
            // 
            // botonagregar
            // 
            this.botonagregar.Location = new System.Drawing.Point(443, 67);
            this.botonagregar.Name = "botonagregar";
            this.botonagregar.Size = new System.Drawing.Size(75, 23);
            this.botonagregar.TabIndex = 2;
            this.botonagregar.Text = "Agregar";
            this.botonagregar.UseVisualStyleBackColor = true;
            this.botonagregar.Click += new System.EventHandler(this.botonagregar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(172, 168);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Activo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textonombre
            // 
            this.textonombre.Location = new System.Drawing.Point(172, 64);
            this.textonombre.Name = "textonombre";
            this.textonombre.Size = new System.Drawing.Size(100, 20);
            this.textonombre.TabIndex = 4;
            // 
            // textocontrasena
            // 
            this.textocontrasena.Location = new System.Drawing.Point(172, 101);
            this.textocontrasena.Name = "textocontrasena";
            this.textocontrasena.PasswordChar = '*';
            this.textocontrasena.Size = new System.Drawing.Size(100, 20);
            this.textocontrasena.TabIndex = 5;
            // 
            // textocontrasena2
            // 
            this.textocontrasena2.Location = new System.Drawing.Point(172, 142);
            this.textocontrasena2.Name = "textocontrasena2";
            this.textocontrasena2.PasswordChar = '*';
            this.textocontrasena2.Size = new System.Drawing.Size(100, 20);
            this.textocontrasena2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Confirmar Contraseña:";
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Location = new System.Drawing.Point(22, 313);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.Size = new System.Drawing.Size(728, 201);
            this.dataGridViewUser.TabIndex = 10;
            this.dataGridViewUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUser_CellClick);
            // 
            // botoneliminar
            // 
            this.botoneliminar.Location = new System.Drawing.Point(631, 67);
            this.botoneliminar.Name = "botoneliminar";
            this.botoneliminar.Size = new System.Drawing.Size(75, 23);
            this.botoneliminar.TabIndex = 12;
            this.botoneliminar.Text = "Eliminar";
            this.botoneliminar.UseVisualStyleBackColor = true;
            this.botoneliminar.Click += new System.EventHandler(this.botoneliminar_Click);
            // 
            // textobuscar
            // 
            this.textobuscar.Location = new System.Drawing.Point(112, 259);
            this.textobuscar.Name = "textobuscar";
            this.textobuscar.Size = new System.Drawing.Size(100, 20);
            this.textobuscar.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Usuario a buscar:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Administrador",
            "Usuario del sistema"});
            this.comboBox1.Location = new System.Drawing.Point(172, 204);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tipo de usuario:";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(112, 290);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(115, 17);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Buscar por nombre";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // FormularioUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(774, 526);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textobuscar);
            this.Controls.Add(this.botoneliminar);
            this.Controls.Add(this.dataGridViewUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textocontrasena2);
            this.Controls.Add(this.textocontrasena);
            this.Controls.Add(this.textonombre);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.botonagregar);
            this.Controls.Add(this.botonmodificar);
            this.Controls.Add(this.botonbuscar);
            this.MaximizeBox = false;
            this.Name = "FormularioUsuarios";
            this.Text = "Formulario control de Usuarios";
            this.Load += new System.EventHandler(this.FormularioUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonbuscar;
        private System.Windows.Forms.Button botonmodificar;
        private System.Windows.Forms.Button botonagregar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textonombre;
        private System.Windows.Forms.TextBox textocontrasena;
        private System.Windows.Forms.TextBox textocontrasena2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.Button botoneliminar;
        private System.Windows.Forms.TextBox textobuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}