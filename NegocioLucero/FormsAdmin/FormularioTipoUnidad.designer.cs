namespace NegocioLucero.FormsAdmin
{
    partial class FormularioTipoUnidad
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
            this.textonombre = new System.Windows.Forms.TextBox();
            this.botonagregar = new System.Windows.Forms.Button();
            this.botoneliminar = new System.Windows.Forms.Button();
            this.dataGridViewtipounidad = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textobuscar = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.botonbuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textoid = new System.Windows.Forms.TextBox();
            this.botonmodificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtipounidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // textonombre
            // 
            this.textonombre.Location = new System.Drawing.Point(108, 64);
            this.textonombre.Name = "textonombre";
            this.textonombre.Size = new System.Drawing.Size(100, 20);
            this.textonombre.TabIndex = 1;
            // 
            // botonagregar
            // 
            this.botonagregar.Location = new System.Drawing.Point(307, 159);
            this.botonagregar.Name = "botonagregar";
            this.botonagregar.Size = new System.Drawing.Size(75, 23);
            this.botonagregar.TabIndex = 2;
            this.botonagregar.Text = "Agregar";
            this.botonagregar.UseVisualStyleBackColor = true;
            this.botonagregar.Click += new System.EventHandler(this.botonagregar_Click);
            // 
            // botoneliminar
            // 
            this.botoneliminar.Location = new System.Drawing.Point(307, 241);
            this.botoneliminar.Name = "botoneliminar";
            this.botoneliminar.Size = new System.Drawing.Size(75, 23);
            this.botoneliminar.TabIndex = 4;
            this.botoneliminar.Text = "Eliminar";
            this.botoneliminar.UseVisualStyleBackColor = true;
            this.botoneliminar.Click += new System.EventHandler(this.botoneliminar_Click);
            // 
            // dataGridViewtipounidad
            // 
            this.dataGridViewtipounidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewtipounidad.Location = new System.Drawing.Point(29, 159);
            this.dataGridViewtipounidad.Name = "dataGridViewtipounidad";
            this.dataGridViewtipounidad.Size = new System.Drawing.Size(237, 150);
            this.dataGridViewtipounidad.TabIndex = 5;
            this.dataGridViewtipounidad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewtipounidad_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Unidad a buscar:";
            // 
            // textobuscar
            // 
            this.textobuscar.Location = new System.Drawing.Point(108, 101);
            this.textobuscar.Name = "textobuscar";
            this.textobuscar.Size = new System.Drawing.Size(100, 20);
            this.textobuscar.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(108, 136);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Buscar por nombre";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // botonbuscar
            // 
            this.botonbuscar.Location = new System.Drawing.Point(219, 98);
            this.botonbuscar.Name = "botonbuscar";
            this.botonbuscar.Size = new System.Drawing.Size(75, 23);
            this.botonbuscar.TabIndex = 9;
            this.botonbuscar.Text = "Buscar";
            this.botonbuscar.UseVisualStyleBackColor = true;
            this.botonbuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID unidad:";
            // 
            // textoid
            // 
            this.textoid.Location = new System.Drawing.Point(108, 35);
            this.textoid.Name = "textoid";
            this.textoid.Size = new System.Drawing.Size(100, 20);
            this.textoid.TabIndex = 11;
            // 
            // botonmodificar
            // 
            this.botonmodificar.Location = new System.Drawing.Point(307, 201);
            this.botonmodificar.Name = "botonmodificar";
            this.botonmodificar.Size = new System.Drawing.Size(75, 23);
            this.botonmodificar.TabIndex = 3;
            this.botonmodificar.Text = "Modificar";
            this.botonmodificar.UseVisualStyleBackColor = true;
            this.botonmodificar.Click += new System.EventHandler(this.botonmodificar_Click);
            // 
            // FormularioTipoUnidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(401, 321);
            this.Controls.Add(this.textoid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.botonbuscar);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textobuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewtipounidad);
            this.Controls.Add(this.botoneliminar);
            this.Controls.Add(this.botonmodificar);
            this.Controls.Add(this.botonagregar);
            this.Controls.Add(this.textonombre);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormularioTipoUnidad";
            this.Text = "Formulario Tipo de Unidad";
            this.Load += new System.EventHandler(this.FormularioTipoUnidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtipounidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textonombre;
        private System.Windows.Forms.Button botonagregar;
        private System.Windows.Forms.Button botoneliminar;
        private System.Windows.Forms.DataGridView dataGridViewtipounidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textobuscar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button botonbuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textoid;
        private System.Windows.Forms.Button botonmodificar;
    }
}