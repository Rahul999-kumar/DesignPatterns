using AbstarctFactory_DesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstarctFactory_DesignPattern.Reports
{
    public class PdfReportGenerator : IReportGenerator
    {
        public async Task GenerateAsync()
        {
            Console.WriteLine("Generating PDF Report...");

            await Task.CompletedTask;
        }
    }
}
