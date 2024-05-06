using Microsoft.EntityFrameworkCore;
using MVCConnect.DAL;

namespace MVCConnect
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer("Server=DESKTOP-6KN5926\\SQLEXPRESS;Database=FirstWeb;Trusted_connection=true;Integrated security=true;Encrypt=false");
            });
            var app = builder.Build();
            app.UseStaticFiles();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}"
                );

            app.Run();
        }
    }
}
