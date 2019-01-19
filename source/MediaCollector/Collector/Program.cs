using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Text;

namespace Collector
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            var configuration = builder.Build();
            //Console.WriteLine(configuration["smth"]);

            Console.ReadLine();
        }
    }
}
