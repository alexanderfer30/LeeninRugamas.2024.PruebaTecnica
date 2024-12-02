using LeeninRugamasMVC.DAL;
using LeeninRugamasMVC.EN;

namespace LeeninRugamasMVC.BL
{
    public class ProductoBL
    {
        private readonly ProductoDAL _productoDAL;

        public ProductoBL(ProductoDAL productoDAL)
        {
            _productoDAL = productoDAL;
        }

        public List<Producto> Listar()
        {
            return _productoDAL.Listar();
        }

        public void Insertar(Producto producto)
        {
            _productoDAL.Insertar(producto);
        }

        public void Actualizar(Producto producto)
        {
            _productoDAL.Actualizar(producto);
        }

        public void Eliminar(int id)
        {
            _productoDAL.Eliminar(id);
        }
    }
}
