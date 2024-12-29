using IAquinoConfeitaria.Data;
using IAquinoConfeitaria.Models;
using IAquinoConfeitaria.Models.Request;

namespace IAquinoConfeitaria.Routes
{
    public static class ClientRoutes
    {
        public static void ClientRoute(this WebApplication app)
        {
            var route =  app.MapGroup("client");

            route.MapPost("", async (ClientRequest req, WebApiContext context) =>
            {
                var client = new ClientModel(req.name, req.telefone, req.cpf, req.birthDay);
                await context.AddAsync(client);

                await context.SaveChangesAsync();
            });
        }
    }
}
