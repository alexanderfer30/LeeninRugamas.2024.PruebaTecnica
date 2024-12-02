using System;
using LeeninRugamasMVC.BL;
using LeeninRugamasMVC.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


// Configuración de la conexión a la base de datos
builder.Services.AddDbContext<PruebaTecnicaContextoDB>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 34)) // Cambia el número de versión según tu versión de MySQL
    )
);
builder.Services.AddScoped<ProductoDAL>();
builder.Services.AddScoped<CategoriaDAL>();
builder.Services.AddScoped<CategoriaBL>();
builder.Services.AddScoped<ProductoBL>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
