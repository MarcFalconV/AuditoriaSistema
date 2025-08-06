
using Microsoft.EntityFrameworkCore;
using auditoriaBackend.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<EncuestaDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EncuestaDbContext")));

builder.Services.AddControllers(); // <-- esto habilita los [ApiController]
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Mi API v1");
    c.RoutePrefix = string.Empty; // Swagger UI en /
});

app.UseHttpsRedirection();

// este mapea todos los controladores con [ApiController]
app.MapControllers();

app.Run();
