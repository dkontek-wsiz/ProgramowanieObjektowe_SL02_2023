using Lab2.Interfaces;
using Lab2.Lab6;
using WebApplication1.Repostories;
using WebApplication1.Utilites;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

DbCreator.CreateTable(builder.Configuration.GetConnectionString("DefaultConnection"));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IPersonRepository, FilePersonRepository>();
builder.Services.AddScoped<IBookRepository, ADONETBookRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
