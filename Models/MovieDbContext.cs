using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A9Movie.Models
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext (DbContextOptions<MovieDbContext> options) : base (options)
        {
           
        }

        // enables us to query from the database 
        public DbSet<Movie> Movies { get; set; }
    }
}
