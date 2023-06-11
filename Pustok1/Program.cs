using Microsoft.EntityFrameworkCore;
using Pustok1.DAL;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Pustok1DbContext>(opt =>
{
    opt.UseSqlServer("Server=localhost;Database=Pustok1;Integrated Security=false;User Id=sa;Password=p231sqlserver!!;");
});


var app = builder.Build();

app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
app.UseStaticFiles();
app.Run();

