using Interfaces___Pequeño_Sistema_CRUD.Entidades;
using Interfaces___Pequeño_Sistema_CRUD.Repositories;
using System;
using System.Windows.Forms;

namespace Interfaces___Pequeño_Sistema_CRUD
{
    public partial class Form2 : Form
    {
        //Objeto para usar los métodos de la interfaz
        IRepository<Cliente> clienteCRUD = new ClienteCRUD();
        public Form2()
        {
            InitializeComponent();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            Cliente Cliente = new Cliente();
            Cliente.Nombre =TxtBox_Nombre.Text;
            Cliente.Correo = TxtBox_Correo.Text;

            //Método de la Interfaz a utilizar (acción a usar) - Insertar
            clienteCRUD.Save(Cliente);
            MessageBox.Show("¡Cliente guardado correctamente!");
            DataGridView_TablaCliente.DataSource = clienteCRUD.GetAll();
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            Cliente Cliente = new Cliente();
            Cliente.ClienteID = int.Parse(TxtBox_ClienteID.Text);
            Cliente.Nombre = TxtBox_Nombre.Text;
            Cliente.Correo = TxtBox_Correo.Text;

            //Método de la Interfaz a utilizar (acción a usar) - Actualizar
            clienteCRUD.Update(Cliente);
            MessageBox.Show("¡Cliente actualizado correctamente!");
            DataGridView_TablaCliente.DataSource = clienteCRUD.GetAll();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            int ClienteID = int.Parse(TxtBox_ClienteID.Text);

            //Método de la Interfaz a utilizar (acción a usar) - Eliminar
            clienteCRUD.Delete(ClienteID);
            MessageBox.Show("¡Cliente eliminado correctamente!");
            DataGridView_TablaCliente.DataSource = clienteCRUD.GetAll();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            int clienteID = int.Parse(TxtBox_ClienteID.Text);

            //Método de la Interfaz a utilizar (acción a usar) - Buscar
            Cliente Cliente = clienteCRUD.Search(clienteID);
            if (Cliente != null)
            {
                TxtBox_Nombre.Text = Cliente.Nombre;
                TxtBox_Correo.Text = Cliente.Correo;
            }
            else
            {
                MessageBox.Show("Cliente no encontrado en la Base de Datos");
            }
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            //Método de la Interfaz a utilizar (acción a usar) - Ver todos
            DataGridView_TablaCliente.DataSource = clienteCRUD.GetAll();
        }
    }
}
