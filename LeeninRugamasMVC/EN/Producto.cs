namespace LeeninRugamasMVC.EN
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

      
        public int IdCategoria { get; set; }
        public Categoria Categoria { get; set; }
    }
}
