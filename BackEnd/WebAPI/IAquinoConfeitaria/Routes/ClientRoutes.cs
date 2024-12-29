using IAquinoConfeitaria.Data;
using IAquinoConfeitaria.Models;
using IAquinoConfeitaria.Models.Request;
using Microsoft.EntityFrameworkCore;

namespace IAquinoConfeitaria.Routes
{
    public static class ClientRoutes
    {
        public static void ClientRoute(this WebApplication app)
        {
            var route = app.MapGroup("client");

            route.MapPost("", async (ClientRequest req, WebApiContext context) =>
            {
                var client = new ClientModel(req.name, req.telefone, req.cpf, req.birthDay);
                await context.AddAsync(client);

                await context.SaveChangesAsync();
            });

            route.MapGet("", async (WebApiContext context) =>
            {
                var clients = await context.Clients.ToListAsync();
                return Results.Ok(clients);
            });

            route.MapPut("{id:guid}", async (Guid id, ClientRequest req, WebApiContext context) =>
            {
                var client = await context.Clients.FirstOrDefaultAsync(x => x.Id == id);

                if (client == null)
                    return Results.NotFound();

                client.UpdateClient(req.name, req.telefone, req.cpf, req.birthDay);

                await context.SaveChangesAsync();

                return Results.Ok(client);
            });

            route.MapPut("incementFidelity/{id:guid}", async (Guid id, WebApiContext context) =>
            {
                var client = await context.Clients.FirstOrDefaultAsync(x => x.Id == id);

                if (client == null)
                    return Results.NotFound();

                client.IncrementFidelity();

                await context.SaveChangesAsync();

                return Results.Ok(client);
            });

            route.MapDelete("{id:guid}", async (Guid id, WebApiContext context) =>
            {
                var client = await context.Clients.FirstOrDefaultAsync(x => x.Id == id);

                if (client == null)
                    return Results.NotFound();

                await context.Clients.Where(x => x.Id == id).ExecuteDeleteAsync();

                await context.SaveChangesAsync();

                return Results.Ok("Cliente deletado com sucesso!");
            });
        }
    }
}
