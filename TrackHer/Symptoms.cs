

namespace TrackHer
{
    // Night Sweats
    public class NoNightSweat : SymptomLevel
    {
        public NoNightSweat() : base(0, "Night Sweat", "No night sweats tonight!") { }
    }

    public class OneTwoNightSweats : SymptomLevel
    {
        public OneTwoNightSweats() : base(1, "Night Sweat", "One or two night sweats throughout the night") { }
    }

    public class ThreeOrMoreNightSweats : SymptomLevel
    {
        public ThreeOrMoreNightSweats() : base(2, "Night Sweat", "Three or more night sweats throughout the night") { }
    }

    // Fatigue
    public class NoFatigue : SymptomLevel
    {
        public NoFatigue() : base(0, "Fatigue", "Did not feel fatigued at all") { }
    }
    public class WakeUpFatigue : SymptomLevel
    {
        public WakeUpFatigue() : base(1, "Fatigue", "Felt fatigued waking up only") { }
    }
    public class MorningFatigue : SymptomLevel
    {
        public MorningFatigue() : base(2, "Fatigue", "Felt fatigued in the morning") { }
    }
    public class AfternoonFatigue : SymptomLevel
    {
        public AfternoonFatigue() : base(3, "Fatigue", "Felt fatigued in the afternoon") { }
    }
    public class EveningFatigue : SymptomLevel
    {
        public EveningFatigue() : base(4, "Fatigue", "Felt fatigued in the evening") { }
    }
    public class AllDayFatigue : SymptomLevel
    {
        public AllDayFatigue() : base(5, "Fatigue", "Felt fatigued all day long") { }
    }

    // Sleep Disturbance
    public class NoSleepDisturbance : SymptomLevel
    {
        public NoSleepDisturbance() : base(0, "Sleep Disturbance", "No sleep disturbances") { }
    }

    public class DifficultyFallingAsleep : SymptomLevel
    {
        public DifficultyFallingAsleep() : base(1, "Sleep Disturbance", "Difficulty falling asleep") { }
    }

    public class NightSweatsDisturbance : SymptomLevel
    {
        public NightSweatsDisturbance() : base(2, "Sleep Disturbance", "Experienced night sweats") { }
    }
    public class FrequentAwakeningDisturbance : SymptomLevel
    {
        public FrequentAwakeningDisturbance() : base(3, "Sleep Disturbance", "Experienced FrequentAwakening") { }
    }
    public class RestlessLegDisturbance : SymptomLevel
    {
        public RestlessLegDisturbance() : base(4, "Sleep Disturbance", "Experienced RestlessLeg") { }
    }
    public class VividOrDisturbingDreamsDisturbance : SymptomLevel
    {
        public VividOrDisturbingDreamsDisturbance() : base(5, "Sleep Disturbance", "Experienced VividOrDisturbingDreams") { }
    }
    public class EarlyMorningAwakeningDisturbance : SymptomLevel
    {
        public EarlyMorningAwakeningDisturbance() : base(6, "Sleep Disturbance", "Experienced EarlyMorningAwakening") { }
    }
    public class HeartPalpitationsDisturbance : SymptomLevel
    {
        public HeartPalpitationsDisturbance() : base(7, "Sleep Disturbance", "Experienced HeartPalpitations") { }
    }
    public class MuscleCrampsDisturbance : SymptomLevel
    {
        public MuscleCrampsDisturbance() : base(8, "Sleep Disturbance", "Experienced MuscleCramps") { }
        public class MultipleDisturbance : SymptomLevel
        {
            public MultipleDisturbance() : base(9, "Sleep Disturbance", "Experienced lots of symtoms at once") { }
        }
    }

    // Libido
    public class NoDecreasedLibido : SymptomLevel
    {
        public NoDecreasedLibido() : base(0, "Decreased Libido", "Did not experience decreased libido") { }
    }

    public class FeelingNormalLibido : SymptomLevel
    {
        public FeelingNormalLibido() : base(1, "Decreased Libido", "Feeling normal") { }
    }

    public class SexyLibido : SymptomLevel
    {
        public SexyLibido() : base(2, "Decreased Libido", "Feeling quite the opposite") { }
    }

    // Brain Fog
    public class NoBrainFog : SymptomLevel
    {
        public NoBrainFog() : base(0, "Brain Fog", "No brain fog today") { }
    }

    public class WakeUpBrainFog : SymptomLevel
    {
        public WakeUpBrainFog() : base(1, "Brain Fog", "Experienced brain fog upon waking up") { }
    }
    public class MorningBrainFog : SymptomLevel
    {
        public MorningBrainFog() : base(2, "Brain Fog", "Experienced brain fog upon Morning") { }
    }
    public class AfternoonBrainFog : SymptomLevel
    {
        public AfternoonBrainFog() : base(3, "Brain Fog", "Experienced brain fog Afternoon") { }
    }
    public class EveningBrainFog : SymptomLevel
    {
        public EveningBrainFog() : base(4, "Brain Fog", "Experienced brain fog Evening") { }
    }
    public class AllDayBrainFog : SymptomLevel
    {
        public AllDayBrainFog() : base(5, "Brain Fog", "Experienced brain fog AllDayLong") { }
    }

    // Mood change
    public class NoMoodChange : SymptomLevel
    {
        public NoMoodChange() : base(0, "Mood Change", "No mood changes today") { }
    }

    public class IrritabilityMoodChange : SymptomLevel
    {
        public IrritabilityMoodChange() : base(1, "Mood Change", "Experienced irritability") { }
    }
    public class SadnessMoodChange : SymptomLevel
    {
        public SadnessMoodChange() : base(2, "Mood Change", "Experienced Sadness") { }
    }
    public class FuryMoodChange : SymptomLevel
    {
        public FuryMoodChange() : base(3, "Mood Change", "Experienced Fury") { }
    }
    public class AnxietyMoodChange : SymptomLevel
    {
        public AnxietyMoodChange() : base(4, "Mood Change", "Experienced Anxiety") { }
    }
    public class EuphoriaMoodChange : SymptomLevel
    {
        public EuphoriaMoodChange() : base(5, "Mood Change", "Experienced Euphoria") { }
    }
    public class ApathyMoodChange : SymptomLevel
    {
        public ApathyMoodChange() : base(6, "Mood Change", "Experienced Apathy") { }
    }
    public class SocialWithdrawalMoodChange : SymptomLevel
    {
        public SocialWithdrawalMoodChange() : base(7, "Mood Change", "Experienced SocialWithdrawal") { }
    }
    public class MoodSwingsMoodChange : SymptomLevel
    {
        public MoodSwingsMoodChange() : base(8, "Mood Change", "Experienced MoodSwings") { }
    }
    public class OverwhelmMoodChange : SymptomLevel
    {
        public OverwhelmMoodChange() : base(9, "Mood Change", "Experienced Overwhelm") { }
    }

    // Tinnitus
    public class NoTinnitus : SymptomLevel
    {
        public NoTinnitus() : base(0, "Tinnitus", "No tinnitus today") { }
    }

    public class FewTimesTinnitus : SymptomLevel
    {
        public FewTimesTinnitus() : base(1, "Tinnitus", "Experienced tinnitus a few times") { }
    }

    public class AllDayLongTinnitus : SymptomLevel
    {
        public AllDayLongTinnitus() : base(2, "Tinnitus", "Experienced tinnitus all day long") { }
    }

    // Physical pain
    public class NoJointPain : SymptomLevel
    {
        public NoJointPain() : base(0, "Joint Pain", "No joint pain today") { }
    }

    public class ShoulderJointPain : SymptomLevel
    {
        public ShoulderJointPain() : base(1, "Joint Pain", "Pain in the shoulders") { }
    }
    public class ElbowsJointPain : SymptomLevel
    {
        public ElbowsJointPain() : base(2, "Joint Pain", "Pain in the shoulders") { }
    }
    public class HipsJointPain : SymptomLevel
    {
        public HipsJointPain() : base(3, "Joint Pain", "Pain in the Hips") { }
    }
    public class KneesJointPain : SymptomLevel
    {
        public KneesJointPain() : base(4, "Joint Pain", "Pain in the Knees") { }
    }
    public class ExtremitiesJointPain : SymptomLevel
    {
        public ExtremitiesJointPain() : base(5, "Joint Pain", "Pain in the Extremities") { }
    }

    // Hot Flashes
    public class NoHotFlashes : SymptomLevel
    {
        public NoHotFlashes() : base(0, "Hot Flashes", "No hot flashes today") { }
    }

    public class OneHotFlash : SymptomLevel
    {
        public OneHotFlash() : base(1, "Hot Flashes", "One hot flash today") { }
    }

    public class TwoOrThreeHotFlashes : SymptomLevel
    {
        public TwoOrThreeHotFlashes() : base(2, "Hot Flashes", "Two or three hot flashes today") { }
    }
    public class FourHotFlashes : SymptomLevel
    {
        public FourHotFlashes() : base(3, "Hot Flashes", "Four hot flashes today") { }
    }
    public class FiveHotFlashes : SymptomLevel
    {
        public FiveHotFlashes() : base(4, "Hot Flashes", "Five hot flashes today") { }
    }
    public class SixHotFlashes : SymptomLevel
    {
        public SixHotFlashes() : base(5, "Hot Flashes", "Six hot flashes today") { }
    }
    public class SevenHotFlashes : SymptomLevel
    {
        public SevenHotFlashes() : base(6, "Hot Flashes", "Seven hot flashes today") { }
    }
    public class EightHotFlashes : SymptomLevel
    {
        public EightHotFlashes() : base(7, "Hot Flashes", "Eight hot flashes today") { }
    }
    public class TenFifteenHotFlashes : SymptomLevel
    {
        public TenFifteenHotFlashes() : base(8, "Hot Flashes", "TenFifteen hot flashes today") { }
    }
    public class FifteenMoreHotFlashes : SymptomLevel
    {
        public FifteenMoreHotFlashes() : base(9, "Hot Flashes", "FifteenMore hot flashes today") { }
    }
}
