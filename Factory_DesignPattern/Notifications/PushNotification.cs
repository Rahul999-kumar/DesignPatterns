using Factory_DesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_DesignPattern.Notifications
{
    public class PushNotification : INotification
    {
        public async Task SendAsync(string message)
        {
            Console.WriteLine($"📱 Push Notification : {message}");
            await Task.CompletedTask;
        }
    }
}
