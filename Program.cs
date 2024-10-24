//using Microsoft.AspNetCore.HttpOverrides;

//var builder = WebApplication.CreateBuilder(args);

//// Добавление сервисов Razor Pages
//builder.Services.AddRazorPages();

//var app = builder.Build();

//app.UseForwardedHeaders(new ForwardedHeadersOptions
//{
//    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
//});

//if (!app.Environment.IsDevelopment())
//{
//    app.UseHttpsRedirection();
//}

//app.UseStaticFiles();

//app.MapRazorPages();

//app.Run();
using Cocktails;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Cocktails
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}