using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        #region Atributos
        private int codigo;
        private string descripcion;
        private int stock;
        #endregion
        #region Propiedades
        public int codigoProp {
            get { return codigo; } 
            set { codigo = value; } 
        }
        public int stockProp { 
            get { return stock; } 
        }
        public string descripcionProp
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        #endregion
        #region Constructores
        public Producto() { }
        public Producto(int cod, string desc)
        {
            codigo = cod;
            descripcion = desc;
            stock = 0;
        }
        public Producto(int cod, string desc, int stockC)
        {
            codigo = cod;
            descripcion = desc;
            stock = stockC;
        }
        #endregion
        #region Metodos
        public void Ingresos(int cant)
        {
            stock = stock + cant;
        }
        public void Egresos(int cant)
        {
            stock = stock - cant;
        }
        #endregion
    }
}