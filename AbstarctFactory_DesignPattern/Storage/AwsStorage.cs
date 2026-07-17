using AbstarctFactory_DesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstarctFactory_DesignPattern.Storage
{
    public class AwsStorage : IStorage
    {
        public async Task UploadAsync(string fileName)
        {
            Console.WriteLine($"Uploading {fileName} to AWS S3");

            await Task.CompletedTask;
        }
    }
}
