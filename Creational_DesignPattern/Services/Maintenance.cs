using Creational_DesignPattern.Enum;
using Creational_DesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_DesignPattern.Services
{
    public class Maintenance
    {
        private readonly IEnumerable<INotificationFactory> _notificationFactories;

        public Maintenance(IEnumerable<INotificationFactory> notificationFactories)
        {
            _notificationFactories = notificationFactories;
        }

        public async Task PerformMaintenanceAsync(NotificationType notificationType)
        {
            Console.WriteLine("Maintenance Completed.");

            var factory = _notificationFactories.FirstOrDefault(x =>
                x.notificationType == notificationType);

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
