using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ManejoTicketModelo;
namespace ManejoTicketWEB.Supervisor
{
    public partial class consultarTecnicos : System.Web.UI.Page
    {

        private ITecnicoDAL tecnicoDAL = new TecnicoDAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            // Nos asegurarmos que cargue al inicio (GET)
            if (!IsPostBack)
            {
                CargarGrilla();
                
            }
        }

        protected void GrillaTecnicos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            // la letra "e" trae al metodo los argumentos recibidos por el escuchador
            if (e.CommandName == "eliminar")
            {
                // rescatamos el run recibido por el metodo
                string rut = Convert.ToString(e.CommandArgument);
                List<Tecnico> temp = tecnicoDAL.mostrarTecnicos();
                for (int i = 0; i < temp.Count; i++)
                {
                    if (temp[i].Rut == rut)
                    {
                        tecnicoDAL.eliminarTecnico(temp[i]);
                        CargarGrilla();
                        break;
                    }

                }

            }
            else if (e.CommandName == "mostrarTickets")
            {
                Tecnico temporal = null;
                int idTec = Convert.ToInt32(e.CommandArgument);
                List<Tecnico> temp = tecnicoDAL.mostrarTecnicos();
                //temp.FindAll(tec => tec.IdTecnico == idTec);
                for (int i = 0; i < temp.Count; i++)
                {
                    if (temp[i].IdTecnico == idTec)
                    {
                        temporal = temp[i];
                        break;
                    }
                }
                if (temporal.mostrarTicketsAsignados().Count > 0)
                {
                    
                    temporal.mostrarTicketsAsignados();
                    
                }
            }
        }
        
        public void CargarGrilla()
        {
            
            //3 creamos una lista igual a la del clienteDAL
            List<Tecnico> tecnicos = tecnicoDAL.mostrarTecnicos();
            // 4cargamos el listado a la grilla
            this.GrillaTecnicos.DataSource = tecnicos;
            this.GrillaTecnicos.DataBind();
            //5 recargamos la grilla con la configuración indicada
           
        }
    }
}

