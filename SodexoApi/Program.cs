using SodexoApi.Helpers;
using SodexoApi.Models;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
builder.Services.AddOICDAuthentication(new TokenParams
{
    ValidAudience = configuration["JWT:ValidAudience"],
    ValidIssuer = configuration["JWT:ValidIssuer"],
    Key = configuration["JWT:Secret"]
});
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerWithToken();

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
