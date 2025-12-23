using System.Data;
using FluentMigrator.Runner;
using JobService.Dal.Migrations;
using JobService.Dal.Repositories.JobRepository;
using JobService.Dal.Repositories.TicketRepository;
using JobService.Logic.JobLogicService;
using JobService.Logic.TicketLogicService;
using Npgsql;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// БД
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddScoped<IDbConnection>(sp => new NpgsqlConnection(connectionString));
builder.Services.AddFluentMigratorCore()
    .ConfigureRunner(rb => rb
        .AddPostgres()
        .WithGlobalConnectionString(connectionString)
        .ScanIn(typeof(AddTablesMigration).Assembly).For.Migrations())
    .AddLogging(lb => lb.AddFluentMigratorConsole());

// DI
builder.Services.AddTransient<IJobLogicService, JobLogicService>();
builder.Services.AddTransient<ITicketLogicService, TicketLogicService>();
builder.Services.AddTransient<IJobRepository, JobRepository>();
builder.Services.AddTransient<ITicketRepository, TicketRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();