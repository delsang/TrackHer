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

        public Symptoms(IColourCalculator colourCalculator, IColourApiClient colourApiClient)
        {
            _colourCalculator = colourCalculator;
            _colourApiClient = colourApiClient;
        }

        [HttpPost]
        public async Task<IActionResult> SubmitSymptoms()
        {
            var selectionsByGroup = SymptomRepository.GetAllSymptoms()
                .GroupBy(s => s.SymptomGroup)
                .OrderBy(g => g.Key)
                .ToDictionary(
                    g => g.Key,
                    g => int.TryParse(Request.Form[g.Key], out var n) ? n : 0);

            var (red, green, blue) = _colourCalculator.Calculate(selectionsByGroup);
            var colour = await _colourApiClient.GetColourAsync(red, green, blue);

            var resultModel = new SubmissionResultViewModel
            {
                ConfirmationMessage = "Thank you! Today's colour is...",
                Colour = colour.Name,
                HexColour = colour.Hex,
            };

            return View("SubmissionConfirmation", resultModel);
        }
    }
}
