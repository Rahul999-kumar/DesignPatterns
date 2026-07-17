using Factory_DesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_DesignPattern.Notifications
{
    public class SMSNotification : INotification
    {
        public async Task SendAsync(string message)
        {
            Console.WriteLine($"💬 SMS Notification : {message}");
            await Task.CompletedTask;
        }
    }
}
