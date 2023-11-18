using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Petshop.Domain.Interfaces.Services;
using Petshop.Service.Services;
using Petshop.Infrastructure.Data.Context;
using Petshop.Domain.Entities;
using Petshop.Domain.Interfaces.Repositories;
using Petshop.Infrastructure.Data.Repository;
using FluentValidation;
using Petshop.Service.Validators;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<PetshopContext>(options =>
  options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("Petshop.Infrastructure.Data")));

builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IBaseService<User>, BaseService<User>>();
builder.Services.AddScoped<IValidator<User>, UserValidator>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<PetshopContext>();
}

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
