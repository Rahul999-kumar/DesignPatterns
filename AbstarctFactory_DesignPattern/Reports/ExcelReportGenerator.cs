using AbstarctFactory_DesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstarctFactory_DesignPattern.Reports
{
    public class ExcelReportGenerator : IReportGenerator
    {
        public async Task GenerateAsync()
        {
            Console.WriteLine("Generating Excel Report...");

            await Task.CompletedTask;
        }
    }
}
