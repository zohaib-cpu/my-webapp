var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles();   // index.html auto load
app.UseStaticFiles();    // wwwroot serve karega

app.Run();