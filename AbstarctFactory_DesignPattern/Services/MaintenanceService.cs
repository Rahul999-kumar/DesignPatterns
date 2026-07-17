using AbstarctFactory_DesignPattern.Interfaces;
using AbstarctFactory_DesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstarctFactory_DesignPattern.Services
{
    public class MaintenanceService
    {
        private readonly IEnumerable<IAircraftMaintenanceFactory> _factories;

        public MaintenanceService(
            IEnumerable<IAircraftMaintenanceFactory> factories)
        {
            _factories = factories;
        }

        public async Task CompleteMaintenance(
            MaintenanceRequest request)
        {
            Console.WriteLine(
                $"Maintenance completed for Aircraft : {request.AircraftId}");

            var factory = _factories.FirstOrDefault(x =>
                x.AirlineType == request.AirlineType);

            if (factory == null)
            {
                throw new Exception("Factory not found.");
            }

            var notification = factory.CreateNotification();

            var report = factory.CreateReport();

            var storage = factory.CreateStorage();

            await report.GenerateAsync();

            await storage.UploadAsync("MaintenanceReport.pdf");

            await notification.SendAsync(
                $"Maintenance completed by {request.EngineerName}");
        }
    }
}
