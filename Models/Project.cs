namespace Portfolio.Models
{
    /// <summary>
    /// Class representation of the Project table in our code. This model will be used on a DbSet, that'll represent a table (for EFCore this time).
    /// </summary>
    public class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Uri Link { get; set; }
    }
}