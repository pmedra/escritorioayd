using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace NegocioLucero
{
    class Conexion
    {
        public static string cadenaconexion;
        public static MySqlConnection conexion;
        public static DataSet dst;
        public static MySqlDataAdapter adaptador;
      // public static String Servidor = "localhost";
        //  public static String Basededatos = "prueba";
        // public static String Uid = "root";
        //  public static String Pwd = "Master";
         public static String estadoconexion = "No conectado";

        public static MySqlConnection GetConexion(String Servidor,String Puerto,String Basededatos, String Uid, String Pwd)
        {
            try
            {

                cadenaconexion = @"Server=" + Servidor + ";" + "Port="+Puerto+";" +"Database=" + Basededatos + ";" + "Uid=" + Uid + ";" + "Pwd=" + Pwd + ";";
              //  cadenaconexion = @"Server=" + Servidor + ";" +"Database=" + Basededatos + ";" + "Uid=" + Uid + ";" + "Pwd=" + Pwd + ";";
                conexion = new MySqlConnection(cadenaconexion);
               
                conexion.Open();
                if (conexion.State == ConnectionState.Open)
                {
                    estadoconexion = "Conectado con Servidor";
                    return conexion;
                }
            }
            catch (Exception ex)
            {
                estadoconexion = ex.Message;
                MessageBox.Show(ex.ToString());

            }

            return conexion;

        }

        
   

    }





}
