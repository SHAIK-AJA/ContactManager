using Microsoft.EntityFrameworkCore;
using ContactManager.Models;
namespace ContactManager.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        {
            
        }
        public DbSet<Contact> Contacts{ get; set; }
    }
}
