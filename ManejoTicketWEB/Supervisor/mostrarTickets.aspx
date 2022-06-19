<%@ Page Title="" Language="C#" MasterPageFile="~/Supervisor/pagPrincipalSupervisor.Master" AutoEventWireup="true" CodeBehind="mostrarTickets.aspx.cs" Inherits="ManejoTicketWEB.Supervisor.mostrarTickets" %>

<asp:Content ID="mostrarTicketsSup" ContentPlaceHolderID="contenidoSupervisor" runat="server">
    <asp:GridView runat="server" CssClass="table table-hover table-dark" ID="grillaTickets" AutoGenerateColumns="false" OnRowCommand="grillaTickets_RowCommand" EmptyDataText="No hay tickets" ShowHeaderWhenEmpty="true">
        <Columns>
            <asp:BoundField DataField="idTicket" HeaderText="ID del ticket" />
            <asp:BoundField DataField="NombreUsuario" HeaderText="Nombre del usuario" />
            <asp:BoundField DataField="NombreTecnico" HeaderText="Nombre del tecnico" />
            <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
            <asp:BoundField DataField="Categoria" HeaderText="Categoria" />
            <asp:BoundField DataField="Estado.estadoNombre" HeaderText="Estado del ticket" />
            <asp:BoundField DataField="Prioridad.Nombre" HeaderText="Prioridad del ticket" />


            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="btnAsignar" runat="server" Text="Asignar ticket" CommandName="asignarTicket" CommandArgument='<%#Eval("idTicket")%>'  />
                </ItemTemplate>
            </asp:TemplateField>
            
        </Columns>
    </asp:GridView>
    <asp:DropDownList ID="tecnicosDDL" runat="server" CssClass="form-control">
    </asp:DropDownList>

    <asp:Label runat="server" ID="mensajesLbl" CssClass="text-success"></asp:Label>
</asp:Content>
