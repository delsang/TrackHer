namespace TrackHerWebApp.Services
{
    public class ColourCalculator : IColourCalculator
    {
        public (int R, int G, int B) Calculate(IReadOnlyDictionary<string, int> selectionsByGroup)
        {
            var digits = string.Concat(selectionsByGroup
                .OrderBy(kvp => kvp.Key)
                .Select(kvp => kvp.Value.ToString()));

            int r = Math.Min(int.Parse(digits[0..3]), 255);
            int g = Math.Min(int.Parse(digits[3..6]), 255);
            int b = Math.Min(int.Parse(digits[6..9]), 255);

            return (r, g, b);
        }
    }
}
