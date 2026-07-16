using Creational_DesignPattern.Enum;
using Creational_DesignPattern.Interfaces;
using Creational_DesignPattern.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_DesignPattern.Factories
{
    public class PushNotificationFactory : INotificationFactory
    {
        private readonly PushNotification _pushNotification;
        public NotificationType notificationType => NotificationType.Push;

        public PushNotificationFactory(PushNotification pushNotification)
        {
            _pushNotification = pushNotification;
        }
        public INotification Create()
        {
            return _pushNotification;
        }
    }
}
