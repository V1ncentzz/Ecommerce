using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Data
{
    public class EcomDBcontext  : DbContext
    {
        public EcomDBcontext(DbContextOptions<EcomDBcontext> options) : base (options) { }

        DbSet<users> users { get; set; }

    }
}
