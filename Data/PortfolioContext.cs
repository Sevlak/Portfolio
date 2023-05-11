using Microsoft.EntityFrameworkCore;
using Portfolio.Data.ModelConfig;
using Portfolio.Models;

namespace Portfolio.Data
{
    /// <summary>
    /// Class that'll allow me to query the database. Each DbSet is a table represented by a model (Portfolio.Models).
    /// </summary>
    public class PortfolioContext: DbContext
    {
        protected DbSet<Project> Projects { get; set; }

        //We've created this constructor because we inject the dependency through the app initialization
        //For comparison, we would use the OnConfiguring method if we didn't inject the dependency.
        public PortfolioContext(DbContextOptions<PortfolioContext> options): base(options){}
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // We'll apply the configurations created for the Project entity.
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
        }
    }
}

