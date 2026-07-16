using Creational_DesignPattern.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_DesignPattern.Interfaces
{
    public interface INotificationFactory
    {
        NotificationType notificationType { get; }
        INotification Create();
    }
}
