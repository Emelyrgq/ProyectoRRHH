using Microsoft.EntityFrameworkCore;

namespace ProyectoRRHH
{
    public class ApplicationBDContext : DbContext
    {
        public ApplicationBDContext(DbContextOptions<ApplicationBDContext> options) : base(options) { }
    }
}
