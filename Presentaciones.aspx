<%@ Page Title="Presentaciones" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Presentaciones.aspx.cs" Inherits="VictorAlfonso_Diaz.Presentaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="padding-top: 60px;">
        <form>
          <div class="row">
            <div class="col-md-4">
              <label for="Producto">Producto</label>
                <asp:DropDownList class="form-control"  Width="100%" ID="Producto" runat="server" DataSourceID="SqlDataSource1" DataTextField="Nombre" DataValueField="ID_Producto" OnSelectedIndexChanged="Producto_SelectedIndexChanged"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:VictorAlfonso_DiazConnectionString %>" SelectCommand="SELECT [ID_Producto], [Nombre] FROM [Cat_Productos]"></asp:SqlDataSource>
            </div>
            <div class="col-md-4">
              <label for="Presentacion">Presentación</label>
              <asp:TextBox class="form-control" Width="100%" ID="Presentacion" runat="server"></asp:TextBox>
            </div>
            <div class="col-md-4">
                
              <label for="Descripcion">Descripcion</label>
              <asp:TextBox class="form-control" Width="100%" ID="Descripcion" runat="server"></asp:TextBox>
            </div>
          </div>
       
            <div class="row">

                <br />

                <div class="col-md-4">
                  <asp:Button class="btn btn-primary" ID="Guardar" runat="server" Text="Guardar"  />
                </div>
           
             </div>
        </form>
    </div>

    <div class="row">

                <br />

                <div >
                    <asp:GridView class="table table-hover" ID="tblPresentacion" runat="server" AutoGenerateColumns="True" OnRowEditing="tblPresentacion_RowEditing" OnRowDeleting="tblPresentacion_RowDeleting" OnRowUpdating="tblPresentacion_RowUpdating">
                        <Columns>
                            <asp:CommandField ShowEditButton="true" />  
                            <asp:CommandField ShowDeleteButton="true" />
                        </Columns>
                    </asp:GridView>
                </div>
           
             </div>
</asp:Content>
