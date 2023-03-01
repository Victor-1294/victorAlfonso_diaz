using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VictorAlfonso_Diaz.App_Code;

namespace VictorAlfonso_Diaz
{
    public partial class ProductosSP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Consultar_Click(object sender, EventArgs e)
        {
            DSProductosTableAdapters.sp_ConsultaProductoPresentacionTableAdapter ta = 
                new DSProductosTableAdapters.sp_ConsultaProductoPresentacionTableAdapter();

            DSProductos.sp_ConsultaProductoPresentacionDataTable dt = ta.GetData(
                F_Inicio.Text,
                F_Final.Text,
                Producto.Text
                );

            tblConsulta.DataSource = dt;
            tblConsulta.DataBind();

        }
    }
}