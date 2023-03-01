using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VictorAlfonso_Diaz.App_Code;

namespace VictorAlfonso_Diaz
{
    public partial class Productos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            getDatos();
        }

        private void getDatos()
        {
            DSProductosTableAdapters.Cat_ProductosTableAdapter ta =
                new DSProductosTableAdapters.Cat_ProductosTableAdapter();

            DSProductos.Cat_ProductosDataTable dt = ta.GetData();
            tblProductos.DataSource = dt;
            tblProductos.DataBind();
        }


        protected void Guardar_Click(object sender, EventArgs e)
        {
            DSProductosTableAdapters.Cat_ProductosTableAdapter ta =
               new DSProductosTableAdapters.Cat_ProductosTableAdapter();

            ta.Insert(
                Clave.Text,
                Nombre.Text,
                Descripcion.Text,
                Convert.ToDecimal(P_Unitario.Text),
                Convert.ToDecimal(Costo.Text),
                Ganancia.Text,
                Convert.ToDateTime(F_Alta.Text)
                );

            getDatos();
        }

        protected void tblProductos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            tblProductos.EditIndex = e.NewEditIndex;
            getDatos();
        }

        protected void tblProductos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = (GridViewRow)tblProductos.Rows[e.RowIndex];
            DSProductosTableAdapters.Cat_ProductosTableAdapter ta =
              new DSProductosTableAdapters.Cat_ProductosTableAdapter();
            ta.Delete(row.RowIndex);
            getDatos();
        }

        protected void tblProductos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            
            GridViewRow row = (GridViewRow)tblProductos.Rows[e.RowIndex];

            TextBox ID = (TextBox)row.Cells[2].Controls[0];
            TextBox Clave = (TextBox)row.Cells[3].Controls[0];
            TextBox Nombre = (TextBox)row.Cells[4].Controls[0];
            TextBox Descripcion = (TextBox)row.Cells[5].Controls[0];
            TextBox Prec_Un = (TextBox)row.Cells[6].Controls[0];
            TextBox Costo = (TextBox)row.Cells[7].Controls[0];
            TextBox Ganancia = (TextBox)row.Cells[8].Controls[0];
            TextBox Fe_Insersion = (TextBox)row.Cells[9].Controls[0];

            DSProductosTableAdapters.Cat_ProductosTableAdapter ta =
              new DSProductosTableAdapters.Cat_ProductosTableAdapter();

            ta.Update(
                Clave.Text, 
                Nombre.Text, 
                Descripcion.Text, 
                Convert.ToDecimal(Prec_Un.Text), 
                Convert.ToDecimal(Costo.Text), 
                Ganancia.Text,
                Convert.ToDateTime(Fe_Insersion.Text), 
                Convert.ToInt32(ID.Text)
                );

            getDatos();

        }

        protected void Costo_TextChanged(object sender, EventArgs e)
        {
            decimal Resta = (Convert.ToInt32(Costo.Text) - Convert.ToInt32(P_Unitario.Text));

            decimal Porcentaje = ((Resta / Convert.ToInt32(P_Unitario.Text))*100);

            Ganancia.Text = Porcentaje.ToString() + "%";



        }
    }
}