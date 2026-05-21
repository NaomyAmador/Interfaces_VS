using Dapper;
using Interfaces___Pequeño_Sistema_CRUD.Data;
using Interfaces___Pequeño_Sistema_CRUD.Entidades;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Interfaces___Pequeño_Sistema_CRUD.Repositories
{
    public class ClienteCRUD : IRepository<Cliente>
    {
        //Conexión con la Base de Datos (haciendo referencia a la Clase ConexiónBDD)
        private readonly ConexiónBDD Conexión;
        public ClienteCRUD()
        {
            Conexión = new ConexiónBDD();
        }
        //Método para Guardar Cliente
        public void Save(Cliente Clientes)
        {
            using (SqlConnection ConexiónBD = Conexión.GetConnection())
            {
                string InsertarCliente = "INSERT INTO Cliente (Nombre, Correo) VALUES (@Nombre, @Correo)";
                ConexiónBD.Execute(InsertarCliente, Clientes);
            }
        }
        //Método para Actualizar Cliente
        public void Update(Cliente Clientes)
        {
            using (SqlConnection ConexiónBD = Conexión.GetConnection())
            {
                string ActualizarCliente =@"UPDATE Cliente SET Nombre = @Nombre, Correo = @Correo WHERE Id = @Id";
                ConexiónBD.Execute(ActualizarCliente, Clientes);
            }
        }
        //Método para Eliminar Cliente
        public void Delete(int ClienteID)
        {
            using (SqlConnection ConexiónBD = Conexión.GetConnection())
            {
                string EliminarCliente = "DELETE FROM Cliente WHERE ClienteID = @ClienteID";
                ConexiónBD.Execute(EliminarCliente, new { ClienteID = ClienteID });
            }
        }
        //Método para Buscar Cliente
        public Cliente Search(int ClienteID)
        {
            using (SqlConnection ConexiónBD = Conexión.GetConnection())
            {
                string BuscarCliente = "SELECT * FROM Cliente WHERE ClienteID = @ClienteID";
                return ConexiónBD.Query<Cliente>(BuscarCliente, new { ClienteID = ClienteID }).FirstOrDefault();
            }
        }
        //Método para ver todos los Clientes
        public List<Cliente> GetAll()
        {
            using (SqlConnection ConexiónBD = Conexión.GetConnection())
            {
                string ClientesExistentes = "SELECT * FROM Cliente";
                return ConexiónBD.Query<Cliente>(ClientesExistentes).ToList();
            }
        }
    }
}
