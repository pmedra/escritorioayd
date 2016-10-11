using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace NegocioLucero
{
  public  class Carrito
    {
     public    List<Producto> Listaproductos = new List<Producto>();
        OperacionesFormulario operacionesformulario;
        MySqlConnection conexion;
      public  Producto temporal = new Producto();
  
        public Carrito()
        {
        
        }

        public Carrito(OperacionesFormulario operacionesformulario, MySqlConnection conexion)
        {
            this.operacionesformulario = operacionesformulario;
            this.conexion = conexion;
        }
        public void insertarproducto(Producto producto){
            if (buscarprodindex(producto.idproducto)!=0)//si ya existe solo agrega la cantidad respectiva
            {
                int index = buscarProducto(temporal);
                Producto prodlista = Listaproductos[index];
                int cantidad1 = producto.cantidad;
                prodlista.cantidad += cantidad1;
                Listaproductos[index] = prodlista;

                MessageBox.Show("ya existe en la venta");
            }
            else
            {
                Listaproductos.Add(producto);//si no existe lo agrega al carrito
             //   MessageBox.Show("no existe en carrito");
            }
       

        }

       
        public int buscarProducto(Producto producto)
        {
            int indexproducto = -1;
            indexproducto= Listaproductos.IndexOf(producto);
            return indexproducto;
        }

        public int buscarprodindex(int idproducto)
        {
            int index = 0;
            foreach (Producto item in Listaproductos)
            {
                if (item.idproducto==idproducto)
                {
                    //index = buscarProducto(item);
                    index = 1;
                    temporal = item;
                  
                }
              

            }
            return index;
        }

        public void eliminarProducto(Producto producto) {
            if (buscarprodindex(producto.idproducto) != 0)//si ya existe remueve el producto de la lista
            {
               // int index = buscarProducto(producto);
                Listaproductos.Remove(temporal);

            }
            else
            {
               //nada
            }
        }

        public void generarfactura(int idcliente, decimal totalfactura, decimal abono,int idestadofactura)
        {
            try
            {
                String query = "Insert into factura(FechaFactura,TotalFactura,Abono,EstadoFactura_idEstadoFactura,Cliente_idCliente) "
                                + " values(now(),@totalfactura,@abono,@idestadofactura,@idcliente);";

                MySqlCommand cmd = new MySqlCommand();
                //MySqlDataReader reader;

                cmd.CommandText = query;
                // cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                cmd.Parameters.AddWithValue("idcliente", idcliente);
                cmd.Parameters.AddWithValue("totalfactura", totalfactura);
                cmd.Parameters.AddWithValue("abono", abono);
                cmd.Parameters.AddWithValue("idestadofactura", idestadofactura);

                operacionesformulario.insertar(cmd, this.conexion);
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al generar factura " + ex.ToString());
            }
            

        }

        public int guardarproductosfactura()
        {
            int idFactura = 0;

            MySqlCommand cmd = new MySqlCommand();
            //MySqlDataReader reader;

            cmd.CommandText = "select * from Factura order by idFactura desc limit 1";
            // cmd.CommandType = CommandType.StoredProcedure;
            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }
            cmd.Connection = conexion;

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {

              
                while (reader.Read())
                {

                    idFactura = (int)reader.GetValue(0);

                }
                reader.Close();
                if (idFactura != 0)
                {
                    try
                    {
                        foreach (Producto item in Listaproductos)
                        {
                            String query = "insert into ProductoFactura(CantidadVendida,PrecioProducto,Factura_idFactura,Producto_idProducto) values (@CantidadVendida,@PrecioProducto,@idFactura,@idProducto)";

                            MySqlCommand cmd1 = new MySqlCommand();
                            //MySqlDataReader reader;

                            cmd1.CommandText = query;
                            // cmd.CommandType = CommandType.StoredProcedure;
                            cmd1.Connection = conexion;
                            cmd1.Parameters.AddWithValue("CantidadVendida",item.cantidad);
                            cmd1.Parameters.AddWithValue("PrecioProducto", item.precio);
                            cmd1.Parameters.AddWithValue("idFactura", idFactura);
                            cmd1.Parameters.AddWithValue("idProducto",item.idproducto);
                            operacionesformulario.insertar(cmd1, this.conexion);
                        }
                                                 
                    }

                    catch (Exception es)
                    {
                        MessageBox.Show(es.ToString());
                    }

                }
            }
            return idFactura;

        }

        public void confirmarproducto() {
            try
            {
                int cantidad = 0;
                int idproducto = -1;
                foreach (Producto item in Listaproductos)
                {
                    cantidad = item.cantidad;
                    idproducto = item.idproducto;
                    String query = "update productolocacion Set Cantidad=Cantidad-@cantidad  where Producto_idProducto=@idproducto AND TipoLocacion_idTipoLocacion=1 AND @cantidad<=Cantidad;";

                    MySqlCommand cmd = new MySqlCommand();
                    //MySqlDataReader reader;

                    cmd.CommandText = query;
                    // cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    cmd.Parameters.AddWithValue("cantidad", cantidad);
                    cmd.Parameters.AddWithValue("idproducto", idproducto);

                    operacionesformulario.insertar(cmd, this.conexion);
                }
                Listaproductos.Clear();
               
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        
        }
        public void calculartotal()
        {
           decimal sub = 0;
            foreach (Producto item in Listaproductos)
            {
                decimal subt = item.cantidad * item.precio;
                sub += subt;
            }
            MessageBox.Show("El total es " + sub.ToString());
        }

    }
}
