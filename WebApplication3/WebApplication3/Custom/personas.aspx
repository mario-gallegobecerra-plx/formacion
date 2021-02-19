<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="personas.aspx.cs" Inherits="WebApplication3.Custom.personas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h4>Personas</h4>
  
    <asp:ListView ID="ListView1" runat="server" SelectMethod="Get_Personas" ItemType="WebApplication3.Custom.Personas">
        <ItemTemplate>
            <ul>
                <li>Nombre: <%#:Item.Nombre %></li>
                <li>Apellidos: <%#:Item.Apellidos %></li>
                <li>Edad: <%#:Item.Edad %></li>
                <li>Dirección: <%#:Item.Mail %></li>
            </ul>
            <br />
        </ItemTemplate>
    </asp:ListView>

</asp:Content>
