using Disciplinas.Data.Context;
using Disciplinas.Repository;
using Disciplinas.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEntityFrameworkSqlServer()
    .AddDbContext<BdContext>(o => o.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=disciplinas;Integrated Security=True;TrustServerCertificate=True;"));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<DisciplinaRepository>();
builder.Services.AddScoped<DisciplinaService>();

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
