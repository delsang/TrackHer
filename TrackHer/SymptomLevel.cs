
namespace TrackHer
{
    public class SymptomLevel
    {
        public int Id { get; }
        public string SymptomGroup { get; set; }
        public string Description { get; }        
        public bool Happened { get; set; } = false;


        // Constructor to initialize values
        protected SymptomLevel(int id, string symptomGroup, string description)
        {
            Id = id;
            Description = description;
            SymptomGroup = symptomGroup;
        }
    }
}
