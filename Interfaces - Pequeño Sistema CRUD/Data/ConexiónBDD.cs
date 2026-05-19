using System.Data.SqlClient;

namespace Interfaces___Pequeño_Sistema_CRUD.Data
{
    public class ConexiónBDD
    {
        private string CadenadeConexión = @"Server=LAPTOP-9G07MQQC\SQLEXPRESS;Database=SistemaCRUD;Trusted_Connection=True;";
        public SqlConnection GetConnection() 
        {
            return new SqlConnection(CadenadeConexión);
        }
    }
}
