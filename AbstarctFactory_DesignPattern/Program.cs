using AbstarctFactory_DesignPattern.Enum;
using AbstarctFactory_DesignPattern.Factories;
using AbstarctFactory_DesignPattern.Interfaces;
using AbstarctFactory_DesignPattern.Models;
using AbstarctFactory_DesignPattern.Notifications;
using AbstarctFactory_DesignPattern.Reports;
using AbstarctFactory_DesignPattern.Services;
using AbstarctFactory_DesignPattern.Storage;
using Microsoft.Extensions.DependencyInjection;


var services = new ServiceCollection();


// Products

services.AddScoped<PushNotification>();

services.AddScoped<EmailNotification>();

services.AddScoped<PdfReportGenerator>();

services.AddScoped<ExcelReportGenerator>();

services.AddScoped<AzureBlobStorage>();

services.AddScoped<AwsStorage>();


// Factories

services.AddScoped<IAircraftMaintenanceFactory,
                   AirlineAirbusFactory>();

services.AddScoped<IAircraftMaintenanceFactory,
                   AirlineBoeingFactory>();


// Business Services

services.AddScoped<MaintenanceService>();


var provider = services.BuildServiceProvider();

var maintenanceService =
    provider.GetRequiredService<MaintenanceService>();


var request = new MaintenanceRequest
{
    AircraftId = 1001,

    AirlineType = AirlineType.India,

    EngineerName = "Rahul Kumar"
};

await maintenanceService.CompleteMaintenance(request);

Console.ReadLine();