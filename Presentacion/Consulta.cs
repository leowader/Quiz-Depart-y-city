using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }
        Logica.ServicioProducto ServicioProducto = new Logica.ServicioProducto();
        void CargarGrilla()
        {

            foreach (var item in ServicioProducto.Mostrar() )
            {
                int n = GrillaProductos.Rows.Add();
                GrillaProductos.Rows[n].Cells[0].Value = item.Referencia;
                GrillaProductos.Rows[n].Cells[1].Value = item.Nombre;
                GrillaProductos.Rows[n].Cells[2].Value = item.idCategoria;
                GrillaProductos.Rows[n].Cells[3].Value = item.FechaVencimiento;
                GrillaProductos.Rows[n].Cells[4].Value = item.Precio;
            }
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }
    }
}
