using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TP4.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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
//UniversityContext ref1 = UniversityContext.Instanciate_UniversityContext();
//Singleton ref2 = Singleton.getInstance();
//UniversityContext ref2 = UniversityContext.Instanciate_UniversityContext();

app.Run();
