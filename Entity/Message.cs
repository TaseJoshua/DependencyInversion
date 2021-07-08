using System;

namespace DependencyInversion.Entity
{
    public class Message : IMessage
    {
        public void Text(IPatient? patient, string message)
        {
            if (patient is not null)
            {
                Console.WriteLine($"Hi {patient.FirstName}, {message}");
            }

        }
    }
}
