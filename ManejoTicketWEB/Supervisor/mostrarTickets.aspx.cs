using ManejoTicketModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManejoTicketWEB.Supervisor
{
    public partial class mostrarTickets : System.Web.UI.Page
    {
        private static ITecnicoDAL tecnicoDAL = new TecnicoDAL();
        private static ITicketDAL ticketDAL = new TicketDAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Tecnico> tecnicos = tecnicoDAL.mostrarTecnicos();
            List<Ticket> tickets = ticketDAL.mostrarTicket();
            if (!IsPostBack)
            {
                cargarDatos(tickets);
                if (tecnicos.Count < 1)
                {
                    this.mensajesLbl.Text = "No hay tecnicos disponibles";
                    this.tecnicosDDL.Enabled = false;

                }
                else
                {
                    this.tecnicosDDL.DataSource = tecnicos;
                    this.tecnicosDDL.DataTextField = "Nombre";
                    this.tecnicosDDL.DataValueField = "IdTecnico";
                    this.tecnicosDDL.DataBind();
                }
            }
        }

        protected void grillaTickets_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            List<Tecnico> tecnicos = tecnicoDAL.mostrarTecnicos();
            List<Ticket> tickets = ticketDAL.mostrarTicket();
            if (e.CommandName == "asignarTicket")
            {
                int idTicket = Convert.ToInt32(e.CommandArgument);
                int idTec = Convert.ToInt32(this.tecnicosDDL.SelectedValue);
                if (ticketDAL.ticketDisp(tickets,idTicket))
                {
                    String nomTec = tecnicoDAL.encontrarTecnicoId(tecnicos,idTec);
                    Ticket temp = ticketDAL.selTic(tickets,idTicket);

                    temp.NombreTecnico = nomTec;
                    this.mensajesLbl.Text = "Ticket asignado";
                    this.cargarDatos(tickets);
                }
                else
                {
                    this.mensajesLbl.Text = "Ya esta asignado";
                }
               
                
            }
        }

        public void cargarDatos(List<Ticket> tickets)
        {
            this.grillaTickets.DataSource = tickets;
            this.grillaTickets.DataBind();
            
        }

        
    }
}