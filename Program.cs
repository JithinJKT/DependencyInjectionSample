using DependencyInjectionSample.Service;

namespace DependencyInjectionSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            //AddTransient: Services are created each time they are requested. This lifetime works best for lightweight, stateless services.
            builder.Services.AddTransient<ITransientService, TransientService>();
            //AddScoped: Services are created once per request (or scope). This is suitable for services that should be created once per web request.
            builder.Services.AddScoped<IScopedService, ScopedService>();
            //AddSingleton: Services are created the first time they are requested and then reused for all subsequent requests. This is suitable for stateful services.
            builder.Services.AddSingleton<ISingletonService, SingletonService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
