using Creational_DesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_DesignPattern.Notifications
{
    public class SMSNotification: INotification
    {
        public async Task SendAsync(string message)
        {
            Console.WriteLine($"💬 SMS Notification : {message}");
            await Task.CompletedTask;
        }
    }
}
