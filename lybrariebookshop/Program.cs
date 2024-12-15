using lybrariebookshop.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using lybrariebookshop.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextFactory<lybrariebookshopContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("lybrariebookshopContext") ?? throw new InvalidOperationException("Connection string 'lybrariebookshopContext' not found.")));

builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
