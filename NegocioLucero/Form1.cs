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
    public partial class Form1 : Form
    {
        MySqlConnection conexion;
        public String usuario = "";
        public String password = "";
        public static String Servidor = "localhost";
        public static String Puerto = "3306";
        public static String Basededatos = "prueba";
        public static String Uid = "root";
        public static String Pwd = "Master";
        public OperacionesFormulario operacionesformulario=new OperacionesFormulario();

        public Form1()
        {
            InitializeComponent();
            txtpassword.PasswordChar = '*';
            crearcarpeta();
            try
            {
                conexion = Conexion.GetConexion(Servidor,Puerto,Basededatos,Uid,Pwd);
                if (conexion.State == ConnectionState.Open)
                {
                    MessageBox.Show("Conectado");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
       {
            if (e.KeyChar == (char)13)
            {
                txtpassword.Focus();

            }
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnsesion.Focus();

            }
        }

        private void btnsesion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnsesion.Focus(); //aqui va el codigo que se ejecuta al presionar enter


            }
        }

        private void btnsesion_Click(object sender, EventArgs e)
        {
            int conta = 0;
            usuario = txtusuario.Text;
            password = txtpassword.Text;
            // String query = "Select * from Usuario where Nombre=" + usuario + " and Password=MD5(" + password + ")";

            MySqlCommand cmd = new MySqlCommand();
            //MySqlDataReader reader;

            cmd.CommandText = "Select * from Usuario where Nombre=@Usuario and Password=MD5(@Pass) limit 1";
            // cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexion;
            cmd.Parameters.AddWithValue("Usuario", txtusuario.Text);
            cmd.Parameters.AddWithValue("Pass", txtpassword.Text);
            conta=operacionesformulario.iniciarsesion(cmd, conexion, usuario);

            //conta = 1;
                if (conta==0)
                {
                  
                    MessageBox.Show("Usuario o contraseña incorrecto");

                }
                else
                {
                    txtusuario.Text = "";
                    txtpassword.Text = "";
                    MessageBox.Show("Bienvenido");

                    Principal principal = new Principal(this, usuario, conexion);
                    this.Visible = false;

                    principal.Show();
                }
             
            
          
        }
        


        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void crearcarpeta()
        {
            //verifica si ya esta creado el directorio DepositoAndrea en el disco C
            string folderName = @"c:\DepositoAndrea";
            if (System.IO.Directory.Exists(folderName))
            {
                try
                {
                    string fileName = Application.StartupPath + @"\Configuracion.txt";
                    System.IO.StreamReader sr = new System.IO.StreamReader(fileName, System.Text.Encoding.Default);
                    string texto;
                    texto = sr.ReadToEnd();
                    sr.Close();

                    String[] datosservidor = texto.Split(';');
                    Servidor = datosservidor[0];
                    Puerto = datosservidor[1];
                    Basededatos = datosservidor[2];
                    Uid = datosservidor[3];
                    Pwd = datosservidor[4];
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
               


            }
            else
            {
                System.IO.Directory.CreateDirectory(folderName);
              

            }


        }
    }
}