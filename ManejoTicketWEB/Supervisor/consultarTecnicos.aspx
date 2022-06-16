<%@ Page Title="" Language="C#" MasterPageFile="~/Supervisor/pagPrincipalSupervisor.Master" AutoEventWireup="true" CodeBehind="consultarTecnicos.aspx.cs" Inherits="ManejoTicketWEB.Supervisor.consultarTecnicos" %>

<asp:Content ID="Content2" ContentPlaceHolderID="contenidoSupervisor" runat="server">
    Consultando tecnico
   
    
    <asp:GridView runat="server" CssClass="table table-hover table-dark"
     ID="GrillaTecnicos" AutoGenerateColumns="false" OnRowCommand="GrillaTecnicos_RowCommand" EmptyDataText="No se registran datos" ShowHeaderWhenEmpty="true">
        <Columns>
            <asp:BoundField DataField="Rut" HeaderText="Rut del Tecnico" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
            <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
            <asp:BoundField DataField="Sexo" HeaderText="Sexo" />

            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button
                        runat="server"
                        CssClass="btn btn-danger"
                        Text="Eliminar" CommandName="eliminar" CommandArgument='<%# Eval("Rut") %>' />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

    </asp:GridView>
</asp:Content>
