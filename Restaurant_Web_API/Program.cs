using Microsoft.EntityFrameworkCore;
using Restaurant_Web_API.Database_Class;
using Restaurant_Web_API.Services;
using Restaurant_Web_API.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;




var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<RestaurantContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("CaliforniaRestaurantDatabase")));


builder.Services.AddScoped<DatabaseSeeder>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    DatabaseSeeder DBSeeder = new DatabaseSeeder();
    DBSeeder.Initialize(services);

}

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
