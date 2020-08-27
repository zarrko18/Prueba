using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
namespace WebApplication2.Models
{
    public class Conexion
    {
        private static SqlConnection objConexion;
        private static string error;

        public static SqlConnection getConexion() {
            if (objConexion != null) { 
            return objConexion;
            }
            objConexion = new SqlConnection();
            objConexion.ConnectionString = "Data Source=;Initial Catalog=SITSA;User ID=Test;Password=root;";
            try
            {
                objConexion.Open();
                return objConexion;
            }
            catch (Exception e) {
                error = e.Message;
                return null;
            }
        }
        public static void cerrarConexion() {
            if (objConexion != null) { 
                objConexion.Close();
            }
        }
    }
}