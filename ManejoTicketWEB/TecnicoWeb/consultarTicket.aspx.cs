using ManejoTicketModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManejoTicketWEB.TecnicoWeb
{
    public partial class consultarTicket : System.Web.UI.Page
    {
        private static ITecnicoDAL tecnicoDAL = new TecnicoDAL();
        private static ITicketDAL ticketDAL = new TicketDAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Ticket> tickets = ticketDAL.mostrarTicket();
            if (!IsPostBack)
            {
                this.motivoTxt.Enabled = false;

                cargarDatos(tickets);
                if (tickets.Count < 1)
                {
                    this.Estados.Enabled = false;

                }
            }
        }
        protected void grillaTickets_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            List<Ticket> tickets = ticketDAL.mostrarTicket();
            if (e.CommandName.Equals("cambiarEstado"))
            {
                int idTicket = Convert.ToInt32(e.CommandArgument);
                int estadoSel = Convert.ToInt32(this.Estados.SelectedValue);
                Ticket temp = ticketDAL.selTic(tickets, idTicket);
                switch (estadoSel)
                {
                    case 1:
                        temp.Estado = TicketDAL.EnProgreso;
                        break;
                    case 3:
                        temp.Estado = TicketDAL.Bloqueado;
                        this.motivoTxt.Enabled = true;
                        this.Btn_motivoBloqueo.Enabled = true;
                        this.Btn_motivoBloqueo.Click += new EventHandler(this.Btn_motivoBloqueo_Click);
                        this.Btn_motivoBloqueo.CommandArgument =Convert.ToString(idTicket);
                        
                        break;
                    case 5:
                        temp.Estado = TicketDAL.Terminado;
                        break;
                }
                this.mensajesLbl.Text = "Estado cambiado";
                cargarDatos(tickets);
            }
        }

        public void cargarDatos(List<Ticket> tickets)
        {
            this.grillaTickets.DataSource = tickets;
            this.grillaTickets.DataBind();

        }
        public void agregarCom(int idTicket, String mot)
        {
            List<Ticket> tickets = ticketDAL.mostrarTicket();
            Ticket temp = ticketDAL.selTic(tickets, idTicket);
            temp.agregarObservacion(mot);
            
        }

        protected void Btn_motivoBloqueo_Click(object sender, EventArgs e)
        {
            Button regCom = sender as Button;
            String id = regCom.CommandArgument;
            int idTicket = Convert.ToInt32(id);
            String mot = this.motivoTxt.Text.Trim();
            agregarCom(idTicket, mot);
            this.mensajesLbl2.Text = "comentario agregado";
            
        }
    }
}