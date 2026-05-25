var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

var app = builder.Build();

app.UseCors("AllowAll");

app.MapGet("/", () => "Backend Working");

app.MapGet("/weather/{city}", (string city) =>
{
    return Results.Json(new
    {
        city = city,
        temperature = 32,
        description = "Sunny"
    });
});

app.Run("http://0.0.0.0:8080");