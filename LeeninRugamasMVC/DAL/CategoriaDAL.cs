using LeeninRugamasMVC.EN;
using System;

namespace LeeninRugamasMVC.DAL
{
    public class CategoriaDAL
        {
            private readonly PruebaTecnicaContextoDB _context;

            public CategoriaDAL(PruebaTecnicaContextoDB context)
            {
                _context = context;
            }

            // Listar todas las categorías
            public List<Categoria> Listar()
            {
                return _context.Categorias.ToList();
            }

            // Insertar nueva categoría
            public void Insertar(Categoria categoria)
            {
                _context.Categorias.Add(categoria);
                _context.SaveChanges();
            }

            // Actualizar categoría existente
            public void Actualizar(Categoria categoria)
            {
                _context.Categorias.Update(categoria);
                _context.SaveChanges();
            }

            // Eliminar categoría por ID
            public void Eliminar(int id)
            {
                var categoria = _context.Categorias.Find(id);
                if (categoria != null)
                {
                    _context.Categorias.Remove(categoria);
                    _context.SaveChanges();
                }
            }
        }

    }