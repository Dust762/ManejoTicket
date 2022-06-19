<%@ Page Title="" Language="C#" MasterPageFile="~/Usuario/pagPrincipalUsuario.Master" AutoEventWireup="true" CodeBehind="crearTicket.aspx.cs" Inherits="ManejoTicketWEB.Usuario.crearTicket" %>

<asp:Content ID="crearTicketForm" ContentPlaceHolderID="contenidoUsuario" runat="server">
    
    <label for="nombreTxt">Nombre del usuario</label>
    <asp:TextBox ID="nombreTxt" runat="server" CssClass="form-control" ></asp:TextBox>
    <label for="descTxt">Descripcion</label>
    <asp:TextBox ID="descTxt" runat="server" CssClass="form-control" ></asp:TextBox>
    <label for="categorias">Categoria del ticket</label>
    <asp:DropDownList ID="categoriasDDL" runat="server" CssClass="form-control">

    </asp:DropDownList>
    <label for="prioridad" >Prioridad</label>
    <asp:DropDownList ID="nvlPrioridad" runat="server" CssClass="form-control">
        <asp:ListItem Text="Emergencia" Value="1" Selected="True"/>
        <asp:ListItem Text="Necesaria" Value="2" />
        <asp:ListItem Text="Opcional" Value="3" />
    </asp:DropDownList>
    <asp:Label runat="server" ID="mensajesLbl" CssClass="text-success"></asp:Label>
    <asp:Button runat="server" OnClick="crearTicket_Btn" ID="crearBtn" Text="Crear Ticket" CssClass="btn btn-success" />
</asp:Content>
