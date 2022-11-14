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

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Logica.ServicioProducto ServicioProducto = new Logica.ServicioProducto();
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consulta consulta=new Consulta();
            consulta.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        void Guardar()
        {
            var producto = new Producto();
            producto.Referencia = int.Parse(txtReferencia.Text);
            producto.Nombre=txtNombre.Text;
            producto.idCategoria=comboBoxCategoria.SelectedIndex;
            producto.FechaVencimiento = DateTime.Parse(DateFechaVenci.Text);
            ServicioProducto.Guardar(producto);

        }
    }
}
