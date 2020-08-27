using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using WebApplication2.DAO;

namespace WebApplication2
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        #region MENU 
        #endregion  MODAL ARTÍCULOS   

        private void CargarMenu()
        {
            try
            {
                Menu obMenuE = new Menu();
                MenuDAO obMenuL = new MenuDAO();
                // string usuarioLogin = (Session["LoginCRM"] as UsuarioE).PK_Usuario;


                int Cedula = 1;
                int FK_PERFIL = 1;
               

                List<Models.Menu> listaMenuPadre = new List<Models.Menu>();
                List<Models.Menu> listaMenuHijos = new List<Models.Menu>();
                List<Models.Menu> listaMenu = new List<Models.Menu>();
                listaMenu = obMenuL.consultamenu("1", "1");

                listaMenuPadre = listaMenu.ToList().Where(x => x.CODIGO_PADRE == "0").ToList();

                MenuPrincipal.InnerHtml =
                  "<li class='nav - item'> <a class='nav-link' href='Default.aspx'><i class='fa fa-home'></i>&nbsp; Inicio<span class='sr-only'></span></a></li>";


                foreach (MenuE iMenu in listaMenuPadre)
                {
                    listaMenuHijos = listaMenu.ToList().Where(x => x.CODIGO_PADRE == iMenu.PK_TBL_CRM_SEG_MENU.ToString()).ToList();

                    if (listaMenuHijos.Count <= 0)
                    {
                        if (iMenu.CODIGO_PADRE == "0")
                        {
                            MenuPrincipal.InnerHtml +=
                       "<li class='nav - item'> <a class='nav-link' href='" + iMenu.URL + "'><i class='" + iMenu.ICONO + "'></i>&nbsp; " + iMenu.DESCRIPCION + "<span class='sr-only'></span></a></li>";
                        }
                    }
                    else
                    {
                        /*MENU HIJOS*/
                        if (iMenu.CODIGO_PADRE == "0")
                        {
                            MenuPrincipal.InnerHtml += "<li class='dropdown'>";
                            MenuPrincipal.InnerHtml += "<a class='nav-link dropdown-toggle'  id='ND" + iMenu.DESCRIPCION + "' role='button' "
                              + "data-toggle = 'dropdown' aria-haspopup = 'true' aria-expanded = 'false' > " +
                              " <i class='" + iMenu.ICONO + "' aria-hidden='true'></i>&nbsp;" + iMenu.DESCRIPCION + " </a>";
                            MenuPrincipal.InnerHtml += "<ul class='dropdown-menu' aria-labelledby='ND" + iMenu.DESCRIPCION + "'>";
                        }

                        foreach (MenuE iMenuHijos in listaMenuHijos)
                        {
                            ObtenerSubMenus(iMenuHijos, listaMenu);
                        }

                        if (iMenu.CODIGO_PADRE == "0")
                        {
                            MenuPrincipal.InnerHtml += "</ul>";
                            MenuPrincipal.InnerHtml += "</li>";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string mesage = ex.Message;
                throw;
            }

        }

        private void ObtenerSubMenus(MenuE pMenuHijos, List<MenuE> plistaMenu)
        {
            try
            {
                List<MenuE> listaMenuHijos = new List<MenuE>();
                List<MenuE> listaMenuTieneHijos = new List<MenuE>();
                List<MenuE> listaMenu = plistaMenu;

                listaMenuHijos = listaMenu.ToList().Where(x => x.CODIGO_PADRE == pMenuHijos.PK_TBL_CRM_SEG_MENU.ToString()).ToList();
                if (listaMenuHijos.Count == 0)
                {
                    MenuPrincipal.InnerHtml += "<li><a class='nav-link' href='" + pMenuHijos.URL + "'><i class='" + pMenuHijos.ICONO + "'></i>&nbsp;" + pMenuHijos.DESCRIPCION + "</a></li>";
                    return;
                }

                MenuPrincipal.InnerHtml += "<li class='dropdown'>";
                MenuPrincipal.InnerHtml += "<a class='nav-link dropdown-toggle'  id='ND" + pMenuHijos.DESCRIPCION + "' role='button' "
                          + "data-toggle = 'dropdown' aria-haspopup = 'true' aria-expanded = 'false' > " +
                          " <i class='" + pMenuHijos.ICONO + "' aria-hidden='true'></i>&nbsp;" + pMenuHijos.DESCRIPCION + " </a>";
                MenuPrincipal.InnerHtml += "<ul class='dropdown-menu' aria-labelledby='ND" + pMenuHijos.DESCRIPCION + "'>";

                foreach (MenuE iMenuHijos in listaMenuHijos)
                {
                    ObtenerSubMenus(iMenuHijos, listaMenu);
                }

                MenuPrincipal.InnerHtml += "</ul>";
                MenuPrincipal.InnerHtml += "</li>";

            }
            catch (Exception ex)
            {
                string mesage = ex.Message;
                throw;
            }
        }
    }
}