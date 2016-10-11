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
    public partial class FormularioEstadoProducto : Form
    {
        OperacionesFormulario operacionesformulario;
        MySqlConnection conexion;
        String indice = "";
        String nombre = "";
        String descripcion = "";
        public FormularioEstadoProducto(OperacionesFormulario operacionesformulario, MySqlConnection conexion)
        {
            InitializeComponent();
            this.operacionesformulario = operacionesformulario;
            this.conexion = conexion;
        }

        public void llenarestadoproducto()
        {
            String query = "Select idestadoproducto as Código_Estado, Nombre as Nombre, Descripcion as Descripción from estadoproducto";
            operacionesformulario.llenargrid(dataGridViewestadoproducto, query, conexion);
        }

        public bool numero(string inputvalue)
        {
            Regex cadenaingresada = new Regex("[^0-9]");
            return !cadenaingresada.IsMatch(inputvalue);
        }
        private void FormularioEstadoProducto_Load(object sender, EventArgs e)
        {
            llenarestadoproducto();
            dataGridViewestadoproducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void botonagregar_Click(object sender, EventArgs e)
        {

            if (textonombre.Text == "" || textoid.Text == "" || textodescripcion.Text == "")
            {
                MessageBox.Show("Debe rellenar todos los campos.");
            }
            else {

                try {

                    if (numero(textoid.Text))
                    {
                        String query = "INSERT into estadoproducto(idestadoproducto,Nombre,descripcion) values(@id,@name,@descripcion)";
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.CommandText = query;
                        cmd.Connection = conexion;
                        cmd.Parameters.AddWithValue("id", textoid.Text);
                        cmd.Parameters.AddWithValue("name", textonombre.Text);
                        cmd.Parameters.AddWithValue("descripcion",textodescripcion.Text);
                        operacionesformulario.insertar(cmd, conexion);
                        llenarestadoproducto();
                        textonombre.Text = "";
                        textoid.Text = "";
                        textodescripcion.Text = "";
                    }
                    else {
                        MessageBox.Show("El código no es un valor numérico.");
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
                MessageBox.Show("Debe ingresar un dato a buscar.");
            }
            else
            {

                if (checkBox1.Checked)
                {

                    String query = "Select idestadoproducto as Código_Estado, Nombre as Nombre, Descripcion as Descripción from estadoproducto where Nombre = " + "'" + textobuscar.Text + "'";
                    operacionesformulario.llenargrid(dataGridViewestadoproducto, query, conexion);

                }
                else
                {

                    if (numero(textobuscar.Text))
                    {
                        String query = "Select idestadoproducto as Código_Estado, Nombre as Nombre, Descripcion as Descripción from estadoproducto where idestadoproducto = " + textobuscar.Text;
                        operacionesformulario.llenargrid(dataGridViewestadoproducto, query, conexion);
                    }
                    else
                    {

                        MessageBox.Show("El dato ingresado no es un valor numérico.");

                    }

                }
            }
        }

        private void dataGridViewestadoproducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dataGridViewestadoproducto.Rows[e.RowIndex];
            indice = dgv.Cells[0].Value.ToString();
            nombre = dgv.Cells[1].Value.ToString();
            descripcion = dgv.Cells[2].Value.ToString();
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
                    String query = "Delete from estadoproducto where idestadoprodcuto = " + indice;
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = query;
                    cmd.Connection = conexion;
                    operacionesformulario.eliminar(cmd, conexion);
                    llenarestadoproducto();
                }


            }
            catch (Exception es)
            {
                MessageBox.Show(es.ToString());
            }
        }



    }
}
