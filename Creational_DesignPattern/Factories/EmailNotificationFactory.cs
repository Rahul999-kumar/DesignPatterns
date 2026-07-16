using Creational_DesignPattern.Enum;
using Creational_DesignPattern.Interfaces;
using Creational_DesignPattern.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_DesignPattern.Factories
{
    public class EmailNotificationFactory : INotificationFactory
    {
        private readonly EmailNotification _emailNotification;
        public NotificationType notificationType => NotificationType.Email;

        public EmailNotificationFactory(EmailNotification emailNotification)
        {
            _emailNotification = emailNotification;
        }
        public INotification Create()
        {
            //return new Notifications.EmailNotification();
            
            return _emailNotification;
        }
    }
}
