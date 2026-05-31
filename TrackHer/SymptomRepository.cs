namespace TrackHer
{
    public static class SymptomRepository
    {
        private static readonly IReadOnlyList<SymptomOption> _symptoms =
        [
            // Brain Fog
            new(0, "Brain Fog", "No brain fog today"),
            new(1, "Brain Fog", "Brain fog upon waking up"),
            new(2, "Brain Fog", "Brain fog in the morning"),
            new(3, "Brain Fog", "Brain fog in the afternoon"),
            new(4, "Brain Fog", "Brain fog in the evening"),
            new(5, "Brain Fog", "Brain fog all day long"),

            // Decreased Libido
            new(0, "Decreased Libido", "No change in libido"),
            new(1, "Decreased Libido", "Feeling normal"),
            new(2, "Decreased Libido", "Feeling quite the opposite"),

            // Fatigue
            new(0, "Fatigue", "No fatigue today"),
            new(1, "Fatigue", "Fatigue only upon waking up"),
            new(2, "Fatigue", "Fatigue in the morning"),
            new(3, "Fatigue", "Fatigue in the afternoon"),
            new(4, "Fatigue", "Fatigue in the evening"),
            new(5, "Fatigue", "Fatigue all day long"),

            // Hot Flashes
            new(0, "Hot Flashes", "No hot flashes today"),
            new(1, "Hot Flashes", "One hot flash"),
            new(2, "Hot Flashes", "Two or three hot flashes"),
            new(3, "Hot Flashes", "Four hot flashes"),
            new(4, "Hot Flashes", "Five hot flashes"),
            new(5, "Hot Flashes", "Six hot flashes"),
            new(6, "Hot Flashes", "Seven hot flashes"),
            new(7, "Hot Flashes", "Eight hot flashes"),
            new(8, "Hot Flashes", "Ten to fifteen hot flashes"),
            new(9, "Hot Flashes", "More than fifteen hot flashes"),

            // Joint Pain
            new(0, "Joint Pain", "No joint pain today"),
            new(1, "Joint Pain", "Pain in the shoulders"),
            new(2, "Joint Pain", "Pain in the elbows"),
            new(3, "Joint Pain", "Pain in the hips"),
            new(4, "Joint Pain", "Pain in the knees"),
            new(5, "Joint Pain", "Pain in the extremities"),

            // Mood Change
            new(0, "Mood Change", "No mood changes today"),
            new(1, "Mood Change", "Irritability"),
            new(2, "Mood Change", "Sadness"),
            new(3, "Mood Change", "Fury"),
            new(4, "Mood Change", "Anxiety"),
            new(5, "Mood Change", "Euphoria"),
            new(6, "Mood Change", "Apathy"),
            new(7, "Mood Change", "Social withdrawal"),
            new(8, "Mood Change", "Mood swings"),
            new(9, "Mood Change", "Overwhelm"),

            // Night Sweat
            new(0, "Night Sweat", "No night sweats"),
            new(1, "Night Sweat", "One or two night sweats"),
            new(2, "Night Sweat", "Three or more night sweats"),

            // Sleep Disturbance
            new(0, "Sleep Disturbance", "No sleep disturbances"),
            new(1, "Sleep Disturbance", "Difficulty falling asleep"),
            new(2, "Sleep Disturbance", "Night sweats"),
            new(3, "Sleep Disturbance", "Frequent awakening"),
            new(4, "Sleep Disturbance", "Restless legs"),
            new(5, "Sleep Disturbance", "Vivid or disturbing dreams"),
            new(6, "Sleep Disturbance", "Early morning awakening"),
            new(7, "Sleep Disturbance", "Heart palpitations"),
            new(8, "Sleep Disturbance", "Muscle cramps"),
            new(9, "Sleep Disturbance", "Multiple disturbances"),

            // Tinnitus
            new(0, "Tinnitus", "No tinnitus today"),
            new(1, "Tinnitus", "Tinnitus a few times"),
            new(2, "Tinnitus", "Tinnitus all day long"),
        ];

        public static IReadOnlyList<SymptomOption> GetAllSymptoms() => _symptoms;
    }
}
