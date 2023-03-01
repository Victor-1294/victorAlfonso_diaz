using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VictorAlfonso_Diaz.App_Code;

namespace VictorAlfonso_Diaz
{
    public partial class Presentaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            getDatos();
        }

        private void getDatos()
        {

            DSProductosTableAdapters.Cat_PresentacionesTableAdapter ta =
                new DSProductosTableAdapters.Cat_PresentacionesTableAdapter();


            DSProductos.Cat_PresentacionesDataTable dt = ta.GetData();

            tblPresentacion.DataSource = dt;
            tblPresentacion.DataBind();
        }

        protected void tblPresentacion_RowEditing(object sender, GridViewEditEventArgs e)
        {
            tblPresentacion.EditIndex = e.NewEditIndex;
            getDatos();
        }

        protected void tblPresentacion_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = (GridViewRow)tblPresentacion.Rows[e.RowIndex];

            DSProductosTableAdapters.Cat_PresentacionesTableAdapter ta = new DSProductosTableAdapters.Cat_PresentacionesTableAdapter();
            ta.Delete(row.RowIndex);
            getDatos();
        }

        protected void tblPresentacion_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = (GridViewRow)tblPresentacion.Rows[e.RowIndex];

            TextBox ID = (TextBox)row.Cells[2].Controls[0];
            TextBox Producto = (TextBox)row.Cells[3].Controls[0];
            TextBox Presentacion = (TextBox)row.Cells[4].Controls[0];
            TextBox Descripcion = (TextBox)row.Cells[5].Controls[0];


            DSProductosTableAdapters.Cat_PresentacionesTableAdapter ta = new DSProductosTableAdapters.Cat_PresentacionesTableAdapter();

            ta.Update(
                Convert.ToInt32(Producto.Text),
                Presentacion.Text,
                Descripcion.Text,
                Convert.ToInt32(ID.Text)
                );

            getDatos();
        }

        

        protected void Producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            DSProductosTableAdapters.Cat_PresentacionesTableAdapter ta = new DSProductosTableAdapters.Cat_PresentacionesTableAdapter();
            ta.Insert(
                Convert.ToInt32(Producto.Text),
                Presentacion.Text,
                Descripcion.Text
                );

            getDatos();
        }
    }
}