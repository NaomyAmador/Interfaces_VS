using Interfaces___Pequeño_Sistema_CRUD.Entidades;
using Interfaces___Pequeño_Sistema_CRUD.Repositories;
using Interfaces_SistemaCRUD.Repository;
using System;
using System.Windows.Forms;

namespace Interfaces___Pequeño_Sistema_CRUD
{
    public partial class Form1 : Form
    {
        //Objeto para usar los métodos de la interfaz
        IRepository<Producto> productoCRUD = new ProductoCRUD();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            Producto Producto = new Producto();
            Producto.Nombre = TxtBox_Nombre.Text;
            Producto.Precio = decimal.Parse(TxtBox_Precio.Text);

            //Método de la Interfaz a utilizar (acción a usar) - Insertar
            productoCRUD.Save(Producto);
            MessageBox.Show("¡Producto guardado correctamente!");
            DataGridView_TablaProducto.DataSource = productoCRUD.GetAll();
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            Producto Producto = new Producto();
            Producto.ProductoID = int.Parse(TxtBox_ProductoID.Text);
            Producto.Nombre = TxtBox_Nombre.Text;
            Producto.Precio = decimal.Parse(TxtBox_Precio.Text);

            //Método de la Interfaz a utilizar (acción a usar) - Actualizar
            productoCRUD.Update(Producto);
            MessageBox.Show("¡Producto actualizado sin problemas!");
            DataGridView_TablaProducto.DataSource = productoCRUD.GetAll();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            int ProductoID = int.Parse(TxtBox_ProductoID.Text);
            //Método de la Interfaz a utilizar (acción a usar) - Eliminar
            productoCRUD.Delete(ProductoID);
            MessageBox.Show("¡Producto eliminado exitosamente!");
            DataGridView_TablaProducto.DataSource =productoCRUD.GetAll();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            int ProductoID = int.Parse(TxtBox_ProductoID.Text);
            //Método de la Interfaz a utilizar (acción a usar) - Buscar
            Producto Producto = productoCRUD.Search(ProductoID);
            if (Producto != null)
            {
                TxtBox_Nombre.Text = Producto.Nombre;
                TxtBox_Precio.Text = Producto.Precio.ToString();
            }
            else
            {
                MessageBox.Show("Producto no encontrado en la Base de Datos");
            }
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            //Método de la Interfaz a utilizar (acción a usar) - Ver Todos los Productos
            DataGridView_TablaProducto.DataSource = productoCRUD.GetAll();
        }
    }
}
