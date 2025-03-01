using TrackHer;

namespace TrackHerWebApp.Models
{
    public class SymptomViewModel
    {
        public required string Name { get; set; }
        public required List<SymptomLevel> Values { get; set; } = new List<SymptomLevel>();

    }
}
