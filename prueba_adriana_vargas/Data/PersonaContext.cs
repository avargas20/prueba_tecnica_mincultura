using Microsoft.EntityFrameworkCore;
using prueba_adriana_vargas.Models;

namespace prueba_adriana_vargas.Data
{
    public class PersonaContext : DbContext
    {
        public PersonaContext(DbContextOptions<PersonaContext> options)
            : base(options)
        {
        }

        public DbSet<Persona> Persona { get; set; }
    }
}