using AbstarctFactory_DesignPattern.Enum;
using AbstarctFactory_DesignPattern.Interfaces;
using AbstarctFactory_DesignPattern.Notifications;
using AbstarctFactory_DesignPattern.Reports;
using AbstarctFactory_DesignPattern.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstarctFactory_DesignPattern.Factories
{
    public class AirlineBoeingFactory : IAircraftMaintenanceFactory
    {
        private readonly EmailNotification _emailNotification;
        private readonly ExcelReportGenerator _excelReportGenerator;
        private readonly AwsStorage _awsStorage;

        public AirlineType AirlineType => AirlineType.Europe;

        public AirlineBoeingFactory(EmailNotification emailNotification,
        ExcelReportGenerator excelReportGenerator,
        AwsStorage awsStorage)
        {
            _emailNotification = emailNotification;
            _excelReportGenerator = excelReportGenerator;
            _awsStorage = awsStorage;
        }

        public INotification CreateNotification()
        {
            return _emailNotification;
        }

        public IReportGenerator CreateReport()
        {
            return _excelReportGenerator;
        }

        public IStorage CreateStorage()
        {
            return _awsStorage;
        }
    }
}
