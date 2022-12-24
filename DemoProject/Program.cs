// See https://aka.ms/new-console-template for more information
using DemoProject;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddScoped<INumerics, Numerics>();
        services.AddScoped<ISampleClass, SampleClass>();
    })
    .Build();


//await host.RunAsync();