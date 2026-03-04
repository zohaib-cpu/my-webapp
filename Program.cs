var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

var app = builder.Build();

app.UseStaticFiles();
app.MapRazorPages();

// Add health check endpoint
app.MapGet("/health", () => Results.Ok("Backend is running"));

app.Run();