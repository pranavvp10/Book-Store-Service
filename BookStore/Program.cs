using BookStore.Core.Contexts;
using BookStore.Core.Repositories;
using BookStore.Core.Repositories.Interfaces;
using BookStore.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<BookStoreDBContext>(o =>
{
    o.UseSqlServer(builder.Configuration.GetConnectionString("BookStoreConnectionString"));
});
builder.Services.AddScoped<IBookRepository,BookRepository>();
builder.Services.AddScoped<IBookStoreService,BookStoreService>();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo 
    { Title ="Swagger API",
      Version = "v1",
      Description = "BookStore API"
    });
    c.IncludeXmlComments(Path.Combine("BookStoreSwagger.xml"));
}

);
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
