using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TrackHerWebApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Register services
var mvcBuilder = builder.Services.AddControllersWithViews();
if (builder.Environment.IsDevelopment())
    mvcBuilder.AddRazorRuntimeCompilation();
builder.Services.AddHttpClient<IColourApiClient, ColourApiClient>();
builder.Services.AddScoped<IColourCalculator, ColourCalculator>();
builder.Services.AddSingleton<ILlmInsightService, ClaudeInsightService>();

// Configure middleware
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // Development-specific error page
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); // Security header for HTTPS
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Configure endpoints
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();