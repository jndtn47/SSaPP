using Microsoft.EntityFrameworkCore;
using WebApi.Models;

var builder = WebApplication.CreateBuilder(args);
string connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlite(connection));

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("/", (ApplicationContext db) => db.Organizations.ToList());

app.MapPost("/api/organizations", (ApplicationContext db, Organization organization) =>
{
    organization.Id = Guid.NewGuid();
    db.Organizations.Add(organization);
    return organization;
});

app.Run();
