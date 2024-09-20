using Microsoft.EntityFrameworkCore;
using Service.Data.Context;
using Service.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder
    .ConfigureLogging()
    .ConfigureServiceProvider()
    .ConfigureAppConfiguration();

// Add services to the container.
builder.Services.AddGrpc();

builder.Services.ConfigureDatabase(builder.Configuration);

var app = builder.Build();

using var scope = app.Services.CreateScope();

var services = scope.ServiceProvider;

var context = services.GetRequiredService<AppDbContext>();
await context.Database.MigrateAsync();
await context.Database.EnsureCreatedAsync();

// Configure the HTTP request pipeline.
app.MapGrpcService<Service.Services.UserService>();
app.MapGet("/", () => "");

app.Run();