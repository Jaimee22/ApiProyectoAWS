using ApiProyectoAWS.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiProyectoAWS.Data
{
    public class EventosContext: DbContext
    {
        public EventosContext(DbContextOptions<EventosContext> options) : base(options) { }
        public DbSet<Provincia> Provincias { get; set; }
    }
}
