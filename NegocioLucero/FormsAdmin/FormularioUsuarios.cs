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
    public partial class FormularioUsuarios : Form
    {

        OperacionesFormulario operacionesformulario;
        MySqlConnection conexion;
        Actualizar_Usuario actuser;
        String indice ="";
        String nombre = "";
        String fecha = "";
        String contra = "";
        String activo = "";
        String rol = "";
        public FormularioUsuarios(OperacionesFormulario operacionesformulario, MySqlConnection conexion)
        {
            InitializeComponent();
            this.operacionesformulario = operacionesformulario;
            this.conexion = conexion;
        }

        public void llenarusuarios() {
            String query = "Select idusuario as Codigo_Usuario, nombre as Nombre, fechadecreacion as Fecha_Creado, password as Contraseña, activo as Estado, tipousuario_idtipousuario as Rol from usuario";
            operacionesformulario.llenargrid(dataGridViewUser, query, conexion);
        }

        

        private void FormularioUsuarios_Load(object sender, EventArgs e)
        {
            llenarusuarios();
            dataGridViewUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        public bool numero(string inputvalue)
        {
            Regex cadenaingresada = new Regex("[^0-9]");
            return !cadenaingresada.IsMatch(inputvalue);
        }

        private void botonbuscar_Click(object sender, EventArgs e)
        {
          
            if (textobuscar.Text == "")
            {
                MessageBox.Show("Debe ingresar un dato a buscar.");
            }
            else {

                if (checkBox2.Checked)
                {

                    String query = "Select idusuario as Codigo_Usuario, nombre as Nombre, fechadecreacion as Fecha_Creado, password as Contraseña, activo as Estado, tipousuario_idtipousuario as Rol from usuario where Nombre = " + "'" + textobuscar.Text + "'";
                    operacionesformulario.llenargrid(dataGridViewUser, query, conexion);

                }
                else {

                    if (numero(textobuscar.Text))
                    {
                        String query = "Select idusuario as Codigo_Usuario, nombre as Nombre, fechadecreacion as Fecha_Creado, password as Contraseña, activo as Estado, tipousuario_idtipousuario as Rol from usuario where idUsuario = " + textobuscar.Text;
                        operacionesformulario.llenargrid(dataGridViewUser, query, conexion);
                    }
                    else
                    {

                        MessageBox.Show("El dato ingresado no es un valor numérico.");

                    }

                }

               
            
            }
            
        }

        private void botonagregar_Click(object sender, EventArgs e)
        {

            if (textonombre.Text == "" || textocontrasena.Text == "" || textocontrasena2.Text == "" || comboBox1.Text == "")
            {

                MessageBox.Show("Debe rellenar todos los campos.");

            }
            else {

                if (textocontrasena.Text != textocontrasena2.Text)
                {

                    MessageBox.Show("Las contraseñas no coinciden.");

                }
                else {


                    String nombre = textonombre.Text;
                    String contra = textocontrasena.Text;
                    int activo = 0;
                    int rol = 0;
                    if (checkBox1.Checked) {
                        activo = 1;
                    }
                    if (comboBox1.SelectedIndex == 0)
                    {
                        rol = 1;
                    }
                    else {
                        rol = 2;
                    }


                    try
                    {

                        String query = "INSERT into usuario(Nombre,FechadeCreacion,Password,Activo,Tipousuario_idTipousuario) values(@user,Now(),md5(@contra),@active,@type)";
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.CommandText = query;
                        cmd.Connection = conexion;
                        cmd.Parameters.AddWithValue("user", nombre);
                        cmd.Parameters.AddWithValue("contra", contra);
                        cmd.Parameters.AddWithValue("active", activo);
                        cmd.Parameters.AddWithValue("type", rol);
                        operacionesformulario.insertar(cmd, conexion);
                        llenarusuarios();
                        limpiar();

                    }
                    catch (Exception es)
                    {
                        MessageBox.Show(es.ToString());
                    }


                }

            }


        }

        private void botoneliminar_Click(object sender, EventArgs e)
        {

            try {


                if (indice == "")
                {
                    MessageBox.Show("Debe seleccionar un registro para eliminar.");
                }
                else
                {
                    String query = "Delete from usuario where idUsuario = " + indice;
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = query;
                    cmd.Connection = conexion;
                    operacionesformulario.eliminar(cmd, conexion);
                    llenarusuarios();
                }
            

                } catch (Exception es)
                    {
                        MessageBox.Show(es.ToString());
                    }

           

        }

        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow dgv = dataGridViewUser.Rows[e.RowIndex];
            indice = dgv.Cells[0].Value.ToString();
            nombre = dgv.Cells[1].Value.ToString();
            fecha = dgv.Cells[2].Value.ToString();
            contra = dgv.Cells[3].Value.ToString();
            activo = dgv.Cells[4].Value.ToString();
            rol = dgv.Cells[5].Value.ToString();

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

                    actuser = new Actualizar_Usuario(operacionesformulario, conexion, Int32.Parse(indice), nombre, Int32.Parse(activo), Int32.Parse(rol));
                    actuser.StartPosition = FormStartPosition.CenterScreen;
                    actuser.FormClosed += new System.Windows.Forms.FormClosedEventHandler(actuser_FormClosed);
                    actuser.Show(this);
                    llenarusuarios();
                }

            }
            catch (Exception es)
            {
                MessageBox.Show(es.ToString());
            }


        }


        private void actuser_FormClosed(object sender, FormClosedEventArgs e)
        {
            llenarusuarios();

        }

        public void limpiar() {
            textonombre.Clear();
            textocontrasena.Clear();
            textocontrasena2.Clear();
            comboBox1.Text = "";

        }

    }
}
