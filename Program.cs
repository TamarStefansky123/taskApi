using Microsoft.EntityFrameworkCore;
using Tasks.Models;
using Tasks.Repositiers;
using Tasks.Services;
using Microsoft.EntityFrameworkCore;
using Tasks.Repositiers;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<ITaskScervice, TasksService>();
builder.Services.AddTransient<ITaskRepository, TasksRepository>();
// Add services to the container.
builder.Services.AddDbContext<TasksDbContext>(options =>
  options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);
builder.Services.AddControllers();
// Learn more about conf0iguring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

