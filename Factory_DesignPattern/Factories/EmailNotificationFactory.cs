using Factory_DesignPattern.Enum;
using Factory_DesignPattern.Interfaces;
using Factory_DesignPattern.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_DesignPattern.Factories
{
    public class EmailNotificationFactory : INotificationFactory
    {
        private readonly EmailNotification _emailNotification;
        public NotificationType NotificationType => NotificationType.Email;

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
