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
    public partial class FormularioTipoLocacion : Form
    {
        OperacionesFormulario operacionesformulario;
        MySqlConnection conexion;
        String indice = "";
        String nombre = "";
        public FormularioTipoLocacion(OperacionesFormulario operacionesformulario, MySqlConnection conexion)
        {
            InitializeComponent();
            this.operacionesformulario = operacionesformulario;
            this.conexion = conexion;
        }

        public void llenartipolocacion()
        {
            String query = "Select idtipolocacion as Código_Locación, nombre as Nombre from tipolocacion";
            operacionesformulario.llenargrid(dataGridViewtipolocacion, query, conexion);
        }
        private void FormularioTipoLocacion_Load(object sender, EventArgs e)
        {
            llenartipolocacion();
            dataGridViewtipolocacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public bool numero(string inputvalue)
        {
            Regex cadenaingresada = new Regex("[^0-9]");
            return !cadenaingresada.IsMatch(inputvalue);
        }

        private void botonagregar_Click(object sender, EventArgs e)
        {
            if (textonombre.Text == "" || textoid.Text == "")
            {

                MessageBox.Show("Debe rellenar todos los campos.");
            }
            else
            {

                try
                {

                    if (numero(textoid.Text))
                    {
                        String query = "INSERT into tipolocacion(idTipoLocacion,Nombre) values(@id,@name)";
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.CommandText = query;
                        cmd.Connection = conexion;
                        cmd.Parameters.AddWithValue("id", textoid.Text);
                        cmd.Parameters.AddWithValue("name", textonombre.Text);
                        operacionesformulario.insertar(cmd, conexion);
                        llenartipolocacion();
                        textonombre.Text = "";
                        textoid.Text = "";
                    }
                    else {
                        MessageBox.Show("El código ingresado no es un valor numérico.");
                    }
                   

                }
                catch (Exception es)
                {
                    MessageBox.Show(es.ToString());
                }

            }
        }

        private void botonbuscar_Click(object sender, EventArgs e)
        {
            if (textobuscar.Text == "")
            {
                MessageBox.Show("Debe ingresar un dato a buscar");
            }
            else
            {

                if (checkBox1.Checked)
                {

                    String query = "Select idtipolocacion as Código_Locación, nombre as Nombre from tipolocacion where Nombre = " + "'" + textobuscar.Text + "'";
                    operacionesformulario.llenargrid(dataGridViewtipolocacion, query, conexion);

                }
                else
                {

                    if (numero(textobuscar.Text))
                    {
                        String query = "Select idtipolocacion as Código_Locación, nombre as Nombre from tipolocacion where idTipolocacion = " + textobuscar.Text;
                        operacionesformulario.llenargrid(dataGridViewtipolocacion, query, conexion);
                    }
                    else
                    {

                        MessageBox.Show("El dato ingresado no es un valor numérico");

                    }

                }
            }
        }

        private void dataGridViewtipolocacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dataGridViewtipolocacion.Rows[e.RowIndex];
            indice = dgv.Cells[0].Value.ToString();
            nombre = dgv.Cells[1].Value.ToString();
        }

        private void botoneliminar_Click(object sender, EventArgs e)
        {
            try
            {


                if (indice == "")
                {
                    MessageBox.Show("Debe seleccionar un registro para eliminar");
                }
                else
                {
                    String query = "Delete from tipolocacion where idTipolocacion = " + indice;
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = query;
                    cmd.Connection = conexion;
                    operacionesformulario.eliminar(cmd, conexion);
                    llenartipolocacion();
                }


            }
            catch (Exception es)
            {
                MessageBox.Show(es.ToString());
            }
        }




    }
}
