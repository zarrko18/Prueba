using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Menu
    {
        
        public string PK_PK_ID_MENU { set; get; }
        public string CODIGO_PADRE { set; get; }
        public string ICONO { set; get; }
        public string URL { set; get; }
        public string DESCRIPCION { set; get; }
        public string ESTADO_MENU { set; get; }
        public string CREAR_MENU { set; get; }
        public string VER_MENU { set; get; }
        public string EDTITAR_MENU { set; get; }
        public string ESTADO_PERMISO { set; get; }
        public string EDITAR_PERMISO { set; get; }
        public string VER_PERMISO { set; get; }
        public string CREAR_PERMISO { set; get; }
        public Menu() { 
        
        }
        public Menu(string pK_PK_ID_MENU, string cODIGO_PADRE, string iCONO, string uRL, string dESCRIPCION, string cREAR_MENU, string vER_MENU, string eDTITAR_MENU, string eSTADO_PERMISO, string eDITAR_PERMISO, string vER_PERMISO, string cREAR_PERMISO)
        {
            PK_PK_ID_MENU = pK_PK_ID_MENU;
            CODIGO_PADRE = cODIGO_PADRE;
            ICONO = iCONO;
            URL = uRL;
            DESCRIPCION = dESCRIPCION;
            CREAR_MENU = cREAR_MENU;
            VER_MENU = vER_MENU;
            EDTITAR_MENU = eDTITAR_MENU;
            ESTADO_PERMISO = eSTADO_PERMISO;
            EDITAR_PERMISO = eDITAR_PERMISO;
            VER_PERMISO = vER_PERMISO;
            CREAR_PERMISO = cREAR_PERMISO;
        }

        public Menu(string pK_PK_ID_MENU, string cODIGO_PADRE)
        {
            PK_PK_ID_MENU = pK_PK_ID_MENU;
            CODIGO_PADRE = cODIGO_PADRE;
          
        }
    }
}