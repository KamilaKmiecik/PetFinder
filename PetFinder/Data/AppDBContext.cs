using Microsoft.EntityFrameworkCore;
using PetFinder.Entities;

namespace PetFinder.Data
{

    //bdcontext represents a session in the db

    //primary ctor :>
    public class AppDbContext(DbContextOptions dboptions) : DbContext(dboptions)
    {
        public DbSet<PetAppUser> PetUsers { get; set; }
    }
}
