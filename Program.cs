using ApiPeliculas.Repositories;
using ApiPeliculas.Services;

var builder = WebApplication.CreateBuilder(args);

// Controllers
builder.Services.AddControllers();

// Swagger
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

// Dependency Injection
builder.Services.AddScoped<IPeliculaRepository, PeliculaRepository>();

builder.Services.AddScoped<IPeliculaService, PeliculaService>();

var app = builder.Build();

// Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();

    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();