using AbstarctFactory_DesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstarctFactory_DesignPattern.Storage
{
    public class AzureBlobStorage : IStorage
    {
        public async Task UploadAsync(string fileName)
        {
            Console.WriteLine($"Uploading {fileName} to Azure Blob");

            await Task.CompletedTask;
        }
    }
}
