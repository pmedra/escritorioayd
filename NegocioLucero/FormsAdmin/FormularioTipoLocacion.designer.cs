namespace NegocioLucero.FormsAdmin
{
    partial class FormularioTipoLocacion
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
            this.textoid = new System.Windows.Forms.TextBox();
            this.textonombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textobuscar = new System.Windows.Forms.TextBox();
            this.botonbuscar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataGridViewtipolocacion = new System.Windows.Forms.DataGridView();
            this.botonagregar = new System.Windows.Forms.Button();
            this.botoneliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtipolocacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Locacin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // textoid
            // 
            this.textoid.Location = new System.Drawing.Point(124, 36);
            this.textoid.Name = "textoid";
            this.textoid.Size = new System.Drawing.Size(100, 20);
            this.textoid.TabIndex = 2;
            // 
            // textonombre
            // 
            this.textonombre.Location = new System.Drawing.Point(124, 62);
            this.textonombre.Name = "textonombre";
            this.textonombre.Size = new System.Drawing.Size(100, 20);
            this.textonombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Locación a buscar:";
            // 
            // textobuscar
            // 
            this.textobuscar.Location = new System.Drawing.Point(124, 100);
            this.textobuscar.Name = "textobuscar";
            this.textobuscar.Size = new System.Drawing.Size(100, 20);
            this.textobuscar.TabIndex = 5;
            // 
            // botonbuscar
            // 
            this.botonbuscar.Location = new System.Drawing.Point(240, 100);
            this.botonbuscar.Name = "botonbuscar";
            this.botonbuscar.Size = new System.Drawing.Size(75, 23);
            this.botonbuscar.TabIndex = 6;
            this.botonbuscar.Text = "Buscar";
            this.botonbuscar.UseVisualStyleBackColor = true;
            this.botonbuscar.Click += new System.EventHandler(this.botonbuscar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(124, 138);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Buscar por nombre";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewtipolocacion
            // 
            this.dataGridViewtipolocacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewtipolocacion.Location = new System.Drawing.Point(22, 171);
            this.dataGridViewtipolocacion.Name = "dataGridViewtipolocacion";
            this.dataGridViewtipolocacion.Size = new System.Drawing.Size(247, 142);
            this.dataGridViewtipolocacion.TabIndex = 8;
            this.dataGridViewtipolocacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewtipolocacion_CellClick);
            // 
            // botonagregar
            // 
            this.botonagregar.Location = new System.Drawing.Point(299, 196);
            this.botonagregar.Name = "botonagregar";
            this.botonagregar.Size = new System.Drawing.Size(75, 23);
            this.botonagregar.TabIndex = 9;
            this.botonagregar.Text = "Agregar";
            this.botonagregar.UseVisualStyleBackColor = true;
            this.botonagregar.Click += new System.EventHandler(this.botonagregar_Click);
            // 
            // botoneliminar
            // 
            this.botoneliminar.Location = new System.Drawing.Point(299, 247);
            this.botoneliminar.Name = "botoneliminar";
            this.botoneliminar.Size = new System.Drawing.Size(75, 23);
            this.botoneliminar.TabIndex = 11;
            this.botoneliminar.Text = "Eliminar";
            this.botoneliminar.UseVisualStyleBackColor = true;
            this.botoneliminar.Click += new System.EventHandler(this.botoneliminar_Click);
            // 
            // FormularioTipoLocacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(406, 325);
            this.Controls.Add(this.botoneliminar);
            this.Controls.Add(this.botonagregar);
            this.Controls.Add(this.dataGridViewtipolocacion);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.botonbuscar);
            this.Controls.Add(this.textobuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textonombre);
            this.Controls.Add(this.textoid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormularioTipoLocacion";
            this.Text = "Formulario Tipo de Locación";
            this.Load += new System.EventHandler(this.FormularioTipoLocacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtipolocacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoid;
        private System.Windows.Forms.TextBox textonombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textobuscar;
        private System.Windows.Forms.Button botonbuscar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dataGridViewtipolocacion;
        private System.Windows.Forms.Button botonagregar;
        private System.Windows.Forms.Button botoneliminar;
    }
}