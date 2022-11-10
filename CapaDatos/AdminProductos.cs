using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace CapaDatos
{
    public class AdminProductos: DatosConexion
    {
        public int abmProductos(string accion, Producto objProducto)
        {
            int resultado = -1;
            string orden = string.Empty;
            if (accion == "Alta")
            {
                orden = "insert into Productos values " +
                    "(" + objProducto.codigoProp + ",'" + objProducto.descripcionProp + "'," + objProducto.stockProp + ");";
            }
            if (accion == "Modificar")
            {
                orden = "update Productos set " +
                    "Descripcion= '" + objProducto.descripcionProp + "', Stock = "+ objProducto.stockProp + " where Codigo =" + objProducto.codigoProp + ";";
            }
            if (accion == "Eliminar")
            {
                orden = "delete from Productos where Codigo = " + objProducto.codigoProp + ";";
            }
            SqlCommand cmd = new SqlCommand(orden, conexion);
            try
            {
                AbrirConexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception("Error al tratar de realizar la modificación en la base de datos", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return resultado;
        }

        public DataSet listadoProductos(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
            {
                orden = "select * from Productos where Codigo = " + System.Convert.ToInt32(cual) + ";";
            }
            else
            {
                orden = "select * from Productos";
            }
            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet dtSet = new DataSet();
            SqlDataAdapter dtAd = new SqlDataAdapter();
            try
            {
                AbrirConexion();
                cmd.ExecuteNonQuery();

                dtAd.SelectCommand = cmd;
                dtAd.Fill(dtSet);
            }
            catch (Exception e)
            {

                throw new Exception("Error al tratar realizar listado de productos", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return dtSet;
        }
    }
}
