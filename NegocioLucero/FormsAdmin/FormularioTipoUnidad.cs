using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace NegocioLucero.FormsAdmin
{
    public partial class FormularioTipoUnidad : Form
    {

        OperacionesFormulario operacionesformulario;
        MySqlConnection conexion;
        Actualizar_Tipo_Unidad atu;
        String indice = "";
        String nombre = "";
        public FormularioTipoUnidad(OperacionesFormulario operacionesformulario, MySqlConnection conexion)
        {
            InitializeComponent();
            this.operacionesformulario = operacionesformulario;
            this.conexion = conexion;
        }

        public void llenartipounidad()
        {
            String query = "Select idtipounidad as Código_Tipo, nombre as Nombre  from tipounidad";
            operacionesformulario.llenargrid(dataGridViewtipounidad, query, conexion);
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
                        String query = "INSERT into tipounidad(idTipoUnidad,Nombre) values(@id,@name)";
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.CommandText = query;
                        cmd.Connection = conexion;
                        cmd.Parameters.AddWithValue("id", textoid.Text);
                        cmd.Parameters.AddWithValue("name", textonombre.Text);
                        operacionesformulario.insertar(cmd, conexion);
                        llenartipounidad();
                        textonombre.Text = "";
                        textoid.Text = "";
                    }
                    else {
                        MessageBox.Show("El Código No es un valor numerico.");
                    }

                    

                }
                catch (Exception es)
                {
                    MessageBox.Show(es.ToString());
                }

            }
        }

        private void botonmodificar_Click(object sender, EventArgs e)
        {

            try
            {

                if (indice == "")
                {
                    MessageBox.Show("Debe seleccionar un registro a modificar.");
                }
                else
                {

                    atu = new Actualizar_Tipo_Unidad(operacionesformulario, conexion,Int32.Parse(indice));
                    atu.StartPosition = FormStartPosition.CenterScreen;
                    atu.FormClosed += new System.Windows.Forms.FormClosedEventHandler(atu_FormClosed);
                    atu.Show(this);
                    llenartipounidad();
                }

            }
            catch (Exception es)
            {
                MessageBox.Show(es.ToString());
            }
        }


        private void atu_FormClosed(object sender, FormClosedEventArgs e)
        {
            llenartipounidad();

        }

        private void dataGridViewtipounidad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dataGridViewtipounidad.Rows[e.RowIndex];
            indice = dgv.Cells[0].Value.ToString();
            nombre = dgv.Cells[1].Value.ToString();
        }

        private void botoneliminar_Click(object sender, EventArgs e)
        {
            try
            {


                if (indice == "")
                {
                    MessageBox.Show("Debe seleccionar un registro para eliminar.");
                }
                else
                {
                    String query = "Delete from tipounidad where idTipoUnidad = " + indice;
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = query;
                    cmd.Connection = conexion;
                    operacionesformulario.eliminar(cmd, conexion);
                    llenartipounidad();
                }


            }
            catch (Exception es)
            {
                MessageBox.Show(es.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textobuscar.Text == "")
            {
                MessageBox.Show("Debe ingresar un dato a buscar.");
            }
            else
            {

                if (checkBox1.Checked)
                {

                    String query = "Select idtipounidad as Código_Tipo, nombre as Nombre  from tipounidad where Nombre = " + "'" + textobuscar.Text + "'";
                    operacionesformulario.llenargrid(dataGridViewtipounidad, query, conexion);

                }
                else
                {

                    if (numero(textobuscar.Text))
                    {
                        String query = "Select idtipounidad as Código_Tipo, nombre as Nombre  from tipounidad where idTipoUnidad = " + textobuscar.Text;
                        operacionesformulario.llenargrid(dataGridViewtipounidad, query, conexion);
                    }
                    else
                    {

                        MessageBox.Show("El dato ingresado no es un valor numérico.");

                    }

                }
            }
        }

        private void FormularioTipoUnidad_Load(object sender, EventArgs e)
        {
            llenartipounidad();
            dataGridViewtipounidad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
