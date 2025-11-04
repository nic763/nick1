using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using proyecto_nicol.Data;
using proyecto_nicol.Implementacion;
using proyecto_nicol.Services;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration
.GetConnectionString("DefaultConnection");
    

// Add services to the container.
builder.Services.AddControllersWithViews() ;
builder.Services.AddDbContext<DBContext>(Options =>
 Options.UseNpgsql(connectionString)
);
builder.Services.AddScoped<IUsuariosService, UsuarioService>();

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
