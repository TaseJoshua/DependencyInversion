namespace DependencyInversion.Entity
{
    public class Patient : IPatient
    {

        public string? FirstName { get; set; }
        public string? Surname { get; set; }

        public override string ToString() => $"Patient: Firstname - {FirstName} ** Surname: {Surname}";

    }
}
