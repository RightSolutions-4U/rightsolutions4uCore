using Microsoft.EntityFrameworkCore;
using rightsolutions4u.common.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
/*builder.Services.AddTransient<MySqlConnection>(_ =>
    new MySqlConnection(builder.Configuration.GetConnectionString("rightsolutions4u")));*/

var serverVersion = new MySqlServerVersion(new Version(8, 0, 29));

builder.Services.AddDbContext<Rights4uDbContext>(
dbContextOptions => dbContextOptions
        .UseMySql("Server = localhost; Database = rights4u_db; Uid = root; Pwd = Mohtashim098@", serverVersion)
        // The following three options help with debugging, but should
        // be changed or removed for production.
        .LogTo(Console.WriteLine, LogLevel.Information)
        .EnableSensitiveDataLogging()
        .EnableDetailedErrors());
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
