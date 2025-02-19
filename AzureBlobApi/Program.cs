using Microsoft.AspNetCore.Builder; // For Web apps
using Microsoft.Extensions.Hosting;  // For Host configuration
using Microsoft.Extensions.DependencyInjection; // For DI
using System.Text.Json.Serialization; //For JSON serialization options


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Add services to the container.  This is where you register dependencies
builder.Services.AddControllers()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
                    options.JsonSerializerOptions.PropertyNamingPolicy = null; // Or customize
                });


var app = builder.Build();

app.UseCors(builder => builder
     .AllowAnyOrigin()
     .AllowAnyMethod()
     .AllowAnyHeader()); 

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

 app.MapControllers();

// app.MapGet("/api/AzureBlobApi/", async () =>
// {
//     return Results.Ok(await )
// });
app.Run();

 