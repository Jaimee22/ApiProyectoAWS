using ApiProyectoAWS.Data;
using ApiProyectoAWS.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiProyectoAWS.Repositories
{
    public class RepositoryEventos
    {
        private EventosContext context;

        public RepositoryEventos(EventosContext context)
        {
            this.context = context;
        }

        public async Task<List<Provincia>> GetAllProvinciassAsync()
        {
            var provincias = await this.context.Provincias.ToListAsync();

            return provincias;
        }

    }
}
