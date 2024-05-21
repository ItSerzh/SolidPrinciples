namespace SolidPrinciples.Interfaces
{
    public interface IConfigurationReader
    {
        int MinVal { get; }
        int MaxVal { get; }
        int AttemptsCount { get; }
    }
}
