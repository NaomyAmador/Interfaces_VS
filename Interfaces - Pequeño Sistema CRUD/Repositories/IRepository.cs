using System.Collections.Generic;

namespace Interfaces___Pequeño_Sistema_CRUD.Repositories
{
    //Nota: La <T> significa que estas acciones de la interfaz sirven para
    //cualquier tipo de dato que le pasemos o necestemos para realizar el programa
    //(ya sea int, string, decimal, etc.)
    public interface IRepository<T>
    {
        void Save(T entity);
        void Update(T entity);
        void Delete(int id);
        T Search(int id);
        List<T> GetAll();
    }
}
