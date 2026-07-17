using Microsoft.Extensions.DependencyInjection;
using Observer_DesignPattern.Interfaces;
using Observer_DesignPattern.Models;
using Observer_DesignPattern.Observers;
using Observer_DesignPattern.Services;

var services = new ServiceCollection();

services.AddScoped<IMaintenanceObserver,
                   NotificationObserver>();

services.AddScoped<IMaintenanceObserver,
                   ReportObserver>();

services.AddScoped<IMaintenanceObserver,
                   InventoryObserver>();

services.AddScoped<MaintenanceService>();

var provider = services.BuildServiceProvider();

var service =
    provider.GetRequiredService<MaintenanceService>();

await service.CompleteMaintenance(
    new MaintenanceCompletedEvent
    {
        AircraftId = 101,
        EngineerName = "Rahul",
        CompletedOn = DateTime.Now
    });