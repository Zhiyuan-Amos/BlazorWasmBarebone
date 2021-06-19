using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorWasmBarebone
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            TimeStateContainer.Start();

            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            await builder.Build().RunAsync();
        }
    }
}
