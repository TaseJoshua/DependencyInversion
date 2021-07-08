using DependencyInversion.Entity;
using System;

namespace DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            IPatient patient = Factory.NewPatient();
            patient.FirstName = "James";
            patient.Surname = "Potts";

            IObservation observation = Factory.NewObservation();

            observation.ObservationName = "respiration";
            observation.PatientObs = patient;

            observation.PerformObs(58);
            observation.CompleteObs();

            Console.ReadLine();

        }
    }
}
