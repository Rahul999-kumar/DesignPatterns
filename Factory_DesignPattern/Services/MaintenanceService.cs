using Factory_DesignPattern.Enum;
using Factory_DesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_DesignPattern.Services
{
    public class MaintenanceService
    {
        private readonly IEnumerable<INotificationFactory> _notificationFactories;

        public MaintenanceService(IEnumerable<INotificationFactory> notificationFactories)
        {
            _notificationFactories = notificationFactories;
        }

        public async Task PerformMaintenanceAsync(NotificationType notificationType)
        {
            Console.WriteLine("Maintenance Completed.");

            var factory = _notificationFactories.FirstOrDefault(x =>
                x.NotificationType == notificationType);

            if (factory == null)
            {
                throw new InvalidOperationException(
                    $"Notification Factory not found for {notificationType}");
            }

            var notification = factory.Create();

            await notification.SendAsync(
                "Aircraft Maintenance Completed Successfully.");
        }
    }
}
