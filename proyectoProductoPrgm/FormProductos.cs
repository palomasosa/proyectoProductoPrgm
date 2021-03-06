using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoProductoPrgm
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
            dgvProductos.Columns.Add("columnaCodigo", "Codigo");
            dgvProductos.Columns.Add("columnaDescripcion", "Descripcion");
            dgvProductos.Columns.Add("columnaStock", "Stock");
            dgvProductos.Columns[0].Width = 150;
            dgvProductos.Columns[1].Width = 150;
            dgvProductos.Columns[2].Width = 110;
        }

        Producto productoNuevo;
        Producto productoExistente;
        bool nuevo = false;
        int fila;

        #region Metodos
        void cargarDatosDgv(Producto prod)
        {
            dgvProductos.Rows.Add(prod.codigoProp.ToString(), prod.descripcionProp, prod.stockProp.ToString());
            fila = dgvProductos.Rows.Count - 1;
        }
        void modificarStockDgv(Producto prod, int filaActual)
        {
            dgvProductos.Rows[filaActual].SetValues(prod.codigoProp, prod.descripcionProp, prod.stockProp);
        }

        void stockActual(Producto prod)
        {
            if (rdbtnIngreso.Checked == true)
            {
                prod.Ingresos(Convert.ToInt32(txtbxCantidadTab2.Text));
            }
            else
            {
                prod.Egresos(Convert.ToInt32(txtbxCantidadTab2.Text));
            }
        }
        #endregion
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productoExistente = new Producto(Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value), Convert.ToString(dgvProductos.CurrentRow.Cells[1].Value), Convert.ToInt32(dgvProductos.CurrentRow.Cells[2].Value));
            lblCodigoTab2.Text = productoExistente.codigoProp.ToString();
            lblDescripcionTab2.Text = productoExistente.descripcionProp;
            fila = dgvProductos.CurrentRow.Index;
            nuevo = false;
        }

        public void btnCarga_Click(object sender, EventArgs e)
        {
            productoNuevo = new Producto(Convert.ToInt32(txtbxCodigo.Text), txtbxDescripcion.Text);
            lblCodigoTab2.Text = productoNuevo.codigoProp.ToString();
            lblDescripcionTab2.Text = productoNuevo.descripcionProp;
            cargarDatosDgv(productoNuevo);
            txtbxCodigo.Text = null;
            txtbxDescripcion.Text = null;
            txtbxCantidadTab2.Text = null;
            tabControl1.SelectTab(tabMovimientos);
            txtbxCantidadTab2.Focus();
            nuevo = true;
        }

        public void btnAplicar_Click(object sender, EventArgs e)
        {
            if (nuevo == true)
            {
                stockActual(productoNuevo);
                modificarStockDgv(productoNuevo, fila);

            }
            else
            {
                stockActual(productoExistente);
                modificarStockDgv(productoExistente, fila);
            }
        }

    }
}
