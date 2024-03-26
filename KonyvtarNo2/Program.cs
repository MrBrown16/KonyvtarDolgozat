using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using KonyvtarNo2.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<KonyvtarNo2Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("KonyvtarNo2Context") ?? throw new InvalidOperationException("Connection string 'KonyvtarNo2Context' not found.")));

// Add services to the container.

builder.Services.AddControllers();
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
app.UseCors(builder => builder
       .AllowAnyHeader()
       .AllowAnyMethod()
       .AllowAnyOrigin()
);
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
