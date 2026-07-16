using Creational_DesignPattern.Enum;
using Creational_DesignPattern.Factories;
using Creational_DesignPattern.Interfaces;
using Creational_DesignPattern.Notifications;
using Creational_DesignPattern.Services;
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

services.AddScoped<Maintenance>();


var provider = services.BuildServiceProvider();

var maintenanceService =
    provider.GetRequiredService<Maintenance>();

await maintenanceService.PerformMaintenanceAsync(NotificationType.Email);

Console.ReadLine();