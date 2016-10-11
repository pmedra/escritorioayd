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
    public partial class Actualizar_Tipo_Unidad : Form
    {

        OperacionesFormulario operacionesformulario;
        MySqlConnection conexion;
        int indice;
        public Actualizar_Tipo_Unidad(OperacionesFormulario operacionesformulario, MySqlConnection conexion,int indice)
        {
            InitializeComponent();
            this.operacionesformulario = operacionesformulario;
            this.conexion = conexion;
            this.indice = indice;
        }

        private void botonactualizar_Click(object sender, EventArgs e)
        {
            try {

                if (textBox1.Text == "")
                {
                    MessageBox.Show("Debe ingresar un valor");
                }
                else {
                    String query = "update tipounidad set Nombre = @name where idTipoUnidad = " + indice;
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = query;
                    cmd.Connection = conexion;
                    cmd.Parameters.AddWithValue("name", textBox1.Text);
                    operacionesformulario.modificar(cmd, conexion);
                    textBox1.Text = "";
                }


            }
            catch (Exception es)
            {
                MessageBox.Show(es.ToString());
            }
        }
    }
}
