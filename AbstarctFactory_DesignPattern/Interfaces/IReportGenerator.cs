using System;
using System.Collections.Generic;
using System.Text;

namespace AbstarctFactory_DesignPattern.Interfaces
{
    public interface IReportGenerator
    {
        Task GenerateAsync();
    }
}
