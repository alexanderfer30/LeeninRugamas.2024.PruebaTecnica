using LeeninRugamasMVC.EN;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace LeeninRugamasMVC.DAL
{
    public class PruebaTecnicaContextoDB : DbContext
    {
       
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>()
                .HasMany(c => c.Productos) 
                .WithOne(p => p.Categoria) 
                .HasForeignKey(p => p.IdCategoria) 
                .OnDelete(DeleteBehavior.Cascade); 

            base.OnModelCreating(modelBuilder);
        }
    }
}
