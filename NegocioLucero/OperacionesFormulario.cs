using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;


namespace NegocioLucero
{
    public class OperacionesFormulario
    {


        public OperacionesFormulario() { }


        public void llenargrid(DataGridView datagrid, String query, MySqlConnection conexion)
        {
            try
            {
                verificarconexion(conexion);
                using (conexion)
                {
                    MySqlCommand comando = new MySqlCommand(query, conexion);
                    MySqlDataAdapter da = new MySqlDataAdapter(comando);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    datagrid.DataSource = dt;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }



        public void llenarcombobox(ComboBox comboBox1, String query, MySqlConnection conexion, String identificador, String Nombre)
        {
            try
            {
                verificarconexion(conexion);
                using (conexion)
                {
                    MySqlCommand cmd = new MySqlCommand(query, conexion);

                    MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da1.Fill(dt);

                    comboBox1.ValueMember = identificador;
                    comboBox1.DisplayMember = Nombre;
                    comboBox1.DataSource = dt;


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }



        public void insertar(MySqlCommand cmd, MySqlConnection conexion)
        {
            try
            {
                verificarconexion(conexion);
                using (conexion)
                {
                    try
                    {
                        MySqlDataReader MyReader2;
                        MyReader2 = cmd.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                        //   MessageBox.Show("Dato Guardado");
                        while (MyReader2.Read())
                        {
                        }
                        MyReader2.Close();
                    }

                    catch (Exception e)
                    {

                        MessageBox.Show(e.ToString());
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        public bool validarEnteros(TextBox cajadetexto)
        {
            try
            {
                int d = Convert.ToInt32(cajadetexto.Text);
                return true;
            }
            catch (Exception ex)
            {

                cajadetexto.Text = "0";
                cajadetexto.Select(0, cajadetexto.Text.Length);
                return false;
            }

        }


        public bool validarDecimales(TextBox cajadetexto)
        {
            try
            {
                decimal d = Convert.ToDecimal(cajadetexto.Text);
                return true;
            }
            catch (Exception ex)
            {

                cajadetexto.Text = "0";
                cajadetexto.Select(0, cajadetexto.Text.Length);
                return false;
            }

        }
        public void verificarconexion(MySqlConnection conexion)
        {
            try
            {
                 if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }

        }

        public int iniciarsesion(MySqlCommand cmd, MySqlConnection conexion, String usuario)
        {
            int conta = 0;
            verificarconexion(conexion);
            using (conexion)
            {
                try
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {

                        int retrievedValue = 0;
                        String user = "";
                        
                        int activo = 0;
                        int tipousuario = 0;
                        while (reader.Read())
                        {

                            retrievedValue = (int)reader.GetValue(0);
                            user = (String)reader.GetValue(1);
                            activo = (int)reader.GetValue(4);
                            tipousuario = (int)reader.GetValue(5);

                            if (user.Equals(usuario) && activo == 1 && tipousuario == 1)
                            {
                                conta = 1;


                            }
                        }
                     
                    }
                   
                }
 
                catch (Exception e)
                {

                    MessageBox.Show(e.ToString());
                }
            }
            return conta;
        }

        public string buscarcliente (MySqlCommand cmd, MySqlConnection conexion, String DPI)
        {
            int conta = 0;
            String datoscliente = "";
            verificarconexion(conexion);
            using (conexion)
            {
                try
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {

                        int idcliente = 0;
                        String DPIclien = "";
                        String Nombres = "";
                        String Apellidos = "";
                                

                        int activo = 0;
                        int tipousuario = 0;
                        while (reader.Read())
                        {

                           idcliente = (int)reader.GetValue(0);
                            DPIclien= (String)reader.GetValue(1);
                            Nombres = (String)reader.GetValue(2);
                            Apellidos = (String)reader.GetValue(3);

                            if (DPIclien.Equals(DPI) )
                            {
                                datoscliente = idcliente.ToString()+";"+Nombres + " " + Apellidos;

                            }
                        }

                    }

                }

                catch (Exception e)
                {

                    MessageBox.Show(e.ToString());
                }
            }
            return datoscliente;
        }

        public void actualizarstock(int idproducto, int idcantidad) { 
        
        
        
        }










        public void eliminar(MySqlCommand cmd, MySqlConnection conexion)
        {

            verificarconexion(conexion);
            using (conexion)
            {
                try
                {
                    int elimin = 0;
                    elimin = cmd.ExecuteNonQuery();
                    if (elimin != 0)
                    {
                        MessageBox.Show("Datos Eliminados");

                    }
                }

                catch (Exception e)
                {

                    MessageBox.Show(e.ToString());
                }
            }
        }


        public void modificar(MySqlCommand cmd, MySqlConnection conexion)
        {
            verificarconexion(conexion);
            using (conexion)
            {
                try
                {
                    int actual = 0;
                    actual = cmd.ExecuteNonQuery();
                    if (actual != 0)
                    {
                        MessageBox.Show("Datos Actualizados");

                    }
                }

                catch (Exception e)
                {

                    MessageBox.Show(e.ToString());
                }
            }
        }

    }


}
