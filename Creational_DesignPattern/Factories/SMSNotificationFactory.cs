using Creational_DesignPattern.Enum;
using Creational_DesignPattern.Interfaces;
using Creational_DesignPattern.Notifications;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_DesignPattern.Factories
{
    public class SMSNotificationFactory : INotificationFactory
    {
        //private readonly IServiceProvider _serviceProvider;
        private readonly SMSNotification _smsNotification;
        public NotificationType notificationType => NotificationType.SMS;

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
