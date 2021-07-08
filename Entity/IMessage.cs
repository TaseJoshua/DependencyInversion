namespace DependencyInversion.Entity
{
    public interface IMessage
    {
        void Text(IPatient? patient, string message);
    }
}