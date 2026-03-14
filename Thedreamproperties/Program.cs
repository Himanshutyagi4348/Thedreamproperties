using Microsoft.Extensions.Options;
using Thedreamproperties.Context;
using Microsoft.EntityFrameworkCore;
using Thedreamproperties.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Appdbcontext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<Icontactmessegerepository,contactmessegerepository>();
builder.Services.AddScoped<Appdbcontext, Appdbcontext>();

var app = builder.Build();

// Configure the HTTP request pipeline..
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
