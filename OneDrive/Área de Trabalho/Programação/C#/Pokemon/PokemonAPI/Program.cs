using Microsoft.EntityFrameworkCore;
using PokemonAPI.Data.Context;
using PokemonAPI.Repository;
using PokemonAPI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEntityFrameworkSqlServer()
    .AddDbContext<PokemonContext>(o => o.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=pokemon;Integrated Security=True;TrustServerCertificate=True;"));


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Adicionar o serviço do seu serviço de Pessoa, se você tiver um.
builder.Services.AddScoped<PokemonRepository>();
builder.Services.AddScoped<PokemonServices>();
builder.Services.AddScoped<MestrePokemonServices>();
builder.Services.AddScoped<MestrePokemonRepository>();

var app = builder.Build();

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
