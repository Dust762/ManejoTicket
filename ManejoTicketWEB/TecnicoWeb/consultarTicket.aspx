<%@ Page Title="" Language="C#" MasterPageFile="~/TecnicoWeb/pagTecPrincipal.Master" AutoEventWireup="true" CodeBehind="consultarTicket.aspx.cs" Inherits="ManejoTicketWEB.TecnicoWeb.consultarTicket" %>

<asp:Content ID="mostrarTicketTec" ContentPlaceHolderID="contenidoTecnico" runat="server">
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
                    <asp:Button ID="btnCambiarEst" runat="server" Text="Cambiar estado" CommandName="cambiarEstado" CommandArgument='<%#Eval("idTicket")%>'  />
                </ItemTemplate>
            </asp:TemplateField>
            
        </Columns>
    </asp:GridView>
    <asp:DropDownList ID="Estados" runat="server" CssClass="form-control">
        <asp:ListItem Text="En progreso" Value="1"/>
        <asp:ListItem Text="bloqueado" Value="3"/>
        <asp:ListItem Text="Terminado" Value="5"/>
    </asp:DropDownList>
    
    <label for="motivoTxt" ID="motivo">motivo del bloqueo</label>
    <asp:TextBox ID="motivoTxt" runat="server" CssClass="form-control" ></asp:TextBox>
    <asp:Button ID="Btn_motivoBloqueo" runat="server" Text="Motivo del bloqueo" CommandName="motivoBloqueo" Enabled="false" OnClick="Btn_motivoBloqueo_Click"/>
    <asp:Label runat="server" ID="mensajesLbl" CssClass="text-success"></asp:Label>
    <asp:Label runat="server" ID="mensajesLbl2" CssClass="text-success"></asp:Label>
</asp:Content>
