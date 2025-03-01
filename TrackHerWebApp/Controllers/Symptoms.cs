using Microsoft.AspNetCore.Mvc;
using TrackHerWebApp.Models;

namespace TrackHerWebApp.Controllers
{
    public class Symptoms : Controller
    {
        [HttpPost]
        public IActionResult SubmitSymptoms(List<int> selectedSymptomsId)
        {
            Console.WriteLine($"Symptoms Received: {string.Join(",", selectedSymptomsId)}");

            if (selectedSymptomsId == null || !selectedSymptomsId.Any())
            {
                return View("Error");
            }

            var colour = selectedSymptomsId.Aggregate("", (current, s) => current + (s + ""));

            var resultModel = new SubmissionResultViewModel
            {
                ConfirmationMessage = "Thank you! Today's colour is...",
                Colour = colour,
            };

            return View("SubmissionConfirmation", resultModel);

            // https://www.thecolorapi.com/ /id?rgb=rgb(255,0,0)

        }
    }
}
