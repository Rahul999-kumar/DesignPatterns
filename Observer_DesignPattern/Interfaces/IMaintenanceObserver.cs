using Observer_DesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_DesignPattern.Interfaces
{
    public interface IObserver
    {
        Task UpdateAsync(MaintenanceCompletedEvent maintenanceEvent);
    }
}
