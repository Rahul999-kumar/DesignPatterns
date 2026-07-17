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
    public class AirlineAirbusFactory : IAircraftMaintenanceFactory
    {
        private readonly PushNotification _pushNotification;
        private readonly PdfReportGenerator _pdfReportGenerator;
        private readonly AzureBlobStorage _azureBlobStorage;

        public AirlineType AirlineType => AirlineType.India;

        public AirlineAirbusFactory(PushNotification pushNotification,
        PdfReportGenerator pdfReportGenerator,
        AzureBlobStorage azureBlobStorage)
        {
            _pushNotification = pushNotification;
            _pdfReportGenerator = pdfReportGenerator;
            _azureBlobStorage = azureBlobStorage;
        }
        public INotification CreateNotification()
        {
            return _pushNotification;
        }

        public IReportGenerator CreateReport()
        {
            return _pdfReportGenerator;
        }

        public IStorage CreateStorage()
        {
            return _azureBlobStorage;
        }
    }
}
