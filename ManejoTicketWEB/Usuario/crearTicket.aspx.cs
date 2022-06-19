using ManejoTicketModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManejoTicketWEB.Usuario
{
    public partial class crearTicket : System.Web.UI.Page
    {
        private static ICategoriaDAL categoriaDAL = new CategoriaDAL();
        private static ITicketDAL ticketDAL = new TicketDAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Categoria> categorias = categoriaDAL.mostrarCategorias();
                if (categorias.Count < 1)
                {
                    this.mensajesLbl.Text = "No hay categorias";
                    this.crearBtn.Enabled = false;
                    this.categoriasDDL.Enabled = false;
                }
                else
                {
                    this.categoriasDDL.DataSource = categorias;
                    this.categoriasDDL.DataTextField = "NombreCategoria";
                    this.categoriasDDL.DataValueField = "CodCategoria";
                    this.categoriasDDL.DataBind();
                }
            }

        }
        protected void crearTicket_Btn(object sender, EventArgs e)
        {

            String nombreUsu = this.nombreTxt.Text.Trim();
            String nombreTec = "";
            String desc = this.nombreTxt.Text.Trim();
            if (!validarCampos(nombreUsu, desc))
            {
                int categoria = Convert.ToInt32(this.categoriasDDL.SelectedValue);
                int prioridad = Convert.ToInt32(this.nvlPrioridad.SelectedValue);
                Categoria cat = categoriaDAL.encontrarCat(categoria);
                Ticket ticket = new Ticket(nombreUsu, nombreTec, desc, cat.NombreCategoria);
                ticket.Estado = TicketDAL.Pendiente;

                switch (prioridad)
                {
                    case 1:
                        ticket.Prioridad = TicketDAL.Emergencia;
                        break;
                    case 2:
                        ticket.Prioridad = TicketDAL.Necesaria;
                        break;
                    case 3:
                        ticket.Prioridad = TicketDAL.Opcional;
                        break;
                }
                ticketDAL.agregarTicket(ticket);
                this.mensajesLbl.Text = "Ticket creado";
                this.nombreTxt.Text = "";
                this.descTxt.Text = "";
                this.categoriasDDL.SelectedIndex = 0;
                this.nvlPrioridad.SelectedIndex = 0;
            }
            else
            {
                this.mensajesLbl.Text = "Campos vacios";
            }

        }

        private bool validarCampos(String nombre, String desc)
        {
            if (nombre.Equals("") || desc.Equals(""))
            {
                return true;
            }
            return false;
        }
    }
}