using Microsoft.AspNetCore.Mvc;
using TrackHer;
using TrackHerWebApp.Models;
using static TrackHer.MuscleCrampsDisturbance;

public class SymptomsController : Controller
{
    public IActionResult Index()
    {
        var model = new List<SymptomViewModel>
        {
            new SymptomViewModel
            {
                Name = "Night Sweat",
                Values = new List<SymptomLevel>
                {
                    new NoNightSweat(),
                    new OneTwoNightSweats(),
                    new ThreeOrMoreNightSweats()
                }
            },

            new SymptomViewModel
            {
                Name = "Fatigue",
                Values = new List<SymptomLevel>
                {
                    new NoFatigue(),
                    new WakeUpFatigue(),
                    new MorningFatigue(),
                    new AfternoonFatigue(),
                    new EveningFatigue(),
                    new AllDayFatigue(),
                    new WakeUpFatigue(),
                    new WakeUpFatigue(),
                    new WakeUpFatigue(),
                    new WakeUpFatigue(),
                }
            },

            new SymptomViewModel
            {
                Name = "Sleep Disturbance",
                Values = new List<SymptomLevel>
                {
                    new NoSleepDisturbance(),
                    new DifficultyFallingAsleep(),
                    new NightSweatsDisturbance(),
                    new FrequentAwakeningDisturbance(),
                    new RestlessLegDisturbance(),
                    new VividOrDisturbingDreamsDisturbance(),
                    new EarlyMorningAwakeningDisturbance(),
                    new HeartPalpitationsDisturbance(),
                    new MuscleCrampsDisturbance(),
                    new MultipleDisturbance(),
                }
            },

             new SymptomViewModel
            {
                Name = "Libido",
                Values = new List<SymptomLevel>
                {
                    new NoDecreasedLibido(),
                    new FeelingNormalLibido(),
                    new SexyLibido()
                }
            },

             new SymptomViewModel
            {
                Name = "Brain Fog",
                Values = new List<SymptomLevel>
                {
                    new NoBrainFog(),
                    new WakeUpBrainFog(),
                    new MorningBrainFog(),
                    new AfternoonBrainFog(),
                    new EveningBrainFog(),
                    new AllDayBrainFog(),
                }
            },

             new SymptomViewModel
            {
                Name = "Mood change",
                Values = new List<SymptomLevel>
                {
                    new NoMoodChange(),
                    new IrritabilityMoodChange(),
                    new SadnessMoodChange(),
                    new FuryMoodChange(),
                    new AnxietyMoodChange(),
                    new EuphoriaMoodChange(),
                    new ApathyMoodChange(),
                    new SocialWithdrawalMoodChange(),
                    new MoodSwingsMoodChange(),
                    new OverwhelmMoodChange(),
                }
            },

             new SymptomViewModel
            {
                Name = "Tinnitus",
                Values = new List<SymptomLevel>
                {
                    new NoTinnitus(),
                    new FewTimesTinnitus(),
                    new AllDayLongTinnitus()
                }
            },

            new SymptomViewModel
            {
                Name = "Joint Pain",
                Values = new List<SymptomLevel>
                {
                    new NoJointPain(),
                    new ShoulderJointPain(),
                    new ElbowsJointPain(),
                    new HipsJointPain(),
                    new KneesJointPain(),
                    new ExtremitiesJointPain(),
                }
            },

            new SymptomViewModel
            {
                Name = "Hot Flashes",
                Values = new List<SymptomLevel>
                {
                    new NoHotFlashes(),
                    new OneHotFlash(),
                    new TwoOrThreeHotFlashes(),
                    new FourHotFlashes(),
                    new FiveHotFlashes(),
                    new SixHotFlashes(),
                    new SevenHotFlashes(),
                    new EightHotFlashes(),
                    new TenFifteenHotFlashes(),
                    new FifteenMoreHotFlashes(),
                }
            },
        };        

        return View(model);
    }

    [HttpPost] 
    public IActionResult SubmitSymptoms(List<int> selectedSymptomsId)
    {

        var colour = selectedSymptomsId.Aggregate("", (current, s) => current + (s + ""));

        var resultModel = new SubmissionResultViewModel
        {
            ConfirmationMessage = "We've received your symptoms for today",
            Colour = colour,
        };

        // https://www.thecolorapi.com/ /id?rgb=rgb(255,0,0)

        return View("SubmissionConfirmation", resultModel);
    }
}
