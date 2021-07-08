namespace DependencyInversion.Entity
{
    public interface IObservation
    {
        bool IsComplete { get; }
        string? ObservationName { get; set; }
        double ObservationResult { get; }
        IPatient? PatientObs { get; set; }

        void CompleteObs();
        void PerformObs(double value);
    }
}