using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDB;
using Elementos;

namespace Stock
{
    public partial class Form1 : Form
    {
        public List<Articulos> listaArt=new List<Articulos>();
        public Form1()
        {
            InitializeComponent();

            cbcampo.Items.Add("Nombre");
            cbcampo.Items.Add("Codigo");
            cbcampo.Items.Add("Precio");
            cbcampo.Items.Add("Descripcion");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            update();
        }

        private void dgvstock_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvstock.CurrentRow != null)
            {
                Articulos selected = (Articulos)dgvstock.CurrentRow.DataBoundItem;
                Imageload(selected.ImagenUrl);
            }
        }
        private void update()
        {
            listaArticulos lista = new listaArticulos();
            try
            {
                listaArt = lista.listar();
                dgvstock.DataSource = listaArt;
                ocultarcolumnas();
                Imageload(listaArt[0].ImagenUrl);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        private void ocultarcolumnas()
        {

            dgvstock.Columns["ImagenUrl"].Visible = false;
            dgvstock.Columns["Id"].Visible = false;
        }
        private void Imageload(string image)
        {
            try
            {
                picturebox.Load(image);
            }
            catch (Exception)
            {

                picturebox.Load("https://enfermeriacreativa.com/wp-content/uploads/2019/07/placeholder.png");
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Windowsagregar agregar = new Windowsagregar();
            agregar.ShowDialog();
            update();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Articulos seleccionado;
            
            if (dgvstock.CurrentRow != null)
            {
                seleccionado = (Articulos)dgvstock.CurrentRow.DataBoundItem;
                Windowsagregar modificar = new Windowsagregar(seleccionado);
                modificar.ShowDialog();
                update();
            }
                
            
            
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            listaArticulos accesoDB = new listaArticulos();
            Articulos seleccionado;
            try
            {
                if(dgvstock.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿Es seguro de eliminar el articulo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Articulos)dgvstock.CurrentRow.DataBoundItem;
                        accesoDB.eliminar(seleccionado.Id);
                        update();
                    }
                }
                
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Articulos> listfiltrada;
            string filtro = txtboxfiltro.Text;
            if (filtro.Length >= 2)
            {
                listfiltrada = listaArt.FindAll(x => x.Codigo.ToUpper().Contains(filtro.ToUpper())|| x.Nombre.ToUpper().Contains(filtro.ToUpper())|| x.Descripcion.ToUpper().Contains(filtro.ToUpper()));

            }
            else
            {
                listfiltrada = listaArt;
            }
            dgvstock.DataSource = null;
            dgvstock.DataSource = listfiltrada;
            ocultarcolumnas();
        }

        private void cbcampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbcampo.SelectedItem.ToString();
            if(opcion == "Precio")
            {
                cbcriterio.Items.Clear();
                cbcriterio.Items.Add("Menor a");
                cbcriterio.Items.Add("Mayor a");
                cbcriterio.Items.Add("Igual a");
            }
            else
            {
                cbcriterio.Items.Clear();
                cbcriterio.Items.Add("Comienza con");
                cbcriterio.Items.Add("Termina con");
                cbcriterio.Items.Add("Contiene");

            }
        }
        public bool validarfiltro()
        {
            if(cbcampo.SelectedIndex < 0 || cbcriterio.SelectedIndex<0)
            {
                MessageBox.Show("Por favor asegurece de tener un campo y un criterio de busqueda seleccionado");
                return true;
            }
            if (cbcampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtbusquedaavanzada.Text))
                {
                    MessageBox.Show("Ingrese un precio para su busqueda");
                    return true;
                }
                if (!soloNumeros(txtbusquedaavanzada.Text))
                {
                    MessageBox.Show("Ingrese solo numeros en la busqueda por precio");
                    return true;
                }
            }
               
            return false;
        }
        public bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if(!char.IsNumber(caracter))
                    return false;
            }
            return true;
        }

        public void btnbuscar_Click(object sender, EventArgs e)
        {
            listaArticulos accesoDB = new listaArticulos();

            try
            {
                if (validarfiltro())
                    return;
                string campo = cbcampo.SelectedItem.ToString();
                string criterio = cbcriterio.SelectedItem.ToString();
                string filtro = txtbusquedaavanzada.Text;
                dgvstock.DataSource = accesoDB.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
