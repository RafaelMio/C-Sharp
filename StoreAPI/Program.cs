using Microsoft.EntityFrameworkCore;
using StoreAPI.Data;
using System.Text.Json.Serialization;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Ajouter les services au conteneur
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

// Ajouter le contexte de base de données
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Configurer CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder => builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
});

var app = builder.Build();

// Configurer le pipeline de requêtes HTTP
if (app.Environment.IsDevelopment())
{
    app.MapScalarApiReference();
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// Utiliser CORS
app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();