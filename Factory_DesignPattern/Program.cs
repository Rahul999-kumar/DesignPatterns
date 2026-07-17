
using Factory_DesignPattern.Enum;
using Factory_DesignPattern.Factories;
using Factory_DesignPattern.Interfaces;
using Factory_DesignPattern.Notifications;
using Factory_DesignPattern.Services;
using Microsoft.Extensions.DependencyInjection;


var services = new ServiceCollection();


// Register Notifications

services.AddScoped<PushNotification>();

services.AddScoped<EmailNotification>();

services.AddScoped<SMSNotification>();


// Register Factories

services.AddScoped<INotificationFactory, PushNotificationFactory>();

services.AddScoped<INotificationFactory, EmailNotificationFactory>();

services.AddScoped<INotificationFactory, SMSNotificationFactory>();


// Register Business Services

services.AddScoped<MaintenanceService>();


var provider = services.BuildServiceProvider();

var maintenanceService =
    provider.GetRequiredService<MaintenanceService>();

await maintenanceService.PerformMaintenanceAsync(NotificationType.Email);

Console.ReadLine();