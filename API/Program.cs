using API.Extensions;
using Aplication.Contracts;
using Aplication.Services;
using DataAccess;
using DataAccess.Contracts;
using DataAccess.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.ConfigureCors(); // politica CORS de la app

builder.Services.AddControllers();

builder.Services.AddDbContext<TiendaContext>();

builder.Services.AddScoped<IArtistService, ArtistService>();
builder.Services.AddScoped<IArtistRepository, ArtistRepository>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
