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

namespace NegocioLucero.FormsAdmin
{
    public partial class Actualizar_Tipo_Usuario : Form
    {
        OperacionesFormulario operacionesformulario;
        MySqlConnection conexion;
        int indice;
        public Actualizar_Tipo_Usuario(OperacionesFormulario operacionesformulario, MySqlConnection conexion, int indice)
        {
            InitializeComponent();
            this.operacionesformulario = operacionesformulario;
            this.conexion = conexion;
            this.indice = indice;
        }

        private void botonactualizar_Click(object sender, EventArgs e)
        {
            try
            {

                if (textodescripcion.Text != "")
                {
                    String query = "update tipousuario set descripcion = @name where idtipousuario = " + indice;
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = query;
                    cmd.Connection = conexion;
                    cmd.Parameters.AddWithValue("name", textodescripcion.Text);
                    operacionesformulario.modificar(cmd, conexion);
                    textodescripcion.Text = "";
                }
                else if(textonombre.Text!=""){

                    String query = "update tipousuario set nombre = @name where idtipousuario = " + indice;
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = query;
                    cmd.Connection = conexion;
                    cmd.Parameters.AddWithValue("name", textonombre.Text);
                    operacionesformulario.modificar(cmd, conexion);
                    textonombre.Text = "";
                }
               
                   
                


            }
            catch (Exception es)
            {
                MessageBox.Show(es.ToString());
            }
        }
    }
}
