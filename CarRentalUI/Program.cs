using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

// ✅ IMPORTANT: Add this BEFORE UseStaticFiles()
app.UseDefaultFiles();   // <-- THIS SERVES index.html AT ROOT URL

app.UseStaticFiles();    // HTML / CSS / JS / IMAGES

app.UseRouting();

app.MapControllers();
app.MapFallbackToFile("index.html");   // safe fallback

app.Run();
