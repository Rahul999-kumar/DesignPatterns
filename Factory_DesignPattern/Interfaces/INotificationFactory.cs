using Factory_DesignPattern.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_DesignPattern.Interfaces
{
    public interface INotificationFactory
    {
        NotificationType NotificationType { get; }
        INotification Create();
    }
}
