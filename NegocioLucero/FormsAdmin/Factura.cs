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
    public partial class Factura : Form
    {
        private DataSet ds;
        private string p1;
        private string p2;
        private string p3;
        private string p4;

        /*public Factura()
        {
            
        }*/



        public Factura(DataSet ds, string p1, string p2, string p3,string p4)
        {
            // TODO: Complete member initialization
            this.ds = ds;
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
            InitializeComponent();
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            try
            {
                FacturaGenerada cr = new FacturaGenerada();
                cr.SetDataSource(ds);
                cr.SetParameterValue("idcliente",p1);
                cr.SetParameterValue("nombrecliente",p2);
                cr.SetParameterValue("total",p3);
                cr.SetParameterValue("No.Factura", p4);

                crystalReportViewer1.ReportSource = cr;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }



    }
}
