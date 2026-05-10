using ControlHardwareSoftware.Components;
using ControlHardwareSoftware.Components.Data;
using ControlHardwareSoftware.Components.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//agregamos la injeccion a la cadena de conexcion 
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//agregamos los servicios, injectamos
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IEquipoService, EquipoService>();
builder.Services.AddScoped<ISoftwareService, SoftwareService>();
builder.Services.AddScoped<IMantenimientoService, MantenimientoService>(); 
builder.Services.AddScoped<IUbicacionService, UbicacionService>(); 
builder.Services.AddScoped<IComponenteService, ComponenteService>(); 
builder.Services.AddScoped<ILicenciaService, LicenciaService>();

builder.Services.AddScoped<IActualizacionSoftwareService, ActualizacionSoftwareService>();
builder.Services.AddScoped<ISoftwareInstaladoService, SoftwareInstaladoService>();
builder.Services.AddScoped<IMantenimientoService, MantenimientoService>();



// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();



