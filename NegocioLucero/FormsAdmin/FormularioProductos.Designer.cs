namespace NegocioLucero.FormsAdmin
{
    partial class Formularioproductos
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
            this.btnagregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombreprod = new System.Windows.Forms.TextBox();
            this.cbxcategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pruebaDataSet = new NegocioLucero.pruebaDataSet();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.productoTableAdapter = new NegocioLucero.pruebaDataSetTableAdapters.productoTableAdapter();
            this.Unidad = new System.Windows.Forms.Label();
            this.cbxUnidad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtprecompra = new System.Windows.Forms.TextBox();
            this.txtpreventa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcanttienda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.brnmodificar = new System.Windows.Forms.Button();
            this.btndardebaja = new System.Windows.Forms.Button();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.cbxestadoprod = new System.Windows.Forms.ComboBox();
            this.txtcantbodega = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgridproductos = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxlocacion = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridproductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(20, 171);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(88, 23);
            this.btnagregar.TabIndex = 8;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre:";
            // 
            // txtnombreprod
            // 
            this.txtnombreprod.Location = new System.Drawing.Point(71, 28);
            this.txtnombreprod.Name = "txtnombreprod";
            this.txtnombreprod.Size = new System.Drawing.Size(857, 20);
            this.txtnombreprod.TabIndex = 1;
            // 
            // cbxcategoria
            // 
            this.cbxcategoria.FormattingEnabled = true;
            this.cbxcategoria.Location = new System.Drawing.Point(70, 80);
            this.cbxcategoria.Name = "cbxcategoria";
            this.cbxcategoria.Size = new System.Drawing.Size(121, 21);
            this.cbxcategoria.TabIndex = 6;
            this.cbxcategoria.SelectedIndexChanged += new System.EventHandler(this.cbxcategoria_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Categoria:";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "producto";
            this.productoBindingSource.DataSource = this.pruebaDataSet;
            // 
            // pruebaDataSet
            // 
            this.pruebaDataSet.DataSetName = "pruebaDataSet";
            this.pruebaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1215, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "fillByToolStrip";
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // Unidad
            // 
            this.Unidad.AutoSize = true;
            this.Unidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unidad.Location = new System.Drawing.Point(211, 83);
            this.Unidad.Name = "Unidad";
            this.Unidad.Size = new System.Drawing.Size(53, 15);
            this.Unidad.TabIndex = 8;
            this.Unidad.Text = "Unidad: ";
            // 
            // cbxUnidad
            // 
            this.cbxUnidad.FormattingEnabled = true;
            this.cbxUnidad.Location = new System.Drawing.Point(264, 82);
            this.cbxUnidad.Name = "cbxUnidad";
            this.cbxUnidad.Size = new System.Drawing.Size(121, 21);
            this.cbxUnidad.TabIndex = 7;
            this.cbxUnidad.SelectedIndexChanged += new System.EventHandler(this.cbxUnidad_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Precio Compra:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(853, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Imagen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtprecompra
            // 
            this.txtprecompra.Location = new System.Drawing.Point(107, 54);
            this.txtprecompra.Name = "txtprecompra";
            this.txtprecompra.Size = new System.Drawing.Size(84, 20);
            this.txtprecompra.TabIndex = 2;
            this.txtprecompra.Text = "0";
            this.txtprecompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // txtpreventa
            // 
            this.txtpreventa.Location = new System.Drawing.Point(303, 56);
            this.txtpreventa.Name = "txtpreventa";
            this.txtpreventa.Size = new System.Drawing.Size(82, 20);
            this.txtpreventa.TabIndex = 3;
            this.txtpreventa.Text = "0";
            this.txtpreventa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(211, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Precio Venta:";
            // 
            // txtcanttienda
            // 
            this.txtcanttienda.Location = new System.Drawing.Point(529, 55);
            this.txtcanttienda.Name = "txtcanttienda";
            this.txtcanttienda.Size = new System.Drawing.Size(84, 20);
            this.txtcanttienda.TabIndex = 4;
            this.txtcanttienda.Text = "0";
            this.txtcanttienda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(416, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Cantidad en tienda:";
            // 
            // brnmodificar
            // 
            this.brnmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnmodificar.Location = new System.Drawing.Point(115, 170);
            this.brnmodificar.Name = "brnmodificar";
            this.brnmodificar.Size = new System.Drawing.Size(88, 23);
            this.brnmodificar.TabIndex = 9;
            this.brnmodificar.Text = "Modificar";
            this.brnmodificar.UseVisualStyleBackColor = true;
            this.brnmodificar.Click += new System.EventHandler(this.brnmodificar_Click);
            // 
            // btndardebaja
            // 
            this.btndardebaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndardebaja.Location = new System.Drawing.Point(214, 171);
            this.btndardebaja.Name = "btndardebaja";
            this.btndardebaja.Size = new System.Drawing.Size(88, 23);
            this.btndardebaja.TabIndex = 10;
            this.btndardebaja.Text = "Dar de baja";
            this.btndardebaja.UseVisualStyleBackColor = true;
            this.btndardebaja.Click += new System.EventHandler(this.btndardebaja_Click);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(308, 179);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(44, 15);
            this.lblfecha.TabIndex = 21;
            this.lblfecha.Text = "Fecha:";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.Location = new System.Drawing.Point(416, 79);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(48, 15);
            this.lblestado.TabIndex = 22;
            this.lblestado.Text = "Estado:";
            // 
            // cbxestadoprod
            // 
            this.cbxestadoprod.FormattingEnabled = true;
            this.cbxestadoprod.Location = new System.Drawing.Point(492, 78);
            this.cbxestadoprod.Name = "cbxestadoprod";
            this.cbxestadoprod.Size = new System.Drawing.Size(121, 21);
            this.cbxestadoprod.TabIndex = 8;
            this.cbxestadoprod.SelectedIndexChanged += new System.EventHandler(this.cbxestadoprod_SelectedIndexChanged);
            // 
            // txtcantbodega
            // 
            this.txtcantbodega.Location = new System.Drawing.Point(765, 55);
            this.txtcantbodega.Name = "txtcantbodega";
            this.txtcantbodega.Size = new System.Drawing.Size(82, 20);
            this.txtcantbodega.TabIndex = 5;
            this.txtcantbodega.Text = "0";
            this.txtcantbodega.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantbodega_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(641, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Cantidaden bodega:";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(88, 107);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(297, 57);
            this.txtdescripcion.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "Descripcion:";
            // 
            // dtgridproductos
            // 
            this.dtgridproductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgridproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridproductos.Location = new System.Drawing.Point(21, 200);
            this.dtgridproductos.Name = "dtgridproductos";
            this.dtgridproductos.Size = new System.Drawing.Size(1165, 320);
            this.dtgridproductos.TabIndex = 5;
            this.dtgridproductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridproductos_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(650, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "Locacion:";
            // 
            // cbxlocacion
            // 
            this.cbxlocacion.Enabled = false;
            this.cbxlocacion.FormattingEnabled = true;
            this.cbxlocacion.Location = new System.Drawing.Point(726, 78);
            this.cbxlocacion.Name = "cbxlocacion";
            this.cbxlocacion.Size = new System.Drawing.Size(121, 21);
            this.cbxlocacion.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(969, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 152);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(471, 108);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(457, 20);
            this.txtbusqueda.TabIndex = 30;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            this.txtbusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbusqueda_KeyUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(416, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Buscar:";
            // 
            // Formularioproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 532);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxlocacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtcantbodega);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.cbxestadoprod);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btndardebaja);
            this.Controls.Add(this.brnmodificar);
            this.Controls.Add(this.txtcanttienda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtpreventa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtprecompra);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Unidad);
            this.Controls.Add(this.cbxUnidad);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dtgridproductos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxcategoria);
            this.Controls.Add(this.txtnombreprod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnagregar);
            this.Name = "Formularioproductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioProductos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Formularioproductos_FormClosed);
            this.Load += new System.EventHandler(this.FormularioProductos_Load);
            this.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridproductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombreprod;
        private System.Windows.Forms.ComboBox cbxcategoria;
        private System.Windows.Forms.Label label2;
        private pruebaDataSet pruebaDataSet;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private pruebaDataSetTableAdapters.productoTableAdapter productoTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label Unidad;
        private System.Windows.Forms.ComboBox cbxUnidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtprecompra;
        private System.Windows.Forms.TextBox txtpreventa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcanttienda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button brnmodificar;
        private System.Windows.Forms.Button btndardebaja;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.ComboBox cbxestadoprod;
        private System.Windows.Forms.TextBox txtcantbodega;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtgridproductos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxlocacion;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Label label9;
    }
}