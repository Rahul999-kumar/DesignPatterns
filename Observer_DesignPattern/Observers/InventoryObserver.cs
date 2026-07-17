using Observer_DesignPattern.Interfaces;
using Observer_DesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_DesignPattern.Observers
{
    public class InventoryObserver : IMaintenanceObserver
    {
        public async Task UpdateAsync(MaintenanceCompletedEvent maintenanceEvent)
        {
            Console.WriteLine(
                $"🔧 Inventory Updated by {maintenanceEvent.EngineerName}");

            await Task.CompletedTask;
        }
    }
}
