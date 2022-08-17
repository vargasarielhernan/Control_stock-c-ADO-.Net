using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Elementos;
using AccesoDB;
using System.Configuration;
using System.IO;

namespace Stock
{
    public partial class Windowsagregar : Form
    {
        private Articulos articulos = null;
        private OpenFileDialog openFileDialog = null;
        public Windowsagregar()
        {
            InitializeComponent();
        }
        public Windowsagregar(Articulos articulos)
        {
            InitializeComponent();
            this.articulos = articulos;
            Text = "Modificar Articulo";
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            listaArticulos accesoDB = new listaArticulos();
            try
            {
                if (articulos == null)
                    articulos = new Articulos();


                if (!validaciones())
                    return; 
                articulos.Codigo=txtboxcodigo.Text;
                articulos.Nombre=txtboxnombre.Text;
                articulos.Descripcion=txtboxdescripcion.Text;
                articulos.ImagenUrl = txtboxurl.Text;
                articulos.Marca = (Marca)cbmarca.SelectedItem;
                articulos.Categoria = (Categoria)cbcategoria.SelectedItem;
                articulos.Precio = decimal.Parse(txtprecio.Text);
                if (articulos.Id != 0)
                {
                    accesoDB.modificar(articulos);
                    MessageBox.Show("Articulo Modificado");
                }
                else
                {
                    accesoDB.agregar(articulos);
                    MessageBox.Show("Articulo Agregado");
                }

                if (openFileDialog!=null && !(txtboxurl.Text.ToUpper().Contains("HTTP")))
                    File.Copy(openFileDialog.FileName, ConfigurationManager.AppSettings["Image-folder"] + openFileDialog.SafeFileName);
                Close();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        public bool validaciones()
        {
            if (string.IsNullOrEmpty(txtprecio.Text))
            {
                MessageBox.Show("Ingrese un precio");
                return false;
            }
            if (string.IsNullOrEmpty(txtboxcodigo.Text))
            {
                MessageBox.Show("Ingrese un Codigo");
                return false;
            }
            if (string.IsNullOrEmpty(txtboxnombre.Text))
            {
                MessageBox.Show("Ingrese un Nombre");
                return false;
            }

            if (!soloNumeros(txtprecio.Text))
            {
                MessageBox.Show("Ingrese solo numeros para el precio");
                return false;
            }
            
            return true;
        }
   
        public bool soloNumeros(string cadena)
        {
            
            foreach (char caracter in cadena)
            {
                if (!char.IsNumber(caracter))
                {
                    return false;
                }

                    
            }
            return true;
        }

        private void Windowsagregar_Load(object sender, EventArgs e)
        {
            listaCategoria categoria = new listaCategoria();
            listaMarca marca = new listaMarca();
            try
            {
                cbcategoria.DataSource = categoria.listar();
                cbcategoria.ValueMember = "Id";
                cbcategoria.DisplayMember = "Descripcion";
                cbmarca.DataSource = marca.listar();
                cbmarca.ValueMember = "Id";
                cbmarca.DisplayMember = "Descripcion";

                if (articulos != null)
                {
                    txtboxcodigo.Text = articulos.Codigo;
                    txtboxnombre.Text = articulos.Nombre;
                    txtboxdescripcion.Text= articulos.Descripcion;
                    txtboxurl.Text = articulos.ImagenUrl;
                    Imageload(articulos.ImagenUrl);
                    txtprecio.Text = articulos.Precio.ToString();
                    cbcategoria.SelectedValue = articulos.Categoria.Id;
                    cbmarca.SelectedValue = articulos.Marca.Id;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtboxurl_Leave(object sender, EventArgs e)
        {
            Imageload(txtboxurl.Text);
        }
        private void Imageload(string image)
        {
            try
            {
                pictureBox.Load(image);
            }
            catch (Exception)
            {

                pictureBox.Load("https://enfermeriacreativa.com/wp-content/uploads/2019/07/placeholder.png");
            }
        }

        private void btnagregarfile_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "jpg|*.jpg;|png|* .png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtboxurl.Text = openFileDialog.FileName;
                Imageload(openFileDialog.FileName);
            }
        }

       
    }
}
