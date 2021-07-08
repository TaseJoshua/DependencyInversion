using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.Entity
{
    public class Observation : IObservation
    {
        private readonly ILogger _logger;
        private readonly IMessage _message;

        public string? ObservationName { get; set; }
        public IPatient? PatientObs { get; set; }
        public double ObservationResult { get; private set; }

        public bool IsComplete { get; private set; }
        public Observation(ILogger logger, IMessage message)
        {
            _logger = logger;
            _message = message;
        }
        public void PerformObs(double value)
        {
            ObservationResult = value;
         _logger.Log($"Performed {ObservationName}");
        }
        public void CompleteObs()
        {
            IsComplete = true;

            
            if (PatientObs is not null)
            {
                _logger.Log($"{ObservationName} observation for {PatientObs.FirstName} is complete");
            }


            
            _message.Text(PatientObs, $"your {ObservationName} observation is complete.");
        }
    }
}
