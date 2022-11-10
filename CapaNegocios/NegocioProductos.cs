using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using CapaDatos;

namespace CapaNegocios
{
    public class NegocioProductos
    {
        //AdminProductos datosObjProductos = new AdminProductos();
        //AdminProductos datosObjProductos = new AdminProductos();
        DatosProducto datosObjProductos = new DatosProducto();
        public int abmProductos(string accion, Producto objProducto)
        {
            return datosObjProductos.abmProductos(accion, objProducto);
        }
        public DataSet listadoProductos(string cual)
        {
            return datosObjProductos.listadoProductos(cual);
        }
    }
}
