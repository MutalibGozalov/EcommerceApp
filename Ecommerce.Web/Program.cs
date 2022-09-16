using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Ecommerce.Web;
using Ecommerce.Web.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<INewClass, NewClass>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7182") });

await builder.Build().RunAsync();
