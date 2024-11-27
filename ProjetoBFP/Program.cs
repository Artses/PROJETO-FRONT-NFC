using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ProjetoBFP;
using ProjetoBFP.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddScoped<AlunosClient>();
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped<LoginClient>();
builder.Services.AddScoped<CadastroClient>();
builder.Services.AddScoped<ChamadaClient>();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:3000/") });

await builder.Build().RunAsync();
