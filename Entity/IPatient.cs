namespace DependencyInversion.Entity
{
    public interface IPatient
    {
        string? FirstName { get; set; }
        string? Surname { get; set; }

        string ToString();
    }
}