using System;

namespace DependencyInversion.Entity
{
    public class Logger : ILogger
    {
        public void Log(string log)
        {
            Console.WriteLine(log);
        }
    }
}
