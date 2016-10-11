using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NegocioLucero.FormsAdmin
{
    public partial class Formularioproductos : Form
    {
        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        DataSet resultados = new DataSet();
        DataView mifiltro=new DataView();

        OperacionesFormulario operacionesformulario;
        MySqlConnection conexion;
        int indicecategoria = 0;
        int indicetipounidad = 0;
        int indiceestadoprod = 0;
        int indicelocacion = 0;
        String Nombre = "";
        String descripcion = "";
        Double preciocompra = 00;
        Double precioventa = 00;
        int cantidadtienda = 0;
        int cantidadbodega = 0;
        String rutaimagen = "";
        String stringcategoria = "";
        String stringunidad = "";
        String stringlocacion = "";
        String stringestado = "";
        int idproducto = 0;
        int cantidad = 0;
        DataGridView gridprincipal;
        public Formularioproductos(OperacionesFormulario operacionesformulario, MySqlConnection conexion,DataGridView gridproductosprincipal)
        {
            InitializeComponent();
            this.operacionesformulario = operacionesformulario;
            this.conexion = conexion;
            this.gridprincipal = gridproductosprincipal;
            llenarcategorias();
            llenartipounidad();
            llenarlocacion();
            llenarestadoproducto();
           

            //   cbxcategoria.SelectedIndex = 0;
        }

        private void FormularioProductos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pruebaDataSet.producto' table. You can move, or remove it, as needed.

            lblfecha.Text = DateTime.Now.ToString("G");
            llenargridProductos();
            dt = (DataTable)dtgridproductos.DataSource;
            this.mifiltro = dt.DefaultView;
            this.dtgridproductos.DataSource = mifiltro;
            dtgridproductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }



        public void llenarcategorias()
        {
            // using (conexion)
            //{
            string query = "SELECT idcategoria,Nombre from Categoria";

            operacionesformulario.llenarcombobox(cbxcategoria, query, conexion, "idcategoria", "Nombre");
            /*                MySqlCommand cmd = new MySqlCommand(query, conexion);

                            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da1.Fill(dt);

                           cbxcategoria.ValueMember = "idcategoria";
                            cbxcategoria.DisplayMember = "Nombre";
                            cbxcategoria.DataSource = dt;
                          */
            //  }


        }

        public void llenartipounidad()
        {
            string query = "SELECT idtipounidad,Nombre from TipoUnidad";

            operacionesformulario.llenarcombobox(cbxUnidad, query, conexion, "idtipoUnidad", "Nombre");

        }

        public void llenarestadoproducto()
        {
            string query = "SELECT idEstadoProducto,Nombre from EstadoProducto";

            operacionesformulario.llenarcombobox(cbxestadoprod, query, conexion, "idEstadoProducto", "Nombre");

        }

        public void llenarlocacion()
        {
            string query = "SELECT idTipoLocacion,Nombre from TipoLocacion";

            operacionesformulario.llenarcombobox(cbxlocacion, query, conexion, "idTipoLocacion", "Nombre");
        }

        public void llenargridProductos()
        {
            String query =
"Select P.idProducto,P.Nombre,P.Descripcion,P.PrecioCompra,P.PrecioVenta,C.Nombre AS 'Categoria',TL.Nombre AS 'Locacion',PL.Cantidad AS 'Cantidad',TU.Nombre as 'Unidad',EP.Nombre as 'Estado Producto', P.imagen as 'Imagen' "
+ " From Producto P, Categoria C, TipoUnidad TU, EstadoProducto EP, TipoLocacion TL, ProductoLocacion PL "
+ " where P.idcategoria=C.idcategoria AND P.idtipounidad=TU.idtipounidad AND P.idestadoproducto=EP.idestadoproducto "
    + " AND P.idProducto=PL.Producto_idProducto AND TL.idtipoLocacion=PL.TipoLocacion_idTipoLocacion AND EP.idestadoproducto!=3";
            operacionesformulario.llenargrid(dtgridproductos, query, conexion);

        }

        public void llenargridPrincipal()
        {
            conexion.Close();
            String query =
"Select P.idProducto,P.Nombre,P.Descripcion,P.PrecioVenta,C.Nombre AS 'Categoria',TL.Nombre AS 'Locacion',PL.Cantidad AS 'Cantidad',TU.Nombre as 'Unidad',EP.Nombre as 'Estado Producto', P.imagen as 'Imagen' "
+ " From Producto P, Categoria C, TipoUnidad TU, EstadoProducto EP, TipoLocacion TL, ProductoLocacion PL "
+ " where P.idcategoria=C.idcategoria AND P.idtipounidad=TU.idtipounidad AND P.idestadoproducto=EP.idestadoproducto "
    + " AND P.idProducto=PL.Producto_idProducto AND TL.idtipoLocacion=PL.TipoLocacion_idTipoLocacion  AND PL.TipoLocacion_idTipoLocacion=1  AND PL.Cantidad>0 AND EP.idestadoproducto!=3 ";

            operacionesformulario.llenargrid(this.gridprincipal, query, conexion);

        }

        private void cbxcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

            int selectedIndex = cbxcategoria.SelectedIndex;
            Object selectedItem = cbxcategoria.SelectedItem;
            // MessageBox.Show("Selected Item Text: " + selectedItem.ToString() + "\n" +
            //        "Index: " + selectedIndex.ToString());
            Object selectedValue = cbxcategoria.SelectedValue;
            indicecategoria = Convert.ToInt32(selectedValue);

            //  MessageBox.Show("selected value:" + selectedValue.ToString());
        }

        private void cbxUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {

            int selectedIndex = cbxUnidad.SelectedIndex;
            Object selectedItem = cbxUnidad.SelectedItem;
            //   MessageBox.Show("Selected Item Text: " + selectedItem.ToString() + "\n" +
            //          "Index: " + selectedIndex.ToString());
            Object selectedValue = cbxUnidad.SelectedValue;
            indicetipounidad = Convert.ToInt32(selectedValue);

            //MessageBox.Show("selected value:" + selectedValue.ToString());
        }

        private void cbxestadoprod_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbxestadoprod.SelectedIndex;
            Object selectedItem = cbxestadoprod.SelectedItem;
            //   MessageBox.Show("Selected Item Text: " + selectedItem.ToString() + "\n" +
            //          "Index: " + selectedIndex.ToString());
            Object selectedValue = cbxestadoprod.SelectedValue;
            indiceestadoprod = Convert.ToInt32(selectedValue);

            //MessageBox.Show("selected value:" + selectedValue.ToString());
        }


        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            operacionesformulario.validarEnteros((TextBox)sender);
        }
        private void txtcantbodega_KeyPress(object sender, KeyPressEventArgs e)
        {
            operacionesformulario.validarEnteros((TextBox)sender);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            operacionesformulario.validarDecimales((TextBox)sender);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            operacionesformulario.validarDecimales((TextBox)sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rutaimagen = "";
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Archivos de Imagen|*.jpg";
            BuscarImagen.FileName = "";
            BuscarImagen.InitialDirectory = "C:\\";
            //   BuscarImagen.FileName=te

            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                String filename = BuscarImagen.FileName;
                rutaimagen = BuscarImagen.FileName;
                pictureBox1.ImageLocation = filename;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                //    MessageBox.Show(rutaimagen);
            }

        }



        private void btnagregar_Click(object sender, EventArgs e)
        {
            Nombre = txtnombreprod.Text;
            descripcion = txtdescripcion.Text;
            preciocompra = Convert.ToDouble(txtprecompra.Text);
            precioventa = Convert.ToDouble(txtpreventa.Text);
            cantidadtienda = Convert.ToInt32(txtcanttienda.Text);
            cantidadbodega = Convert.ToInt32(txtcantbodega.Text);

            try
            {
                if (Nombre.Equals("") || txtprecompra.Text.Equals("") || txtpreventa.Text.Equals("") || txtcanttienda.Text.Equals("") || txtcantbodega.Text.Equals(""))
                {
                    MessageBox.Show("Debe ingresar todos los datos requeridos");
                }
                else
                {
                    String query = "insert into Producto(nombre,descripcion,imagen,fechaingreso,Preciocompra,Precioventa,idCategoria,idtipounidad,idestadoproducto) values (@nombre,@descripcion,@imagen,Now(),@Preciocompra,@Precioventa,@idCategoria,@idtipounidad,@idestadoproducto)";

                    MySqlCommand cmd = new MySqlCommand();
                    //MySqlDataReader reader;

                    cmd.CommandText = query;
                    // cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    cmd.Parameters.AddWithValue("nombre", Nombre);
                    cmd.Parameters.AddWithValue("descripcion", descripcion);
                    cmd.Parameters.AddWithValue("imagen", rutaimagen);
                    cmd.Parameters.AddWithValue("Preciocompra", preciocompra);
                    cmd.Parameters.AddWithValue("Precioventa", precioventa);
                    cmd.Parameters.AddWithValue("idCategoria", indicecategoria);
                    cmd.Parameters.AddWithValue("idtipounidad", indicetipounidad);
                    cmd.Parameters.AddWithValue("idestadoproducto", indiceestadoprod);

                    operacionesformulario.insertar(cmd, this.conexion);
                    insertarproductolocacion();
                    llenargridProductos();
                    llenargridPrincipal();
                    limpiarvariablesycampos();
                    //  llenarcategorias();

                }
            }

            catch (Exception es)
            {
                MessageBox.Show(es.ToString());
            }
        }

        public void limpiarvariablesycampos()
        {
            //   indicecategoria = 0;
            //indicetipounidad = 0;
            //indiceestadoprod = 0;
            Nombre = "";
            descripcion = "";
            preciocompra = 00;
            precioventa = 00;
            cantidadtienda = 0;
            cantidadbodega = 0;
            rutaimagen = "";
            pictureBox1.ImageLocation = rutaimagen;

            txtnombreprod.Text = Nombre;
            txtdescripcion.Text = descripcion;
            txtprecompra.Text = preciocompra.ToString();
            txtpreventa.Text = precioventa.ToString();
            txtcanttienda.Text = cantidadtienda.ToString();
            txtcantbodega.Text = cantidadbodega.ToString();
        }

        public void insertarproductolocacion()
        {

            //  usuario = txtusuario.Text;
            //   password = txtpassword.Text;

            MySqlCommand cmd = new MySqlCommand();
            //MySqlDataReader reader;

            cmd.CommandText = "select * from Producto order by idProducto desc limit 1";
            // cmd.CommandType = CommandType.StoredProcedure;
            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }
            cmd.Connection = conexion;

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {

                int idproducto = 0;

                while (reader.Read())
                {

                    idproducto = (int)reader.GetValue(0);

                }
                reader.Close();
                if (idproducto != 0)
                {
                    try
                    {
                        if (Nombre.Equals("") || txtprecompra.Text.Equals("") || txtpreventa.Text.Equals("") || txtcanttienda.Text.Equals("") || txtcantbodega.Text.Equals(""))
                        {
                            MessageBox.Show("Debe ingresar todos los datos requeridos");
                        }
                        else
                        {
                            String query = "insert into ProductoLocacion(Producto_idProducto,TipoLocacion_idTipoLocacion,cantidad) values (@idProducto,@idTipoLocacion,@Cantidad)";

                            MySqlCommand cmd1 = new MySqlCommand();
                            //MySqlDataReader reader;

                            cmd1.CommandText = query;
                            // cmd.CommandType = CommandType.StoredProcedure;
                            cmd1.Connection = conexion;
                            cmd1.Parameters.AddWithValue("idProducto", idproducto);
                            cmd1.Parameters.AddWithValue("idTipoLocacion", 1);
                            cmd1.Parameters.AddWithValue("Cantidad", cantidadtienda);
                            operacionesformulario.insertar(cmd1, this.conexion);

                            cmd1 = new MySqlCommand();
                            cmd1.CommandText = query;
                            cmd1.Connection = conexion;
                            cmd1.Parameters.AddWithValue("idProducto", idproducto);
                            cmd1.Parameters.AddWithValue("idTipoLocacion", 2);
                            cmd1.Parameters.AddWithValue("Cantidad", cantidadbodega);
                            operacionesformulario.insertar(cmd1, this.conexion);


                        }
                    }

                    catch (Exception es)
                    {
                        MessageBox.Show(es.ToString());
                    }

                }
            }
        }

        



        private void dtgridproductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = 0;
                 rowIndex = e.RowIndex;
                 if (rowIndex!=-1)
                 {
                     DataGridViewRow row = dtgridproductos.Rows[rowIndex];
                     idproducto = Convert.ToInt32(row.Cells[0].Value.ToString());
                     Nombre = row.Cells[1].Value.ToString();
                     descripcion = row.Cells[2].Value.ToString();
                     preciocompra = Convert.ToDouble(row.Cells[3].Value.ToString());
                     precioventa = Convert.ToDouble(row.Cells[4].Value.ToString());
                     stringcategoria = row.Cells[5].Value.ToString();
                     stringlocacion = row.Cells[6].Value.ToString();
                     cantidad = Convert.ToInt32(row.Cells[7].Value.ToString());
                     stringunidad = row.Cells[8].Value.ToString();
                     stringestado = row.Cells[9].Value.ToString();
                     rutaimagen = row.Cells[10].Value.ToString();
                     pictureBox1.ImageLocation = rutaimagen;
                     pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                     cbxcategoria.SelectedIndex = cbxcategoria.FindStringExact(stringcategoria);
                     cbxUnidad.SelectedIndex = cbxUnidad.FindStringExact(stringunidad);
                     cbxestadoprod.SelectedIndex = cbxestadoprod.FindStringExact(stringestado);
                     cbxlocacion.SelectedIndex = cbxlocacion.FindStringExact(stringlocacion);

                     if (stringlocacion.Equals("Tienda"))
                     {
                         txtcantbodega.Text = "0";
                         txtcanttienda.Text = cantidad.ToString();
                     }
                     else if (stringlocacion.Equals("Bodega"))
                     {
                         txtcanttienda.Text = "0";
                         txtcantbodega.Text = cantidad.ToString();
                     }

                     // Object selectedvalue =
                     //  MessageBox.Show(cbxcategoria.SelectedValue.ToString());

                     txtnombreprod.Text = Nombre;
                     txtdescripcion.Text = descripcion;
                     txtprecompra.Text = preciocompra.ToString();
                     txtpreventa.Text = precioventa.ToString();
                     // txtcanttienda.Text = cantidadtienda.ToString();
                     // txtcantbodega.Text = cantidadbodega.ToString();



                     //MessageBox.Show(indice.ToString() + nombre + descripcion);
                     // textBox5.Text = dataGridView1.Rows[1].Cells[1].Value.ToString();// row.Cells[1].Value;
                     //MessageBox.Show(DtgridCategoria.Rows[rowIndex].Cells[2].Value.ToString());
                 }
            
            }
            catch (Exception ex)
            {

                MessageBox.Show(e.RowIndex.ToString()+ "ssa"+  ex.ToString());
            }
           
        }

        public void agregarcolumnas(){


    }

        private void brnmodificar_Click(object sender, EventArgs e)
        {
            Nombre = txtnombreprod.Text;
            descripcion = txtdescripcion.Text;
            preciocompra = Convert.ToDouble(txtprecompra.Text);
            precioventa = Convert.ToDouble(txtpreventa.Text);
            cantidadtienda = Convert.ToInt32(txtcanttienda.Text);
            cantidadbodega = Convert.ToInt32(txtcantbodega.Text);
            indicelocacion = Convert.ToInt32(cbxlocacion.SelectedValue.ToString());

            try
            {
                if (Nombre.Equals("") || txtprecompra.Text.Equals("") || txtpreventa.Text.Equals("") || txtcanttienda.Text.Equals("") || txtcantbodega.Text.Equals(""))
                {
                    MessageBox.Show("Debe ingresar todos los datos requeridos");
                }
                else
                {
                    String query = "Update Producto Set nombre=@nombre, descripcion=@descripcion, imagen=@imagen,Preciocompra=@Preciocompra, Precioventa=@Precioventa, idCategoria=@idCategoria, idtipounidad=@idtipounidad, idestadoproducto=@idestadoproducto "
                    + "where idproducto=@idproducto";

                    MySqlCommand cmd = new MySqlCommand();
                    //MySqlDataReader reader;

                    cmd.CommandText = query;
                    // cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    cmd.Parameters.AddWithValue("idproducto", idproducto);
                    cmd.Parameters.AddWithValue("nombre", Nombre);
                    cmd.Parameters.AddWithValue("descripcion", descripcion);
                    cmd.Parameters.AddWithValue("imagen", rutaimagen);
                    cmd.Parameters.AddWithValue("Preciocompra", preciocompra);
                    cmd.Parameters.AddWithValue("Precioventa", precioventa);
                    cmd.Parameters.AddWithValue("idCategoria", indicecategoria);
                    cmd.Parameters.AddWithValue("idtipounidad", indicetipounidad);
                    cmd.Parameters.AddWithValue("idestadoproducto", indiceestadoprod);

                    operacionesformulario.insertar(cmd, this.conexion);
                    //insertarproductolocacion();
                    actualizarProductolocacion();
                    llenargridProductos();
                    llenargridPrincipal();
                    limpiarvariablesycampos();
                    //  llenarcategorias();

                }
            }

            catch (Exception es)
            {
                MessageBox.Show(es.ToString());
            }
        }

        public void actualizarProductolocacion() {
            cantidadtienda = Convert.ToInt32(txtcanttienda.Text);
            cantidadbodega = Convert.ToInt32(txtcantbodega.Text);
            indicelocacion = Convert.ToInt32(cbxlocacion.SelectedValue.ToString());
            if (indicelocacion==1)//locacion tienda
            {
                cantidad = cantidadtienda;
            }
            else//locacion Bodega =2
            {
                cantidad = cantidadbodega;
            }
            try
            {
                if (Nombre.Equals("") || txtprecompra.Text.Equals("") || txtpreventa.Text.Equals("") || txtcanttienda.Text.Equals("") || txtcantbodega.Text.Equals(""))
                {
                    MessageBox.Show("Debe ingresar todos los datos requeridos");
                }
                else
                {
                    String query = "Update ProductoLocacion Set Cantidad=@Cantidad Where Producto_idProducto=@idProducto and TipoLocacion_idTipoLocacion=@idTipoLocacion";

                    MySqlCommand cmd = new MySqlCommand();
                    //MySqlDataReader reader;

                    cmd.CommandText = query;
                    // cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    cmd.Parameters.AddWithValue("idProducto", idproducto);
                    cmd.Parameters.AddWithValue("idTipoLocacion", indicelocacion);
                    cmd.Parameters.AddWithValue("Cantidad", cantidad);
          
                    operacionesformulario.insertar(cmd, this.conexion);
                    //insertarproductolocacion();
                  //  llenargridProductos();
                    //limpiarvariablesycampos();
                    //  llenarcategorias();

                }
            }

            catch (Exception es)
            {
                MessageBox.Show(es.ToString());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormImagen forimagen = new FormImagen(rutaimagen);
            forimagen.ShowDialog();
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtbusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            string salida_datos = "";
            string[] palabras_busqueda = txtbusqueda.Text.Split(' ');

            foreach (string palabra in palabras_busqueda)
            {

                if (salida_datos.Length == 0)
                {
                    salida_datos = "(Nombre LIKE '%" + palabra + "%'OR Descripcion LIKE '%" + palabra + "%' )";

                }
                else
                {
                    salida_datos += "AND(Nombre LIKE '%" + palabra + "%'OR Descripcion LIKE '%" + palabra + "%')";
                }

            }

            this.mifiltro.RowFilter = salida_datos;
        }

        private void Formularioproductos_FormClosed(object sender, FormClosedEventArgs e)
        {
            llenargridPrincipal();
        }

        private void btndardebaja_Click(object sender, EventArgs e)
        {
            Nombre = txtnombreprod.Text;
            descripcion = txtdescripcion.Text;
            preciocompra = Convert.ToDouble(txtprecompra.Text);
            precioventa = Convert.ToDouble(txtpreventa.Text);
            cantidadtienda = Convert.ToInt32(txtcanttienda.Text);
            cantidadbodega = Convert.ToInt32(txtcantbodega.Text);
            indicelocacion = Convert.ToInt32(cbxlocacion.SelectedValue.ToString());

            try
            {
                if (Nombre.Equals("") || txtprecompra.Text.Equals("") || txtpreventa.Text.Equals("") || txtcanttienda.Text.Equals("") || txtcantbodega.Text.Equals(""))
                {
                    MessageBox.Show("Debe ingresar todos los datos requeridos");
                }
                else
                {
                    String query = "Update Producto Set idestadoproducto=3 "
                    + "where idproducto=@idproducto";

                    MySqlCommand cmd = new MySqlCommand();
                    //MySqlDataReader reader;

                    cmd.CommandText = query;
                    // cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    cmd.Parameters.AddWithValue("idproducto", idproducto);
                   
                    operacionesformulario.insertar(cmd, this.conexion);
                    //insertarproductolocacion();
                    actualizarProductolocacion();
                    llenargridProductos();
                    llenargridPrincipal();
                    limpiarvariablesycampos();
                    //  llenarcategorias();

                }
            }

            catch (Exception es)
            {
                MessageBox.Show(es.ToString());
            }
        }

    }
}
