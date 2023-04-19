using Blazored.LocalStorage;
using MetaMood;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://kdt48lmf8a.execute-api.us-east-1.amazonaws.com") });
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddAutoMapper(typeof(AllMappersProfile));

await builder.Build().RunAsync();
