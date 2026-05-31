using System.Text.Json;

namespace TrackHerWebApp.Services
{
    public class ColourApiClient : IColourApiClient
    {
        private readonly HttpClient _httpClient;

        public ColourApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ColourResult> GetColourAsync(int r, int g, int b)
        {
            var json = await _httpClient.GetStringAsync(
                $"https://www.thecolorapi.com/id?rgb=rgb({r},{g},{b})");

            using var doc = JsonDocument.Parse(json);
            var name = doc.RootElement.GetProperty("name").GetProperty("value").GetString() ?? "Unknown";
            var hex = doc.RootElement.GetProperty("hex").GetProperty("value").GetString() ?? "#000000";

            return new ColourResult(name, hex);
        }
    }
}
