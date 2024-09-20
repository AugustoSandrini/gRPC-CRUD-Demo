using Microsoft.EntityFrameworkCore;
using Service.Data.Context;

namespace Service.Extensions
{
    public static class DataBaseExtension
    {
        public static void ConfigureDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("Default"));
            });
        }
    }
}
