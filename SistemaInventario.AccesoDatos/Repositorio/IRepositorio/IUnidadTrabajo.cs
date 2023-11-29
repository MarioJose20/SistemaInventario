using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.AccesoDatos.Repositorio.IRepositorio
{
    public interface IUnidadTrabajo : IDisposable // elimina objetos que ya no se usan 
    {
        IBodegaRepositorio Bodega { get; } // porque no vanos a cambiar

        Task Guardar();
    }
}
