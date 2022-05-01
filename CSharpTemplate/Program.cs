using Business;
using Composer;
using Mappers;
using Repositories;
using RepositoryBridge;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IPersonsComposer, PersonsComposer>();
builder.Services.AddTransient<IPersonsService, PersonsService>();
builder.Services.AddTransient<IPersonsMapper, PersonsMapper>();
builder.Services.AddTransient<IPersonsRepository, PersonsRepository>();
builder.Services.AddTransient<IPersonsBridge, PersonsBridge>();

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.


app.UseAuthorization();

app.MapControllers();

app.Run();
