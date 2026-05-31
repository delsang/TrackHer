namespace TrackHerWebApp.Services
{
    public interface IColourApiClient
    {
        Task<ColourResult> GetColourAsync(int r, int g, int b);
    }
}
