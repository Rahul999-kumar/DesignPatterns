using Creational_DesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_DesignPattern.Notifications
{
    public class PushNotification: INotification
    {
        public async Task SendAsync(string message)
        {
            Console.WriteLine($"📱 Push Notification : {message}");
            await Task.CompletedTask;
        }
    }
}
