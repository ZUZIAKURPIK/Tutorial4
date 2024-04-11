using Microsoft.OpenApi.Models;
using Tutorial4.Database;
using Tutorial4.Endpoints;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();  // tu dodajemy tą klasę z końcówkai
builder.Services.AddSingleton<MockDb>();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo {Title = "My API", Version = "v1" });
    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.MapAnimalEndpoints();

app.MapControllers(); // i tu dodajemy klasę końcowke 

app.Run();




// {
//  "id": 3,
//  "name": "Saturn",
//  "category": "Cat",
//  "weight": 7.5,
//  "furColor": "Brown",
//  "visits": [
//  {
//      "visitDate": "2024-01-11T16:26:45.554Z",
//      "animalId": 3,
//      "description": "Blod tets",
//      "price": 100
//  }
//  ]
//  }