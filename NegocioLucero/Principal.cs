using NegocioLucero.FormsAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NegocioLucero
{
    public partial class Principal : Form
    {
        private DataTable dt = new DataTable();
        DataSet resultados = new DataSet();
        DataView mifiltro = new DataView();
        public Form1 forma;
        public String usuario;
        public OperacionesFormulario operacionesformulario=new OperacionesFormulario();
        public Formularioproductos formularioproductos;
        public ReporteGanancias reporteganancais;
        public FormularioCategoria formulariocategoria;


        public Carrito carrito=new Carrito(); 

         public FormularioUsuarios formulariousuario;
        public FormularioTipoUnidad formulariotipounidad;
        public FormularioTipoLocacion formulariotipolocacion;
        public FormularioEstadoProducto formularioestadoproducto;
        public FormularioEstadoFactura formularioestadofactura;
        public FormularioEstadoPedido formularioestadopedido;
        public FormularioTipoUsuario formulariotipousuario;
        public BuscarFactura buscarfacturas;


        public MySqlConnection conexion;
        int estadocliente=0;
        int idcliente = -1;
        int idproducto = -1;
        int cantidad = 0;
        int cantidadprod = 0;
        String producto = "";
        String Unidad = "";
        Decimal precio = 0;
        Decimal subtotal = 0;
        int rowindexfactura = 0;
        Decimal total = 0;
        DataGridViewRow rowfactura=new DataGridViewRow();
        DataGridViewRow rowproducto = new DataGridViewRow();
        public Principal(Form1 forma,String Usuario,MySqlConnection conexion)
        {

            InitializeComponent(); 
            this.forma = forma;
            this.usuario = Usuario;
            this.conexion = conexion;
            carrito =new Carrito(operacionesformulario,conexion);
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            lblusuario.Text = this.usuario;
            lblfecha.Text = DateTime.Now.ToString("G");
            llenargridProductos();
            dt = (DataTable)dtgridproductos.DataSource;
            this.mifiltro = dt.DefaultView;
            this.dtgridproductos.DataSource = mifiltro;
            dtgridproductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgridfactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgridfactura.EditMode = DataGridViewEditMode.EditOnEnter;
            dtgridproductos.ReadOnly = true;
            dtgridfactura.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.forma.Visible = true;
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Impedir que el formulario se cierre pulsando X o Alt + F4 
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formularioproductos formproducots = new Formularioproductos(operacionesformulario,conexion,dtgridproductos);
            formproducots.Visible = true;
        }



        public void llenargridProductos()
        {
            conexion.Close();
            String query =
"Select P.idProducto,P.Nombre,P.Descripcion,P.PrecioVenta,C.Nombre AS 'Categoria',TL.Nombre AS 'Locacion',PL.Cantidad AS 'Cantidad',TU.Nombre as 'Unidad',EP.Nombre as 'Estado Producto', P.imagen as 'Imagen' "
+ " From Producto P, Categoria C, TipoUnidad TU, EstadoProducto EP, TipoLocacion TL, ProductoLocacion PL "
+ " where P.idcategoria=C.idcategoria AND P.idtipounidad=TU.idtipounidad AND P.idestadoproducto=EP.idestadoproducto "
    + " AND P.idProducto=PL.Producto_idProducto AND TL.idtipoLocacion=PL.TipoLocacion_idTipoLocacion  AND PL.TipoLocacion_idTipoLocacion=1  AND PL.Cantidad>0 AND EP.idestadoproducto!=3";
           
            operacionesformulario.llenargrid(dtgridproductos, query, conexion);

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

        private void btnagregar_Click(object sender, EventArgs e)
        {

            try
            {
                if (rowproducto!=null)
                {
                    cantidad = Convert.ToInt32(txtcantidad.Text);

                    cantidadprod = Convert.ToInt32(rowproducto.Cells[6].Value.ToString());
                
                
                if (cantidad != 0 && cantidad<=cantidadprod)
                {
                    idproducto =Convert.ToInt32( rowproducto.Cells[0].Value.ToString());
                    producto = rowproducto.Cells[1].Value.ToString();
                    cantidadprod = Convert.ToInt32(rowproducto.Cells[6].Value.ToString());
                    Unidad = rowproducto.Cells[7].Value.ToString();
                    precio = Convert.ToDecimal(rowproducto.Cells[3].Value);
                    subtotal = cantidad * precio;
                  
                    Producto productoitem = new Producto(idproducto, cantidad, precio);
                    if (carrito.buscarprodindex(productoitem.idproducto)==0)
                    {
                       
                        carrito.insertarproducto(productoitem);
                        this.dtgridfactura.Rows.Insert(0,idproducto,cantidad, producto, Unidad, precio, subtotal);

                    }
                    int m = 0;  // Apunta a la fila actual
                    int n = dtgridfactura.Rows.Count - 1;  // cantidad de filas en el DataGridView
                    int k;
                    string estaFila, unaFila;

                    while (m < n)
                    {
                        k = 1;
                        estaFila = String.Empty;

                        // Relleno la cadena con los datos de toda la fila
                        for (int i = 0; i < dtgridfactura.Columns.Count; i++)
                            estaFila = String.Concat(estaFila, dtgridfactura.Rows[m].Cells[i].Value.ToString());

                        while (k < n)
                        {
                            unaFila = String.Empty;  // Fila a comparar

                            for (int i = 0; i < dtgridfactura.Columns.Count; i++)
                                unaFila = String.Concat(unaFila, dtgridfactura.Rows[k].Cells[i].Value.ToString());

                            if (String.Compare(estaFila, unaFila) == 0 && k != m)
                            {
                                dtgridfactura.Rows.RemoveAt(k); // Si son iguales remuevo unaFila solamente
                                n--;     // Tamaño actual del DataGridView, al remover disminuye en uno
                            }
                            k++;
                        }
                        m++;
                    }
                    actualizartotal();
                    //  carrito.calculartotal();
                    // MessageBox.Show(result.ToString());
                    this.dtgridfactura.CurrentCell = this.dtgridfactura[0, 0];
                }
                else
                {
                    MessageBox.Show("la cantidad ingresada es mayor al stock");
                }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());  
               
            } 
           
        }
        public void actualizartotal() {
            Decimal result = dtgridfactura.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDecimal(x.Cells["Column5"].Value));
            txttotal.Text = result.ToString();
            total = result;
        }
        private void dtgridproductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                subtotal = 0;

                int rowIndex = e.RowIndex;
                if (rowIndex!=-1)
                {
                    DataGridViewRow row = dtgridproductos.Rows[rowIndex];
                    rowproducto = row;
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            } 
                
          
                

        }

        private void txtidcliente_Leave(object sender, EventArgs e)
        {


            buscarcliente();
           
        }

        public void buscarcliente() {
            try
            {
                String DPIclien = txtidcliente.Text;

                String datoscliente = "";
                // String query = "Select * from Usuario where Nombre=" + usuario + " and Password=MD5(" + password + ")";

                MySqlCommand cmd = new MySqlCommand();
                //MySqlDataReader reader;

                cmd.CommandText = "Select * from Cliente where DPI=@DPIclien limit 1";
                // cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                cmd.Parameters.AddWithValue("DPIclien", DPIclien);

                datoscliente = operacionesformulario.buscarcliente(cmd, conexion, DPIclien);
                String[] datos = datoscliente.Split(';');


                // MessageBox.Show(datos[0]);//mostrar idcliente
                if (!datoscliente.Equals(""))
                {

                    idcliente = Convert.ToInt32(datos[0]);
                    txtnombrecliente.Text = datos[1];
                    estadocliente = 1;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        
        }
        private void dtgridfactura_CurrentCellChanged(object sender, EventArgs e)
        {
           
           

        }

        private void txtcantidad_KeyUp(object sender, KeyEventArgs e)
        {
            operacionesformulario.validarEnteros(txtcantidad);
        }

        private void dtgridfactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (rowindexfactura!=-1)
                {
                    rowindexfactura = e.RowIndex;
                    DataGridViewRow row = dtgridfactura.Rows[rowindexfactura];
                    idproducto = Convert.ToInt32(row.Cells[0].Value.ToString());
                    cantidad = Convert.ToInt32(row.Cells[1].Value.ToString());
                    producto = rowproducto.Cells[2].Value.ToString();
                    Unidad = rowproducto.Cells[3].Value.ToString();
                    precio = Convert.ToDecimal(rowproducto.Cells[3].Value.ToString());
                    //subtotal = cantidad * precio;
                    // txtcantfactura.Text = cantidad.ToString();
                    txtcantidad.Text = cantidad.ToString();
                    rowfactura = row;
                }
                }
              
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgridfactura.RowCount - 1 > 0)
                {
                    dtgridfactura.Rows.RemoveAt(rowindexfactura);
                    Producto producto = new Producto(idproducto, cantidad, precio);
                    carrito.eliminarProducto(producto);
                    actualizartotal();
                    //carrito.calculartotal();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());    
            }
           
           
        }

        private void dtgridfactura_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void txtcantfactura_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
          
                {
                    
               
                DataGridViewRow row = rowfactura;
                cantidad = Convert.ToInt32(txtcantidad.Text);
                if (cantidad!=0)
                {
                  //  MessageBox.Show(cantidad.ToString());
                    idproducto = Convert.ToInt32(row.Cells[0].Value.ToString());
                    producto = row.Cells[2].Value.ToString();
                    Unidad = row.Cells[3].Value.ToString();
                    precio = Convert.ToDecimal(row.Cells[4].Value);
                    subtotal = cantidad * precio;
                    dtgridfactura.Rows[rowindexfactura].Cells[1].Value = cantidad.ToString();
                    dtgridfactura.Rows[rowindexfactura].Cells[5].Value = subtotal;
                    dtgridfactura.Rows.Insert(rowindexfactura,idproducto, cantidad, producto, Unidad, precio, subtotal);
                    dtgridfactura.Rows.RemoveAt(rowindexfactura);
                    this.dtgridfactura.CurrentCell = this.dtgridfactura[0, dtgridfactura.CurrentRow.Index];
                    Producto productoitem = new Producto(idproducto, cantidad, precio);
                    carrito.eliminarProducto(productoitem);
                    carrito.insertarproducto(productoitem);

                    actualizartotal();
                  //  carrito.calculartotal();
                
                }
               
            }
            catch (Exception ex)
            {

           MessageBox.Show(ex.ToString());
            }
        }

      
        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularioproductos formproductos = new Formularioproductos(operacionesformulario,conexion,dtgridproductos);
            formproductos.Visible = true;


        }
        
        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formulariocategoria = new FormularioCategoria(operacionesformulario,conexion);
            formulariocategoria.Visible = true;

        
        }
        
        //
        //ACA LO MIO SHAVELARDO
        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formulariousuario = new FormularioUsuarios(operacionesformulario,conexion);
            formulariousuario.StartPosition = FormStartPosition.CenterScreen;
            formulariousuario.Show(this);
        }



        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularioestadofactura = new FormularioEstadoFactura(operacionesformulario, conexion);
            formularioestadofactura.StartPosition = FormStartPosition.CenterScreen;
            formularioestadofactura.Show(this);
        }

        private void unidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formulariotipounidad = new FormularioTipoUnidad(operacionesformulario, conexion);
            formulariotipounidad.StartPosition = FormStartPosition.CenterScreen;
            formulariotipounidad.Show(this);
        }

        private void locaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formulariotipolocacion = new FormularioTipoLocacion(operacionesformulario, conexion);
            formulariotipolocacion.StartPosition = FormStartPosition.CenterScreen;
            formulariotipolocacion.Show(this);
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formulariotipousuario = new FormularioTipoUsuario(operacionesformulario, conexion);
            formulariotipousuario.StartPosition = FormStartPosition.CenterScreen;
            formulariotipousuario.Show(this);
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formularioestadoproducto = new FormularioEstadoProducto(operacionesformulario, conexion);
            formularioestadoproducto.StartPosition = FormStartPosition.CenterScreen;
            formularioestadoproducto.Show(this);
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularioestadopedido = new FormularioEstadoPedido(operacionesformulario, conexion);
            formularioestadopedido.StartPosition = FormStartPosition.CenterScreen;
            formularioestadopedido.Show(this);
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            if (txtidcliente.Text == "" || txtnombrecliente.Text == "")
            {
                MessageBox.Show("Rellenar los datos del cliente.");
            }
            else {

                int idfactura = 0;
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
               
                dt.Columns.Add("Cantidad", typeof(string));
                dt.Columns.Add("Producto", typeof(string));
                dt.Columns.Add("Unidad", typeof(string));
                dt.Columns.Add("Precio", typeof(string));
                dt.Columns.Add("Subtotal", typeof(string));
                try
                {
                    foreach (DataGridViewRow dgv in dtgridfactura.Rows)
                    {
                        dt.Rows.Add(dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value, dgv.Cells[4].Value, dgv.Cells[5].Value);
                    }
                    ds.Tables.Add(dt);
                    ds.WriteXmlSchema(@"c:\DepositoAndrea\FacturaTemporal.xml");
                    if (idcliente==0 || idcliente ==-1)
                    {
                        MessageBox.Show("el cliente no existe");
                        String Nombre = "";
                        String Apellido = "";
                        String[] datoscliente = txtnombrecliente.Text.Split(' ');
                        int num=0;
                        int leng=datoscliente.Length;
                        for (int i = 0; i < leng; i++)
                        {
                            if (i+1>leng/2)
                            {
                                Apellido += datoscliente[i];
                                Apellido += " "; 
                            }
                            else
                            {
                                Nombre += datoscliente[i];
                                Nombre += " ";
                                
                            }
                        }

                        String query = "insert into Cliente(DPI,Nombres,Apellidos) values (@DPI,@Nombres,@Apellidos)";

                        MySqlCommand cmd = new MySqlCommand();
                        //MySqlDataReader reader;

                        cmd.CommandText = query;
                        // cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conexion;
                        cmd.Parameters.AddWithValue("DPI",txtidcliente.Text);
                        cmd.Parameters.AddWithValue("Nombres", Nombre);
                        cmd.Parameters.AddWithValue("Apellidos", Apellido);
                      
                        operacionesformulario.insertar(cmd, this.conexion);
                        buscarcliente();

                    }
                  

                    carrito.generarfactura(idcliente, total, total, 1);
                    idfactura = carrito.guardarproductosfactura();
                    if (idfactura!=0)
                    {
                        txtnofactura.Text = idfactura.ToString();
                        carrito.confirmarproducto();
                        dtgridfactura.Rows.Clear();
                     new Factura(ds, txtidcliente.Text, txtnombrecliente.Text, txttotal.Text, idfactura.ToString()).ShowDialog();
                        actualizartotal();
                        llenargridProductos();
                        limpiarvariables();
                    }
                    
                    
                    
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.ToString());
                }
            
            }
          
        }



        public void limpiarvariables()
        {

            idcliente = -1;
            txtidcliente.Text = "";
            txtnombrecliente.Text = "";
        }

        private void gananciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reporteganancais = new ReporteGanancias(operacionesformulario, conexion);
            reporteganancais.StartPosition = FormStartPosition.CenterScreen;
            reporteganancais.Show(this);
        }

        private void facturasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            buscarfacturas = new BuscarFactura(operacionesformulario, conexion);
            buscarfacturas.StartPosition = FormStartPosition.CenterScreen;
            buscarfacturas.Show();
        }
    

    }
}
