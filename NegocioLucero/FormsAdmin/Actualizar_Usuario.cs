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
using System.Text.RegularExpressions;

namespace NegocioLucero.FormsAdmin
{
    public partial class Actualizar_Usuario : Form
    {
        OperacionesFormulario operacionesformulario;
        MySqlConnection conexion;
        int indice;
        String nombre;
        int estado;
        int rol;
        public Actualizar_Usuario(OperacionesFormulario operacionesformulario, MySqlConnection conexion, int indice, String nombre, int estado, int rol)
        {
            InitializeComponent();
            this.operacionesformulario = operacionesformulario;
            this.conexion = conexion;
            this.indice = indice;
            this.nombre = nombre;
            this.estado = estado;
            this.rol = rol;
        }

        public bool numero(string inputvalue)
        {
            Regex cadenaingresada = new Regex("[^0-9]");
            return !cadenaingresada.IsMatch(inputvalue);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                if(textonombre.Text!=""){

                    String query = "update usuario set Nombre = @name where idUsuario = " + indice;
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = query;
                    cmd.Connection = conexion;
                    cmd.Parameters.AddWithValue("name", textonombre.Text);
                    operacionesformulario.modificar(cmd, conexion);
                    

                }else if(textoestado.Text!=""){

                    if (numero(textoestado.Text))
                    {
                        String query = "update usuario set Activo = @estado where idUsuario = " + indice;
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.CommandText = query;
                        cmd.Connection = conexion;
                        cmd.Parameters.AddWithValue("estado", textoestado.Text);
                        operacionesformulario.modificar(cmd, conexion);
                    }
                    else {
                        MessageBox.Show("El estado no es un valor numerico");
                    }
                    

                }else if(textotipo.Text!=""){

                    if (numero(textotipo.Text))
                    {
                        String query = "update usuario set Tipousuario_idTipoUsuario = @tipo where idUsuario = " + indice;
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.CommandText = query;
                        cmd.Connection = conexion;
                        cmd.Parameters.AddWithValue("tipo", textotipo.Text);
                        operacionesformulario.modificar(cmd, conexion);
                    }
                    else {
                        MessageBox.Show("El tipo de usuario no es un valor numerico");
                    }
                    

                }else if(textocontra.Text!="" && textocontra2.Text!=""){

                    if (textocontra.Text == textocontra2.Text)
                    {
                        String query = "update usuario set Password = MD5(@contra) where idUsuario = " + indice;
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.CommandText = query;
                        cmd.Connection = conexion;
                        cmd.Parameters.AddWithValue("contra", textocontra.Text);
                        operacionesformulario.modificar(cmd, conexion);
                    }
                    else {
                        MessageBox.Show("Las contraseñas no coinciden");
                    }

                }

                limpiar();

              /*  if (textonombre.Text == "" || textoestado.Text == "" || textotipo.Text == "")
                {
                    MessageBox.Show("Debe ingresar todos los datos");
                }
                else
                {
                    if (numero(textoestado.Text) && numero(textotipo.Text))
                    {
                        String query = "update usuario set Nombre = @name, Activo = @active, Tipousuario_idTipousuario = @type where idUsuario = " + indice;
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.CommandText = query;
                        cmd.Connection = conexion;
                        cmd.Parameters.AddWithValue("name", textonombre.Text);
                        cmd.Parameters.AddWithValue("active", Int32.Parse(textoestado.Text));
                        cmd.Parameters.AddWithValue("type", Int32.Parse(textotipo.Text));
                        operacionesformulario.modificar(cmd, conexion);
                        limpiar();
                    }
                    else {
                        MessageBox.Show("Debe ingresar un valor númerico");
                    }
                   
                }*/
            }
            catch (Exception es)
            {
                MessageBox.Show(es.ToString());
            }
            
        }

        private void Actualizar_Usuario_Load(object sender, EventArgs e)
        {
            /*textonombre.Text = nombre;
            textoestado.Text = estado.ToString();
            textotipo.Text = rol.ToString();*/
        }

        private void limpiar() {
            textonombre.Text = "";
            textoestado.Text = "";
            textotipo.Text = "";
            textocontra.Text = "";
            textocontra2.Text = "";
        }
    }
}
