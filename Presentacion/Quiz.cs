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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class Quiz : Form
    {
        public Quiz()
        {
            InitializeComponent();
        }
        readonly Logica.ServicioCity milogica = new Logica.ServicioCity();
        readonly Logica.ServicioDepartamento logicaDepa = new Logica.ServicioDepartamento();
        public void GuardarCity()
        {
            //guardar ciudad
            if (textBox.Text=="")
            {
                MessageBox.Show("CUADRO DE TEXTO VACIO","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                var ciudad = new Ciudad();
                ciudad.NombreCiudad = textBox.Text;
                var mensage=milogica.Agregar(ciudad);
                MessageBox.Show(mensage.ToUpper(),"INFO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        public void GuardarDepart()
        {
            if (textBox.Text=="")
            {
                MessageBox.Show("CUADRO DE TEXTO VACIO", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //guardar departamento
                var depart = new Departamentos();
                depart.NombreDepartamento = textBox.Text;
                var mensage =logicaDepa.Agregar(depart);
                MessageBox.Show(mensage.ToUpper(), "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void CargarCity()
        {
            listCity.DataSource = milogica.Mostrar();
            listCity.DisplayMember = "NombreCiudad";
            Limpiar();
        }
        void CargarDepart()
        {
            listDepart.DataSource = logicaDepa.Mostrar();
            listDepart.DisplayMember = "NombreDepartamento";
            Limpiar();
        }
        void Comprobar()
        {
            if (radioDepart.Checked)
            {
                btnAgregar.Enabled = true;
                GuardarDepart();
            }
            else
            {
                GuardarCity();
            }
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Comprobar();
            CargarCity();
            CargarDepart();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CargarCity();
            CargarDepart();
        }
        void EliminarCity()
        {
            if (textBox.Text == "")
            {
                MessageBox.Show("NINGUN ELEMENTO SELECCIONADO", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var city = new Ciudad();
                city.NombreCiudad = textBox.Text;
                var mensage = milogica.Elimiar(city.NombreCiudad);
                MessageBox.Show(mensage.ToUpper(), "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void EliminarDepart()
        {
            if (textBox.Text=="")
            {
                MessageBox.Show("NINGUN ELEMENTO SELECCIONADO", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var depart = new Departamentos();
                depart.NombreDepartamento = textBox.Text;
                var mensage = logicaDepa.Elimiar(depart.NombreDepartamento);
                MessageBox.Show(mensage.ToUpper(), "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void Limpiar()
        {
            textBox.Clear();
        }
        void VerCity(Ciudad ciudad)
        {
            textBox.Text=ciudad.NombreCiudad;
        }
        void VerDepart(Departamentos depart)
        {
            textBox.Text = depart.NombreDepartamento;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ComprobarDelete();
            CargarCity();
            CargarDepart();
            Limpiar();
        }
        void ComprobarDelete()
        {
            if (radioDepart.Checked)
            {
                btnEliminar.Enabled = true;
                EliminarDepart();
            }
            else
            {
                EliminarCity();
            }
        }
        private void ListCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerCity(milogica.Mostrar()[listCity.SelectedIndex]);
        }

        private void ListDepart_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerDepart(logicaDepa.Mostrar()[listDepart.SelectedIndex]);
        }

        private void BtnACity_Click(object sender, EventArgs e)
        {
            MoverCity();
            CargarCity();
            CargarDepart();
        }
        private void BtnADepart_Click(object sender, EventArgs e)
        {
            MoverDepart();
            CargarDepart();
            CargarCity();
        }
        void MoverCity()
        {
            if (textBox.Text == "")
            {
                MessageBox.Show("NINGUN ELEMENTO SELECCIONADO", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var city = new Ciudad();
                city.NombreCiudad = textBox.Text;
                milogica.Agregar(city);
                logicaDepa.Elimiar(city.NombreCiudad);
            }
        }
        void MoverDepart()
        {
            if (textBox.Text == "")
            {
                MessageBox.Show("NINGUN ELEMENTO SELECCIONADO", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var Depart = new Departamentos();
                Depart.NombreDepartamento = textBox.Text;
                logicaDepa.Agregar(Depart);
                milogica.Elimiar(Depart.NombreDepartamento);
            }
        }
        private void BtnClearText_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        void BorrarTodo()
        {
            var city = new Ciudad();
            var depart = new Departamentos();
            foreach (var item in listCity.Items)
            {
                city.NombreCiudad=item.ToString();
                milogica.Elimiar(city.NombreCiudad);
            }
            foreach (var item in listDepart.Items)
            {
                depart.NombreDepartamento=item.ToString();
                logicaDepa.Elimiar(depart.NombreDepartamento);
            }
            MessageBox.Show("LISTAS BORRADAS CORRECTAMENTE","INFO",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            BorrarTodo();
            CargarDepart();
            CargarCity();
        }
        public void ValidarText(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 130 && e.KeyChar <= 235))
            {
                MessageBox.Show("SOLO SE PERMITEN LETRAS", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarText(e);
        }
    }
}
