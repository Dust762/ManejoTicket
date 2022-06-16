<%@ Page Title="" Language="C#" MasterPageFile="~/Supervisor/pagPrincipalSupervisor.Master" AutoEventWireup="true" CodeBehind="crearTecnico.aspx.cs" Inherits="ManejoTicketWEB.Supervisor.crearTecnico" %>

<asp:Content ID="Content2" ContentPlaceHolderID="contenidoSupervisor" runat="server">
    Creando tecnico
    
    <label for="rutTxt">Rut:</label>
    <asp:TextBox ID="rutTxt" runat="server" CssClass="form-control" ></asp:TextBox>
    <label for="nombreTec">Nombre del tecnico:</label>
    <asp:TextBox ID="nombreTec" runat="server" CssClass="form-control"></asp:TextBox>
    <label for="apellidoTec">Apellido del tecnico:</label>
    <asp:TextBox ID="apellidoTec" runat="server" CssClass="form-control"></asp:TextBox>
    <label for="Sexo">Sexo del tecnico</label>
    <asp:RadioButtonList ID="sexoRbl" runat="server" CssClass="" RepeatDirection="Horizontal">
        <asp:ListItem Value="F" Text="Femenino" Selected="True"></asp:ListItem>
        <asp:ListItem Value="M" Text="Masculino"></asp:ListItem>
    </asp:RadioButtonList>
    
    <asp:Button runat="server" OnClick="crearTec_Btn" ID="crearBtn" Text="Crear tecnico" CssClass="btn btn-success" />

    <asp:Label runat="server" ID="mensajesLbl" CssClass="text-success"></asp:Label>
</asp:Content>
