using Crud.Context;
using Crud.Models;

namespace Crud.Routes;

public static class CrudRoute
{
    public static void CrudRoutes(this WebApplication app) 
    {
        var route = app.MapGroup(prefix: "crud");
        route.MapPost("", 
            async (CrudRequest req, CrudContext context) => {
                var person = new CrudModel(req.name);
                await context.AddAsync(person);
                await context.SaveChangesAsync();
            });
    }
}