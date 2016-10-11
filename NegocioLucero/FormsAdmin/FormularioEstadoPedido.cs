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
    public partial class FormularioEstadoPedido : Form
    {
        OperacionesFormulario operacionesformulario;
        MySqlConnection conexion;
        String indice = "";
        String nombre = "";
        String descripcion = "";
        Actualizar_Estado_Pedido atu;
        public FormularioEstadoPedido(OperacionesFormulario operacionesformulario, MySqlConnection conexion)
        {
            InitializeComponent();
            this.operacionesformulario = operacionesformulario;
            this.conexion = conexion;
        }

        public void llenarestadopedido()
        {
            String query = "Select idestadopedido as Código_Estado_Pedido, Nombre as Nombre, Descripcion as Descripción from estadopedido";
            operacionesformulario.llenargrid(dataGridViewestadopedido, query, conexion);
        }

        public bool numero(string inputvalue)
        {
            Regex cadenaingresada = new Regex("[^0-9]");
            return !cadenaingresada.IsMatch(inputvalue);
        }
        private void FormularioEstadoPedido_Load(object sender, EventArgs e)
        {
            llenarestadopedido();
            dataGridViewestadopedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                        String query = "INSERT into estadopedido(idestadopedido,Nombre,descripcion) values(@id,@name,@descripcion)";
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.CommandText = query;
                        cmd.Connection = conexion;
                        cmd.Parameters.AddWithValue("id", textoid.Text);
                        cmd.Parameters.AddWithValue("name", textonombre.Text);
                        cmd.Parameters.AddWithValue("descripcion",textodescripcion.Text);
                        operacionesformulario.insertar(cmd, conexion);
                        llenarestadopedido();
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

                    String query = "Select idestadopeido as Código_Estado_Pedido, Nombre as Nombre, Descripcion as Descripción from estadopedido where Nombre = " + "'" + textobuscar.Text + "'";
                    operacionesformulario.llenargrid(dataGridViewestadopedido, query, conexion);

                }
                else
                {

                    if (numero(textobuscar.Text))
                    {
                        String query = "Select idestadopedido as Código_Estado_Pedido, Nombre as Nombre, Descripcion as Descripción from estadopedido where idestadopedido = " + textobuscar.Text;
                        operacionesformulario.llenargrid(dataGridViewestadopedido, query, conexion);
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
            DataGridViewRow dgv = dataGridViewestadopedido.Rows[e.RowIndex];
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
                    String query = "Delete from estadopedido where idestadopedido = " + indice;
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = query;
                    cmd.Connection = conexion;
                    operacionesformulario.eliminar(cmd, conexion);
                    llenarestadopedido();
                }


            }
            catch (Exception es)
            {
                MessageBox.Show(es.ToString());
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

                    atu = new Actualizar_Estado_Pedido(operacionesformulario, conexion, Int32.Parse(indice));
                    atu.StartPosition = FormStartPosition.CenterScreen;
                    atu.FormClosed += new System.Windows.Forms.FormClosedEventHandler(atu_FormClosed);
                    atu.Show(this);
                    llenarestadopedido();
                }

            }
            catch (Exception es)
            {
                MessageBox.Show(es.ToString());
            }
        }

        private void atu_FormClosed(object sender, FormClosedEventArgs e)
        {
            llenarestadopedido();

        }


    }
}
