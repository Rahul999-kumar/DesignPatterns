using Observer_DesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_DesignPattern.Interfaces
{
    public interface ISubject
    {
        void Register(IObserver observer);

        void Remove(IObserver observer);

        Task PublishAsync(MaintenanceCompletedEvent maintenanceEvent);
    }
}
