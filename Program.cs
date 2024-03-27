using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Corona_System.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Corona_SystemContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Corona_SystemContext") ?? throw new InvalidOperationException("Connection string 'Corona_SystemContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Members}/{action=Index}/{id?}");

app.Run();
