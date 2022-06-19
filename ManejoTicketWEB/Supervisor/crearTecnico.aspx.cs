using ManejoTicketModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManejoTicketWEB.Supervisor
{
    public partial class crearTecnico : System.Web.UI.Page
    {
        private static ITecnicoDAL tecnicoDAL = new TecnicoDAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            

        }
        protected void crearTec_Btn(object sender, EventArgs e)
        {
            String rut = this.rutTxt.Text.Trim();
            String nombre = this.nombreTec.Text.Trim();
            String apellido = this.apellidoTec.Text.Trim();
            if (validar(rut,nombre,apellido))
            {
                List<Tecnico> temp = tecnicoDAL.mostrarTecnicos();
                if (!tecnicoDAL.encontrarTecnico(temp,rut))
                {
                    String sexo = this.sexoRbl.SelectedValue;
                    Tecnico t = new Tecnico(rut, nombre, apellido, sexo);
                    tecnicoDAL.agregarTecnico(t);
                    this.mensajesLbl.Text = "Tecnico creado";
                }
                else
                {
                    this.mensajesLbl.Text = "Ya existe";
                }
                
            }
            else
            {
                this.mensajesLbl.Text = "campo vacio";
            }
            
        }
        private bool validar(String r, String n, String a)
        {
            if (!r.Equals("") || !n.Equals("") || !a.Equals(""))
            {
                return true;
            }
            return false;
        }
    }
}