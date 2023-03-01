<%@ Page Title="Consulta por SP" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductosSP.aspx.cs" Inherits="VictorAlfonso_Diaz.ProductosSP" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div style="padding-top: 60px;">
        <form>
          <div class="row">
            <div class="col-md-4">
             <label for="F_Inicio">Fecha inicio</label>
              <asp:TextBox  class="form-control"  Width="100%" ID="F_Inicio" runat="server" Type="Date"></asp:TextBox>
            </div>
            <div class="col-md-4">
              <label for="F_Final">Fecha final</label>
              <asp:TextBox  class="form-control"  Width="100%" ID="F_Final" runat="server" Type="Date"></asp:TextBox>
            </div>
            <div class="col-md-4">
                
              <label for="Producto">Producto</label>
              <asp:TextBox class="form-control" Width="100%" ID="Producto" runat="server"></asp:TextBox>
            </div>
          </div>
       
            <div class="row">

                <br />

                <div class="col-md-4">
                  <asp:Button class="btn btn-primary" ID="Consultar" runat="server" Text="Consultar" OnClick="Consultar_Click"/>
                </div>
           
             </div>
        </form>
    </div>

    <div class="row">

                <br />

                <div >
                    <asp:GridView class="table table-hover" ID="tblConsulta" runat="server" AutoGenerateColumns="True" >
                        
                    </asp:GridView>
                </div>
           
             </div>

</asp:Content>
