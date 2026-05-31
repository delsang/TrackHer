using TrackHer;

namespace TrackHerWebApp.Models
{
    public class SymptomViewModel
    {
        public required string Name { get; set; }
        public required IReadOnlyList<SymptomOption> Values { get; set; }
    }
}
