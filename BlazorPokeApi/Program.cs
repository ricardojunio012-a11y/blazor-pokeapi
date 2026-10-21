using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorPokeApi;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// HttpClient apontando para a PokeAPI
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://pokeapi.co/api/v2/") });

await builder.Build().RunAsync();
