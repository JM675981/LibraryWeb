using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LibraryWeb.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Xml;
using Microsoft.VisualBasic;
using System.Net;

namespace LibraryWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public void SeedUsers(ModelBuilder builder)
        {
            IdentityUser user = new IdentityUser
            {
                Id = "38b276e9-b56f-404f-9571-86c49ab67ac7",
                UserName = "Alucard@Bellm.ont",
                NormalizedUserName = "ALUCARD@BELLM.ONT",
                Email = "Alucard@Bellm.ont",
                NormalizedEmail = "ALUCARD@BELLM.ONT",
                EmailConfirmed = true,
                LockoutEnabled = true,
            };
            PasswordHasher<IdentityUser> passwordHasher = new PasswordHasher<IdentityUser>();
            user.PasswordHash = passwordHasher.HashPassword(user, "P@ssw0rd");
            builder.Entity<IdentityUser>().HasData(user);

            user = new IdentityUser
            {
                Id = "ba9c50d2-92ad-448a-aff3-a9ec499b44f0",
                UserName = "Richter@Bellm.ont",
                NormalizedUserName = "RICHTER@BELLM.ONT",
                Email = "Richter@Bellm.ont",
                NormalizedEmail = "RICHTER@BELLM.ONT",
                EmailConfirmed = true,
                LockoutEnabled = true,
            };
            passwordHasher = new PasswordHasher<IdentityUser>();
            user.PasswordHash = passwordHasher.HashPassword(user, "P@ssw0rd");
            builder.Entity<IdentityUser>().HasData(user);

            user = new IdentityUser
            {
                Id = "e2eaf6fb-be20-4b9b-a071-c17566a4a6f8",
                UserName = "Dracula@Bellm.ont",
                NormalizedUserName = "DRACULA@BELLM.ONT",
                Email = "Dracula@Bellm.ont",
                NormalizedEmail = "DRACULA@BELLM.ONT",
                EmailConfirmed = true,
                LockoutEnabled = true,
            };
            passwordHasher = new PasswordHasher<IdentityUser>();
            user.PasswordHash = passwordHasher.HashPassword(user, "P@ssw0rd");
            builder.Entity<IdentityUser>().HasData(user);
        }

        private void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole()
                {
                    Id = "1",
                    Name = "User",
                    NormalizedName = "USER"
                },
                new IdentityRole()
                {
                    Id = "2",
                    Name = "Librarian",
                    NormalizedName = "LIBRARIAN"
                },
                new IdentityRole()
                {
                    Id = "3",
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                }
                );
        }

        private void SeedUserRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<String>>().HasData(
                new IdentityUserRole<String>()
                {
                    RoleId = "1",
                    UserId = "38b276e9-b56f-404f-9571-86c49ab67ac7",
                },
                new IdentityUserRole<String>()
                {
                    RoleId = "2",
                    UserId = "ba9c50d2-92ad-448a-aff3-a9ec499b44f0",
                },
                new IdentityUserRole<String>()
                {
                    RoleId = "3",
                    UserId = "e2eaf6fb-be20-4b9b-a071-c17566a4a6f8",
                }
                );
        }

        private void SeedBooks(ModelBuilder builder)
        {
            builder.Entity<Book>().HasData(
                new Book()
                {
                    BookID = 1,
                    BookTitle = "Professor Layton and the Curious Village",
                    BookDescription = "The professor investigates the mystery of the golden apple",
                    Count = 1,
                    AddedUser = "Richter@Bellm.ont",
                    LastEditUser = null,
                    EditDate = DateTime.Parse("4/10/2023"),
                },
                new Book()
                {
                    BookID = 2,
                    BookTitle = "Professor Layton and the Diabolical Box",
                    BookDescription = "The professor tries to solve the mystery of a box that kills any who opens it",
                    Count = 1,
                    AddedUser = "Richter@Bellm.ont",
                    LastEditUser = null,
                    EditDate = DateTime.Parse("4/10/2023"),
                },
                new Book()
                {
                    BookID = 3,
                    BookTitle = "Professor Layton and the Unwound Future",
                    BookDescription = "The professor gets a mysterious letter from a person claiming to be from the future",
                    Count = 1,
                    AddedUser = "Richter@Bellm.ont",
                    LastEditUser = null,
                    EditDate = DateTime.Parse("4/10/2023"),
                }
                );
        }

        private void SeedLoans(ModelBuilder builder)
        {
            builder.Entity<Loan>().HasData(
                new Loan()
                {
                    LoanID = 1,
                    BookID = 2,
                    Username = "Alucard@Bellm.ont",
                    DateLoaned = DateTime.Parse("4/12/2023"),
                    DueDate = DateTime.Parse("4/26/2023"),
                    IsLoaned = true,
                },
                new Loan()
                {
                    LoanID = 2,
                    BookID = 3,
                    Username = "Alucard@Bellm.ont",
                    DateLoaned = DateTime.Parse("4/12/2023"),
                    DueDate = DateTime.Parse("4/15/2023"),
                    IsLoaned = true,
                },
            new Loan()
            {
                LoanID = 3,
                BookID = 1,
                Username = "Alucard@Bellm.ont",
                DateLoaned = DateTime.Parse("4/12/2023"),
                DueDate = DateTime.Parse("4/15/2023"),
                IsLoaned = false,
            }
                );

        }

        public DbSet<Book>? Book { get; set; }
        public DbSet<Loan>? Loan { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            this.SeedUsers(builder);
            this.SeedRoles(builder);
            this.SeedUserRoles(builder);
            this.SeedBooks(builder);
            this.SeedLoans(builder);
        }
    }
}