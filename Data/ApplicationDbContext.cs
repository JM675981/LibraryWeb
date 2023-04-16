using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LibraryWeb.Models;

namespace LibraryWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<LibraryWeb.Models.Book>? Book { get; set; }
        public DbSet<LibraryWeb.Models.Loan>? Loan { get; set; }
    }
}