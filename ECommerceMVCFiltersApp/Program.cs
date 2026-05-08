using ECommerceMVCFiltersApp.Filters;
using ECommerceMVCFiltersApp.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(options =>
{
    options.Filters.Add<GlobalExceptionFilter>();
});

builder.Services.AddScoped<LoggingService>();
builder.Services.AddScoped<AuthService>();

builder.Services.AddScoped<LoggingFilter>();
builder.Services.AddScoped<AuthFilter>();

builder.Services.AddScoped<GlobalExceptionFilter>();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Product}/{action=Index}/{id?}");

app.Run();