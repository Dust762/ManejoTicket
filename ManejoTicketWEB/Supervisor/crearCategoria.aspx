<%@ Page Title="" Language="C#" MasterPageFile="~/Supervisor/pagPrincipalSupervisor.Master" AutoEventWireup="true" CodeBehind="crearCategoria.aspx.cs" Inherits="ManejoTicketWEB.Supervisor.crearCategoria" %>

<asp:Content ID="Content2" ContentPlaceHolderID="contenidoSupervisor" runat="server">
    Creando categoria
    <label for="catTxt">Nombre de la categoria:</label>
    <asp:TextBox ID="catTxt" runat="server" CssClass="form-control" ></asp:TextBox>
    <asp:Button runat="server" OnClick="crearCat_Btn" ID="crearBtn" Text="Crear categoria" CssClass="btn btn-success" />
    <asp:Label runat="server" ID="mensajesLbl" CssClass="text-success"></asp:Label>
</asp:Content>
