using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext // Herda de IdentityDbContext para incluir as funcionalidades de autenticação
    {
        // Sobrescrever o construtor padrão
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
