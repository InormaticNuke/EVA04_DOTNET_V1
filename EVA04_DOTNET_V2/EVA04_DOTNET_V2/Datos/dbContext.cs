using EVA04_DOTNET_V2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EVA04_DOTNET_V2.Datos
{
    public class dbContext : IdentityDbContext
    {
        public dbContext(DbContextOptions options) : base (options)
        {

        }

        public DbSet<Usuario> claseUsuario { get; set; }
    }
}
