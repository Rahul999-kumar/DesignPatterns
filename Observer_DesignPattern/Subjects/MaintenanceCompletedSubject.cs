using Observer_DesignPattern.Interfaces;
using Observer_DesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_DesignPattern.Subjects
{
    public class MaintenanceCompletedSubject : ISubject
    {
        private readonly List<IObserver> _observers = new();

        private MaintenanceCompletedEvent? _maintenanceEvent;

        public void Register(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public async Task PublishAsync(MaintenanceCompletedEvent maintenanceEvent)
        {
            _maintenanceEvent = maintenanceEvent;

            await NotifyAsync();
        }

        public async Task NotifyAsync()
        {
            foreach (var observer in _observers)
            {
                await observer.UpdateAsync(_maintenanceEvent!);
            }
        }
    }
}
