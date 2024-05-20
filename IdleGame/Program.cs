using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using IdleGame;
using Blazored.LocalStorage;
using Models.GlobalVariables;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


// Add global variables to persist between navigation of urls 
builder.Services.AddSingleton<GlobalBool>();
builder.Services.AddSingleton<GlobalSave>();
builder.Services.AddSingleton<GlobalPage>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddBlazoredLocalStorage(config => config.JsonSerializerOptions.IncludeFields = true);

await builder.Build().RunAsync();
