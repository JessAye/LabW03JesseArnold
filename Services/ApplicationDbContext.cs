using LabW03JesseArnold.Models.Entities;
using Microsoft.EntityFrameworkCore;
namespace LabW03JesseArnold.Services{


    

        public class ApplicationDbContext : DbContext
        {
            public DbSet<Person> People => Set<Person>();

            public ApplicationDbContext(DbContextOptions options) : base(options)
            {

            }
        }
    }

