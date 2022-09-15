global using Pixzor.Models;
global using Pixzor.Resources;
global using Pixzor.Services;

global using System.Net.Http.Headers;
global using System.Net.Http.Json;
global using System.Text.Json.Serialization;

using Blazored.LocalStorage;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

using MudBlazor.Services;

using Pixzor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredLocalStorage();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddMudServices();

builder.Services.AddScoped<IPhotoService, PhotoService>();
builder.Services.AddScoped<IVideoService, VideoService>();
builder.Services.AddScoped<ICollectionService, CollectionService>();

/* Pexel API */
builder.Services.AddHttpClient("PexelPhoto", client =>
{
    client.BaseAddress = new Uri(Constants.BASE_URL);
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(Constants.API_KEY);
});
builder.Services.AddHttpClient("PexelVideo", client =>
{
    client.BaseAddress = new Uri(Constants.VIDEO_BASE_URL);
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(Constants.API_KEY);
});

await builder.Build().RunAsync();