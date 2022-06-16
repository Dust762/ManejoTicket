using ManejoTicketModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManejoTicketWEB.Supervisor
{
    public partial class crearCategoria : System.Web.UI.Page
    {
        private static ICategoriaDAL categoriaDAL = new CategoriaDAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void crearCat_Btn(object sender, EventArgs e)
        {
            List<Categoria> categorias = categoriaDAL.mostrarCategorias();
            String nomcategoria = this.catTxt.Text.Trim();
            if (!nomcategoria.Equals(""))
            {
                Categoria cat = new Categoria(nomcategoria);
                if (!encontrado(categorias,cat))
                {
                    categorias.Add(cat);

                    this.mensajesLbl.Text = "Creado";
                    
                }
                else
                {
                    this.mensajesLbl.Text = "ya existe";
                    
                }
                //Response.Redirect("inicioSup.aspx");
            }
            else
            {
                this.mensajesLbl.Text = "Campo vacio";
            }
        }
        private bool encontrado(List<Categoria> c, Categoria cat)
        {
            for (int i = 0; i < c.Count; i++)
            {
                if (c[i].NombreCategoria.Equals(cat.NombreCategoria))
                {
                    
                    return true;
                }
                
            }
            return false;
        }
    }
}