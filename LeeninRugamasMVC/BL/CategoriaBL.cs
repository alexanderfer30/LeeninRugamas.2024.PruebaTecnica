using LeeninRugamasMVC.DAL;
using LeeninRugamasMVC.EN;

namespace LeeninRugamasMVC.BL
{
    public class CategoriaBL
    {
        private readonly CategoriaDAL _categoriaDAL;

        public CategoriaBL(CategoriaDAL categoriaDAL)
        {
            _categoriaDAL = categoriaDAL;
        }

        public List<Categoria> Listar()
        {
            return _categoriaDAL.Listar();
        }

        public void Insertar(Categoria categoria)
        {
            _categoriaDAL.Insertar(categoria);
        }

        public void Actualizar(Categoria categoria)
        {
            _categoriaDAL.Actualizar(categoria);
        }

        public void Eliminar(int id)
        {
            _categoriaDAL.Eliminar(id);
        }
    }
}
