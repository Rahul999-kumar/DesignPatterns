using Observer_DesignPattern.Interfaces;
using Observer_DesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_DesignPattern.Services
{
    public class MaintenanceService
    {
        private readonly IEnumerable<IMaintenanceObserver> _observers;

        public MaintenanceService(
            IEnumerable<IMaintenanceObserver> observers)
        {
            _observers = observers;
        }

        public async Task CompleteMaintenance(
            MaintenanceCompletedEvent maintenanceEvent)
        {
            Console.WriteLine(
                "Maintenance Completed Successfully");

            foreach (var observer in _observers)
            {
                await observer.UpdateAsync(maintenanceEvent);
            }
        }
    }
}
