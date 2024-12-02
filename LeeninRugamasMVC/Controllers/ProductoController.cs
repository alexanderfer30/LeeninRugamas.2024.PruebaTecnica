using LeeninRugamasMVC.BL;
using LeeninRugamasMVC.EN;
using Microsoft.AspNetCore.Mvc;

namespace LeeninRugamasMVC.Controllers
{
    [Route("productos")]
    public class ProductoController : Controller
    {
        private readonly ProductoBL _productoBL;

        public ProductoController(ProductoBL productoBL)
        {
            _productoBL = productoBL;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var productos = _productoBL.Listar();
            return View(productos);
        }

        [HttpPost]
        public IActionResult Crear(Producto producto)
        {
            _productoBL.Insertar(producto);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Editar(Producto producto)
        {
            _productoBL.Actualizar(producto);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Eliminar(int id)
        {
            _productoBL.Eliminar(id);
            return RedirectToAction("Index");
        }
    }

}
