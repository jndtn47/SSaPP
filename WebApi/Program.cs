using System.Reflection.Metadata.Ecma335;
using Entities;
using Microsoft.EntityFrameworkCore;
using WebApi;

var builder = WebApplication.CreateBuilder(args);
string connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlite(connection));

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();


#region Organizations
app.MapGet("/api/orgs", async (ApplicationContext db) => await db.Organizations.ToListAsync());

app.MapGet("/api/orgs/{id:guid}", async (Guid id, ApplicationContext db) =>
{
    var organization = await db.Organizations.FirstOrDefaultAsync(org => org.Id == id);
    return organization == null ? Results.NotFound(new { message = "Организация не найдена" }) : Results.Json(organization);
});

app.MapPost("api/orgs", async (Organization organization, ApplicationContext db) =>
{
    organization.Id = Guid.NewGuid();
    await db.Organizations.AddAsync(organization);
    await db.SaveChangesAsync();
    return Results.Json(organization);
});

app.MapDelete("/api/orgs/{id:guid}", async (Guid id, ApplicationContext db) =>
{
    var organization = await db.Organizations.FirstOrDefaultAsync(org => org.Id == id);
    if (organization == null) return Results.NotFound(new { message = "Организация не найдена" });
    db.Organizations.Remove(organization);
    await db.SaveChangesAsync();
    return Results.Json(organization);

});
#endregion


app.Run();
