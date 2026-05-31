namespace TrackHerWebApp.Services
{
    public interface ILlmInsightService
    {
        Task<LlmInsight> GetInsightAsync(
            string colourName,
            string hexColour,
            IReadOnlyDictionary<string, string> selectedSymptoms);
    }
}
