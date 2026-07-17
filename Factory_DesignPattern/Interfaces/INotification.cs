using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_DesignPattern.Interfaces
{
    public interface INotification
    {
        Task SendAsync(string message);
    }
}
