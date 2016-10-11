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
    public partial class FormularioCategoria : Form
    {
        OperacionesFormulario operacionesformulario;
        MySqlConnection conexion;
        String nombrecategoria = "";
        String Descripcioncategoria = "";
        int indice = 0;
        public FormularioCategoria(OperacionesFormulario operacionesformulario,MySqlConnection conexion)
        {
            InitializeComponent();
            this.operacionesformulario = operacionesformulario;
            this.conexion = conexion;
        }

        private void FormularioCategoria_Load(object sender, EventArgs e)
        {
            llenarcategorias();

            DtgridCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }

        public void llenarcategorias() {
            String query = "Select * from Categoria";
            operacionesformulario.llenargrid(DtgridCategoria, query, conexion);


        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            String nombre = txtnombrecat.Text;
            String descripcion = txtdesccat.Text;
            try { 
            if (nombre.Equals(""))
            {
                MessageBox.Show("Debe ingresar un nombre a la categoria");
            }
            else
            {
                String query = "insert into Categoria(nombre,Descripcion) values (@nombre,@descripcion)";

                MySqlCommand cmd = new MySqlCommand();
                //MySqlDataReader reader;

                cmd.CommandText = query;
                // cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                cmd.Parameters.AddWithValue("nombre",nombre);
                cmd.Parameters.AddWithValue("descripcion", descripcion);
                operacionesformulario.insertar(cmd, conexion);
                llenarcategorias();

            }
                }
            
            catch(Exception es){
                MessageBox.Show(es.ToString());
                }

        }

        private void DtgridCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void DtgridCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = DtgridCategoria.Rows[rowIndex];
             indice=Convert.ToInt32(row.Cells[0].Value.ToString());
            string nombre=row.Cells[1].Value.ToString();
            string descripcion=row.Cells[2].Value.ToString();
            txtnombrecat.Text=nombre;
             txtdesccat.Text=descripcion;
             nombrecategoria = row.Cells[1].Value.ToString();
             Descripcioncategoria= row.Cells[2].Value.ToString();

            MessageBox.Show(indice.ToString()+nombre+descripcion);
            // textBox5.Text = dataGridView1.Rows[1].Cells[1].Value.ToString();// row.Cells[1].Value;
            MessageBox.Show(DtgridCategoria.Rows[rowIndex].Cells[2].Value.ToString());
     
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            String nombre = txtnombrecat.Text;
            String descripcion = txtdesccat.Text;
            try
            {
                if (nombre.Equals(""))
                {
                    MessageBox.Show("Debe ingresar un nombre a la categoria");
                }
                else
                {
                    String query = "Update Categoria Set Nombre=@nombre, Descripcion=@descripcion Where idcategoria=@indice";

                    MySqlCommand cmd = new MySqlCommand();
                    //MySqlDataReader reader;

                    cmd.CommandText = query;
                    // cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    cmd.Parameters.AddWithValue("nombre", nombre);
                    cmd.Parameters.AddWithValue("descripcion", descripcion);
                    cmd.Parameters.AddWithValue("indice", indice);
                    operacionesformulario.insertar(cmd, conexion);
                    llenarcategorias();

                }
            }

            catch (Exception es)
            {
                MessageBox.Show(es.ToString());
            }


        }

       
    }


}
