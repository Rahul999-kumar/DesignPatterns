using AbstarctFactory_DesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstarctFactory_DesignPattern.Notifications
{
    public class EmailNotification : INotification
    {
        public async Task SendAsync(string message)
        {
            Console.WriteLine($"📧 Email : {message}");

            await Task.CompletedTask;
        }
    }
}
