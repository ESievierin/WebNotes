using WebNotes.DAL.Entities;
using WebNotes.DAL.Interfaces;
using WebNotes.DAL.Repositories;
using WebNotes.BLL.DTO;
using WebNotes.BLL.Service;
using WebNotes.BLL.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using WebNotes.API.Controllers;


var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddTransient<IWorkUnit, EFWorkUnit>()
    .AddTransient<IUserService, UserService>()
    .AddTransient<ITopicService, TopicService>()
    .AddTransient<INoteService, NoteService>();





builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseCors("corsapp");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
