using MedicalCenter.UI;
using MedicalCenter.Infrastructure.Implementation;
using MedicalCenter.Infrastructure.Interface;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace MedicalCenter.UI
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());



            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7144") });
            builder.Services.AddScoped(typeof(IObjService<,,>), typeof(ObjService<,,>));
            var options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve,
            };
            await builder.Build().RunAsync();

        }
    }

}

