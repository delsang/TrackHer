namespace TrackHerWebApp.Services
{
    public interface IColourCalculator
    {
        (int R, int G, int B) Calculate(IReadOnlyDictionary<string, int> selectionsByGroup);
    }
}
