using IAquinoConfeitaria.Models;

namespace IAquinoConfeitaria.Routes
{
    public static class ClientRoutes
    {
        public static void ClientRoute(this WebApplication app)
        {
            app.MapGet(pattern: "client", () => new ClientModel("Gabriel","(16)997901419","CPF", new DateTime(1998,10,20), 0));
        }
    }
}
