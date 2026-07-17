using Factory_DesignPattern.Enum;
using Factory_DesignPattern.Interfaces;
using Factory_DesignPattern.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_DesignPattern.Factories
{
    public class PushNotificationFactory : INotificationFactory
    {
        private readonly PushNotification _pushNotification;
        public NotificationType NotificationType => NotificationType.Push;

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
