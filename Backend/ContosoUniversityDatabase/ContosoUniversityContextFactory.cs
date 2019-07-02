using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Database
{
    public class ContosoUniversityContextFactory : IDesignTimeDbContextFactory<ContosoUniversityContext>
    {
        public ContosoUniversityContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<ContosoUniversityContext>();
            var connectionString = configuration.GetConnectionString("ContosoUniversityDb");
            builder.UseSqlServer(connectionString);

            return new ContosoUniversityContext(builder.Options);
        }
    }
}