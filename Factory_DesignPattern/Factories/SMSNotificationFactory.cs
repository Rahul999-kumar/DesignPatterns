using Factory_DesignPattern.Enum;
using Factory_DesignPattern.Interfaces;
using Factory_DesignPattern.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_DesignPattern.Factories
{
    public class SMSNotificationFactory : INotificationFactory
    {
        //private readonly IServiceProvider _serviceProvider;
        private readonly SMSNotification _smsNotification;
        public NotificationType NotificationType => NotificationType.SMS;

        //public SMSNotificationFactorycs(IServiceProvider serviceProvider)
        //{
        //    _serviceProvider = serviceProvider;
        //}

        public SMSNotificationFactory(SMSNotification smsNotification)
        {
            _smsNotification = smsNotification;
        }
        public INotification Create()
        {
            //return new Notifications.SMSNotification();
            //return _serviceProvider.GetRequiredService<INotification>();
            return _smsNotification;
        }
    }
}
