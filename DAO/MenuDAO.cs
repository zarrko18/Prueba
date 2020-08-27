using System;
using System.Web.UI;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using WebApplication2.Models;

using System.Web.UI;
using System.Collections.Generic;

namespace WebApplication2.DAO
{
    
    public class MenuDAO
    {
        public SqlConnection conexion;
        public SqlTransaction transaction;
        public string error;

        public MenuDAO() {
            this.conexion = Conexion.getConexion();
        }

        public List<Models.Menu> consultamenu(string Usuario, string PK_Perfil) {
            List<Models.Menu> listmenu = new List<Models.Menu>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "execute PA_CON_CTRL_SEG_MENU '@Usuario',0,@FK_Perfil";
            comando.Parameters.AddWithValue("@Usuario", Usuario);
            comando.Parameters.AddWithValue("PK_Perfil", PK_Perfil);

            SqlDataReader list = comando.ExecuteReader();
            while (list.Read()) {
                Models.Menu men = new Models.Menu();
                men.PK_PK_ID_MENU = list.GetString(0);
                men.CODIGO_PADRE = list.GetString(1);
                men.DESCRIPCION = list.GetString(2);
                men.ICONO = list.GetString(3);
                men.URL = list.GetString(4);
                men.ESTADO_MENU = list.GetString(5);
                men.CREAR_MENU = list.GetString(6);
                men.EDTITAR_MENU = list.GetString(7);
                men.VER_MENU = list.GetString(8);
                men.ESTADO_PERMISO = list.GetString(9);
                men.CREAR_PERMISO = list.GetString(10);
                men.EDITAR_PERMISO = list.GetString(11);
                men.VER_PERMISO= list.GetString(12);
                listmenu.Add(men);
            }
            list.Close();
            return listmenu;

        }

    }
}