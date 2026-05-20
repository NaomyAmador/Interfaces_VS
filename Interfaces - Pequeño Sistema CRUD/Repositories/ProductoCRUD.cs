using Dapper;
using Interfaces___Pequeño_Sistema_CRUD.Data;
using Interfaces___Pequeño_Sistema_CRUD.Entidades;
using Interfaces___Pequeño_Sistema_CRUD.Repositories;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Interfaces_SistemaCRUD.Repository
{
    public class ProductoCRUD : IRepository<Producto>
    {
        //Conexión con la Base de Datos (haciendo referencia a la Clase ConexiónBDD)
        private readonly ConexiónBDD Conexión;
        public ProductoCRUD()
        {
            Conexión = new ConexiónBDD();
        }
        //Método para Guardar Producto
        public void Save(Producto Productos)
        {
            using (SqlConnection ConexiónBD = Conexión.GetConnection())
            {
                string insertarProducto = "INSERT INTO Producto (Nombre, Precio) VALUES (@Nombre, @Precio)";
                ConexiónBD.Execute(insertarProducto, Productos);
            }
        }
        //Método para Actualizar Producto
        public void Update(Producto Productos)
        {
            using (SqlConnection ConexiónBD = Conexión.GetConnection())
            {
                string ActualizarProducto = @"UPDATE Producto SET Nombre = @Nombre, Precio = @Precio WHERE ProductoID = @ProductoID";
                ConexiónBD.Execute(ActualizarProducto, Productos);
            }
        }
        //Método para Eliminar Producto
        public void Delete(int ProductoID)
        {
            using (SqlConnection ConexiónBD = Conexión.GetConnection())
            {
                string EliminarProducto = "DELETE FROM Producto WHERE ProductoID = @ProductoID";
                ConexiónBD.Execute(EliminarProducto, new { ProductoID = ProductoID });
            }
        }
        //Método para Buscar Producto
        public Producto Search(int ProductoID)
        {
            using (SqlConnection ConexiónBD = Conexión.GetConnection())
            {
                string BuscarProducto = "SELECT * FROM Producto WHERE ProductoID = @ProductoID";
                return ConexiónBD.Query<Producto>( BuscarProducto, new { ProductoID = ProductoID }).FirstOrDefault();
            }
        }
        //Método para ver todos los Productos
        public List<Producto> GetAll()
        {
            using (SqlConnection ConexiónBD = Conexión.GetConnection())
            {
                string ProductosExistentes = "SELECT * FROM Producto"; 
                return ConexiónBD.Query<Producto>(ProductosExistentes).ToList();
            }
        }
    }
}
