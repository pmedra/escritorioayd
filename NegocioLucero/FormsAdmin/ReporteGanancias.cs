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
    public partial class ReporteGanancias : Form
    {
        OperacionesFormulario operacionesformulario;
        MySqlConnection conexion;
        public ReporteGanancias(OperacionesFormulario operacionesformulario, MySqlConnection conexion)
        {
            InitializeComponent();
            this.operacionesformulario = operacionesformulario;
            this.conexion = conexion;
        }

        private void ReporteGanancias_Load(object sender, EventArgs e)
        {
            llenargridGanancias();
            dtgridganancias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            actualizartotal();
        }
        public void llenargridGanancias()
        {
            conexion.Close();
            String query = "SELECT idFactura,FechaFactura,TotalFactura,Sum(Ganancia)As Ganancia FROM ( Select (SUM(P.precioventa-P.preciocompra))*PF.CantidadVendida as Ganancia,PF.CantidadVendida,F.idFactura,F.FechaFactura, P.idProducto,F.TotalFactura  from producto P, productofactura PF, Factura F "
 + " where p.idproducto=PF.Producto_idProducto AND PF.Factura_idFactura=F.idfactura group by PF.Producto_idProducto asc, PF.Factura_idfactura asc) as tabla group by tabla.idfactura ";

            operacionesformulario.llenargrid(this.dtgridganancias, query, conexion);

        }

        public void actualizartotal()
        {
            Decimal result = dtgridganancias.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDecimal(x.Cells["Ganancia"].Value));
            txtganancias.Text = result.ToString();
           // total = result;
        }

    }
}
