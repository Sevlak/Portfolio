using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.Models;

namespace Portfolio.Data.ModelConfig
{
    /// <summary>
    /// This class is responsible for configuring the Project entity (model, whatever) when we query
    /// </summary>
    public class ProjectConfiguration: IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            //This makes a conversion when we introduce a link to the Project table and when we get a link from the table, respectively.
            builder.Property(p => p.Link).HasConversion(p => p.ToString(), p => new Uri(p));
        }
    }
}