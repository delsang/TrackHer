using Microsoft.AspNetCore.Mvc;
using TrackHer;
using TrackHerWebApp.Models;
using TrackHerWebApp.Services;

namespace TrackHerWebApp.Controllers
{
    public class Symptoms : Controller
    {
        private readonly IColourCalculator _colourCalculator;
        private readonly IColourApiClient _colourApiClient;
        private readonly ILlmInsightService _llmInsightService;

        public Symptoms(IColourCalculator colourCalculator, IColourApiClient colourApiClient, ILlmInsightService llmInsightService)
        {
            _colourCalculator = colourCalculator;
            _colourApiClient = colourApiClient;
            _llmInsightService = llmInsightService;
        }

        [HttpPost]
        public async Task<IActionResult> SubmitSymptoms()
        {
            var allSymptoms = SymptomRepository.GetAllSymptoms();

            var selectionsByGroup = allSymptoms
                .GroupBy(s => s.SymptomGroup)
                .OrderBy(g => g.Key)
                .ToDictionary(
                    g => g.Key,
                    g => int.TryParse(Request.Form[g.Key], out var n) ? n : 0);

            var (red, green, blue) = _colourCalculator.Calculate(selectionsByGroup);
            var colour = await _colourApiClient.GetColourAsync(red, green, blue);

            var selectedDescriptions = selectionsByGroup
                .Where(kvp => kvp.Value > 0)
                .ToDictionary(
                    kvp => kvp.Key,
                    kvp => allSymptoms.FirstOrDefault(s => s.SymptomGroup == kvp.Key && s.Id == kvp.Value)?.Description ?? "");

            var insight = await _llmInsightService.GetInsightAsync(colour.Name, colour.Hex, selectedDescriptions);

            var resultModel = new SubmissionResultViewModel
            {
                ConfirmationMessage = "Thank you! Today's colour is...",
                Colour = colour.Name,
                HexColour = colour.Hex,
                Insight = insight,
            };

            return View("SubmissionConfirmation", resultModel);
        }
    }
}
