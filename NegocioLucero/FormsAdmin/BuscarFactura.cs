using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NegocioLucero.FormsAdmin
{
    public partial class BuscarFactura : Form
    {
        OperacionesFormulario operacionesformulario;
        MySqlConnection conexion;
        private DataTable dt = new DataTable();
        DataSet resultados = new DataSet();
        DataView mifiltro = new DataView();
        public BuscarFactura(OperacionesFormulario operacionesformulario, MySqlConnection conexion)
        {
            InitializeComponent();
            this.operacionesformulario = operacionesformulario;
            this.conexion = conexion;
        }

        private void BuscarFactura_Load(object sender, EventArgs e)
        {
            llenargridfacturas();
            dtgridfacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dt = (DataTable)dtgridfacturas.DataSource;
            this.mifiltro = dt.DefaultView;
            this.dtgridfacturas.DataSource = mifiltro;
        }

        public void llenargridfacturas()
        {
            conexion.Close();
            String query = "SELECT Convert(idfactura,Char)as idfactura ,Convert(Cliente_idCliente,Char) as idcliente,FechaFactura,TotalFactura,EstadoFactura_idestadofactura as estadofactura From Factura";
            operacionesformulario.llenargrid(this.dtgridfacturas, query, conexion);

        }

        private void txtidcliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtidcliente_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string salida_datos = "";
                string[] palabras_busqueda = txtidcliente.Text.Split(' ');

                foreach (string palabra in palabras_busqueda)
                {

                    if (salida_datos.Length == 0)
                    {
                        salida_datos = "(idcliente LIKE '%" + palabra + "%' OR idfactura LIKE '%" + palabra + "%') ";

                    }
                    else
                    {
                        salida_datos += "AND(idcliente LIKE '%" + palabra + "%' OR idfactura LIKE '%" + palabra+ "%')";
                    }

                }

                this.mifiltro.RowFilter = salida_datos;
            }
            catch (Exception ex) 
            {

                MessageBox.Show(ex.ToString());
            }
           
        }

    }
}
