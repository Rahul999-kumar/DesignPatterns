using AbstarctFactory_DesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstarctFactory_DesignPattern.Notifications
{
    public class PushNotification : INotification
    {
        public async Task SendAsync(string message)
        {
            Console.WriteLine($"📱 Push : {message}");

            await Task.CompletedTask;
        }
    }
}
