<%@ Page Title="Productos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="VictorAlfonso_Diaz.Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div style="padding-top: 60px;">
        <form>
          <div class="row">
            <div class="col-md-4">
              <label for="Clave">Clave del producto</label>
              <asp:TextBox class="form-control"  Width="100%" ID="Clave" runat="server"></asp:TextBox>
            </div>
            <div class="col-md-4">
              <label for="Nombre">Nombre</label>
              <asp:TextBox class="form-control" Width="100%" ID="Nombre" runat="server"></asp:TextBox>
            </div>
            <div class="col-md-4">
              <label for="Descripcion">Descripcion</label>
              <asp:TextBox class="form-control" Width="100%" ID="Descripcion" runat="server"></asp:TextBox>
            </div>
          </div>

            <div class="row">
            <div class="col-md-4">
              <label for="P_Unitario">Precio Unitario</label>
              <asp:TextBox class="form-control"  Width="100%" ID="P_Unitario" runat="server"></asp:TextBox>
            </div>
            <div class="col-md-4">
              <label for="Costo">Costo</label>
              <asp:TextBox class="form-control" Width="100%" ID="Costo" runat="server" AutoPostBack="true" OnTextChanged="Costo_TextChanged"></asp:TextBox>
            </div>
            <div class="col-md-4">
              <label for="Ganancia">Margen de ganancia</label>
              <asp:TextBox class="form-control" Width="100%" ID="Ganancia" runat="server"></asp:TextBox>
            </div>
          </div>

            <div class="row">
            <div class="col-md-4">
              <label for="F_Alta">Fecha de alta</label>
              <asp:TextBox  class="form-control"  Width="100%" ID="F_Alta" runat="server" Type="Date"></asp:TextBox>
            </div>
           
          </div>
       
            <div class="row">

                <br />

                <div class="col-md-4">
                  <asp:Button class="btn btn-primary" ID="Guardar" runat="server" Text="Guardar" OnClick="Guardar_Click"  />
                </div>
           
             </div>
        </form>
    </div>

    <div class="row">

                <br />

                <div >
                    <asp:GridView class="table table-hover" ID="tblProductos" runat="server" AutoGenerateColumns="True" OnRowEditing="tblProductos_RowEditing" OnRowDeleting="tblProductos_RowDeleting" OnRowUpdating="tblProductos_RowUpdating">
                        <Columns>
                            <asp:CommandField ShowEditButton="true" />  
                            <asp:CommandField ShowDeleteButton="true" />
                        </Columns>
                    </asp:GridView>
                </div>
           
             </div>
   

    
</asp:Content>
