using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.AccesoDatos.Repositorio.IRepositorio
{
    // Puede recibir cualquier objeto ejemplos bodegas caregorias para los crud 
    public interface IRepositorio<T> where T : class // de esta manera hacemos la interfaz generica
    {
        // estos son metodos asyncronos async
        Task<T> Obtener(int id);

        Task<IEnumerable<T>> ObtenerTodos(
            Expression<Func<T, bool>> filtro = null, // funciona como un filtro
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, // es para ordenar 
            string incluirPropiedades = null,
            bool isTracking = true
            );
        Task<T> ObtenerPrimero(
             Expression<Func<T, bool>> filtro = null,
             string incluirPropiedades = null,
            bool isTracking = true
            );
        Task Agregar(T entidad);

        // estos metodos no pueden ser asyncronos porque son de remover
        void Remover(T entidad);

        void RemoverRango(IEnumerable<T> entidad);
    }
}
