using LeeninRugamasMVC.EN;
using Microsoft.EntityFrameworkCore;
using System;

namespace LeeninRugamasMVC.DAL
{
    public class ProductoDAL
    {
        private readonly PruebaTecnicaContextoDB _context;

        public ProductoDAL(PruebaTecnicaContextoDB context)
        {
            _context = context;
        }

        // Listar todos los productos
        public List<Producto> Listar()
        {
            return _context.Productos.Include(p => p.Categoria).ToList();
        }

        // Insertar nuevo producto
        public void Insertar(Producto producto)
        {
            _context.Productos.Add(producto);
            _context.SaveChanges();
        }

        // Actualizar producto existente
        public void Actualizar(Producto producto)
        {
            _context.Productos.Update(producto);
            _context.SaveChanges();
        }

        // Eliminar producto por ID
        public void Eliminar(int id)
        {
            var producto = _context.Productos.Find(id);
            if (producto != null)
            {
                _context.Productos.Remove(producto);
                _context.SaveChanges();
            }
        }
    }
}
