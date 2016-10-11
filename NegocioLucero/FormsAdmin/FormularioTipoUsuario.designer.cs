namespace NegocioLucero.FormsAdmin
{
    partial class FormularioTipoUsuario
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textoid = new System.Windows.Forms.TextBox();
            this.textonombre = new System.Windows.Forms.TextBox();
            this.textodescripcion = new System.Windows.Forms.TextBox();
            this.botonagregar = new System.Windows.Forms.Button();
            this.botoneliminar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textobuscar = new System.Windows.Forms.TextBox();
            this.botonbuscar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataGridViewtipousuario = new System.Windows.Forms.DataGridView();
            this.botonmodificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtipousuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción:";
            // 
            // textoid
            // 
            this.textoid.Location = new System.Drawing.Point(86, 28);
            this.textoid.Name = "textoid";
            this.textoid.Size = new System.Drawing.Size(100, 20);
            this.textoid.TabIndex = 3;
            // 
            // textonombre
            // 
            this.textonombre.Location = new System.Drawing.Point(86, 66);
            this.textonombre.Name = "textonombre";
            this.textonombre.Size = new System.Drawing.Size(100, 20);
            this.textonombre.TabIndex = 4;
            // 
            // textodescripcion
            // 
            this.textodescripcion.Location = new System.Drawing.Point(30, 136);
            this.textodescripcion.Multiline = true;
            this.textodescripcion.Name = "textodescripcion";
            this.textodescripcion.Size = new System.Drawing.Size(481, 91);
            this.textodescripcion.TabIndex = 5;
            // 
            // botonagregar
            // 
            this.botonagregar.Location = new System.Drawing.Point(243, 24);
            this.botonagregar.Name = "botonagregar";
            this.botonagregar.Size = new System.Drawing.Size(75, 23);
            this.botonagregar.TabIndex = 6;
            this.botonagregar.Text = "Agregar";
            this.botonagregar.UseVisualStyleBackColor = true;
            this.botonagregar.Click += new System.EventHandler(this.botonagregar_Click);
            // 
            // botoneliminar
            // 
            this.botoneliminar.Location = new System.Drawing.Point(436, 25);
            this.botoneliminar.Name = "botoneliminar";
            this.botoneliminar.Size = new System.Drawing.Size(75, 23);
            this.botoneliminar.TabIndex = 8;
            this.botoneliminar.Text = "Eliminar";
            this.botoneliminar.UseVisualStyleBackColor = true;
            this.botoneliminar.Click += new System.EventHandler(this.botoneliminar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Estado a buscar:";
            // 
            // textobuscar
            // 
            this.textobuscar.Location = new System.Drawing.Point(126, 253);
            this.textobuscar.Name = "textobuscar";
            this.textobuscar.Size = new System.Drawing.Size(100, 20);
            this.textobuscar.TabIndex = 10;
            // 
            // botonbuscar
            // 
            this.botonbuscar.Location = new System.Drawing.Point(243, 253);
            this.botonbuscar.Name = "botonbuscar";
            this.botonbuscar.Size = new System.Drawing.Size(75, 23);
            this.botonbuscar.TabIndex = 11;
            this.botonbuscar.Text = "Buscar";
            this.botonbuscar.UseVisualStyleBackColor = true;
            this.botonbuscar.Click += new System.EventHandler(this.botonbuscar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(126, 279);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Buscar por nombre";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewtipousuario
            // 
            this.dataGridViewtipousuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewtipousuario.Location = new System.Drawing.Point(30, 327);
            this.dataGridViewtipousuario.Name = "dataGridViewtipousuario";
            this.dataGridViewtipousuario.Size = new System.Drawing.Size(481, 135);
            this.dataGridViewtipousuario.TabIndex = 13;
            this.dataGridViewtipousuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewtipousuario_CellClick);
            // 
            // botonmodificar
            // 
            this.botonmodificar.Location = new System.Drawing.Point(339, 24);
            this.botonmodificar.Name = "botonmodificar";
            this.botonmodificar.Size = new System.Drawing.Size(75, 23);
            this.botonmodificar.TabIndex = 14;
            this.botonmodificar.Text = "Modificar";
            this.botonmodificar.UseVisualStyleBackColor = true;
            this.botonmodificar.Click += new System.EventHandler(this.botonmodificar_Click);
            // 
            // FormularioTipoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(544, 474);
            this.Controls.Add(this.botonmodificar);
            this.Controls.Add(this.dataGridViewtipousuario);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.botonbuscar);
            this.Controls.Add(this.textobuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.botoneliminar);
            this.Controls.Add(this.botonagregar);
            this.Controls.Add(this.textodescripcion);
            this.Controls.Add(this.textonombre);
            this.Controls.Add(this.textoid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormularioTipoUsuario";
            this.Text = "Formulario Tipo de Usuario";
            this.Load += new System.EventHandler(this.FormularioTipoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtipousuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textoid;
        private System.Windows.Forms.TextBox textonombre;
        private System.Windows.Forms.TextBox textodescripcion;
        private System.Windows.Forms.Button botonagregar;
        private System.Windows.Forms.Button botoneliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textobuscar;
        private System.Windows.Forms.Button botonbuscar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dataGridViewtipousuario;
        private System.Windows.Forms.Button botonmodificar;
    }
}