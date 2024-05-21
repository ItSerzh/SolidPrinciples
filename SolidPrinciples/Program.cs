using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SolidPrinciples.Implementation;
using SolidPrinciples.Interfaces;


var cfg = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.AddSingleton<IConfiguration>(cfg);
builder.Services.AddSingleton<IConfigurationReader, ConfigurationReader>();
builder.Services.AddSingleton<IInput, ConsoleInput>();
builder.Services.AddSingleton<IOutput, ConsoleOutput>();
builder.Services.AddSingleton<INumberGenerator, NumberGenerator>();
builder.Services.AddSingleton<INumberAnalyzer, NumberAnalyzer>();
builder.Services.AddSingleton<IInteractor, Interact>();
using IHost host = builder.Build();

var scope = host.Services.CreateScope();

var interactor = scope.ServiceProvider.GetRequiredService<IInteractor>();
interactor.Interact();