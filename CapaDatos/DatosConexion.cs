using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DatosConexion
    {
        protected SqlConnection conexion;
        //protected string cadenaConexion = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        protected string cadenaConexion = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Producto; Integrated Security = true";


        public DatosConexion(){
            conexion = new SqlConnection(cadenaConexion);
        }

        public void AbrirConexion()
        {
            try
            {
                if(conexion.State == ConnectionState.Broken || conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
            }
            catch (Exception e)
            {

                throw new Exception("Error al tratar de abrir la conexión",e);
            }
        }

        public void CerrarConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            catch (Exception e)
            {

                throw new Exception("Error al tratar de cerrar la conexión",e);
            }
        }
    }
}

   

