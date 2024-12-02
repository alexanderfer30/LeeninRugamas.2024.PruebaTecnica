using LeeninRugamasMVC.BL;
using LeeninRugamasMVC.EN;
using Microsoft.AspNetCore.Mvc;

namespace LeeninRugamasMVC.Controllers
{
    [Route("categorias")]
    public class CategoriaController : Controller
    {
        private readonly CategoriaBL _categoriaBL;

        public CategoriaController(CategoriaBL categoriaBL)
        {
            _categoriaBL = categoriaBL;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var categorias = _categoriaBL.Listar();
            return View(categorias);
        }

        [HttpPost]
        public IActionResult Crear(Categoria categoria)
        {
            _categoriaBL.Insertar(categoria);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Editar(Categoria categoria)
        {
            _categoriaBL.Actualizar(categoria);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Eliminar(int id)
        {
            _categoriaBL.Eliminar(id);
            return RedirectToAction("Index");
        }
    }

}
