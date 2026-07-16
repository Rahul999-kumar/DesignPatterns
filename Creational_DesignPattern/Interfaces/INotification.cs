using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_DesignPattern.Interfaces
{
    public interface INotification
    {
        Task SendAsync(string message);
    }
}
