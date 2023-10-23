var builder = WebApplication.CreateBuilder(args);
//Indicarle a servidor que utilizaremos la arquitectura MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();
//Configuracion para utilizar rutas, archivos estaticos y autenticacion
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id}"
);

app.Run();
