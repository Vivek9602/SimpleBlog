using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace SimpleBlog
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        }

    }
}
