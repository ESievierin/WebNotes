using WebNotes.DAL.Entities;
using WebNotes.DAL.Interfaces;
using WebNotes.DAL.Repositories;
using WebNotes.BLL.DTO;
using WebNotes.BLL.Service;
using WebNotes.BLL.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;




var serviceProvider = new ServiceCollection()
    .AddLogging()
    .AddTransient<IUserService, UserService>()
    .AddTransient<ITopicService, TopicService>()
    .AddTransient<INoteService, NoteService>()
    .AddTransient<IWorkUnit, EFWorkUnit>()
    .AddTransient<INoteRepository, NoteRepository>()
    .AddTransient<ITopicRepository, TopicRepository>()
    .AddTransient<IUserRepository, UserRepository>()
    .BuildServiceProvider();

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();


var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
