# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Commands

```bash
# Build the solution
dotnet build TrackHer.sln

# Run the web app
dotnet run --project TrackHerWebApp/TrackHerWebApp.csproj

# Run the console app (TrackHer library entry point)
dotnet run --project TrackHer/TrackHer.csproj
```

There are no tests yet in this project.

## Architecture

The solution (`TrackHer.sln`) has two projects:

**`TrackHer/`** — a .NET 8 class library (built as an Exe for now) that owns all domain logic:
- `SymptomLevel` — base class for every symptom entry. Holds `Id`, `SymptomGroup`, `Description`, and a `Happened` flag.
- `Symptoms.cs` — concrete subclasses, one per symptom option (e.g. `NoFatigue`, `MorningFatigue`, `AllDayBrainFog`). Each subclass is a distinct severity level within a named group (Night Sweats, Fatigue, Sleep Disturbance, Decreased Libido, Brain Fog, Mood Change, Tinnitus, Joint Pain, Hot Flashes).
- `SymptomRepository.GetAllSymptoms()` — uses reflection to discover and instantiate every non-abstract `SymptomLevel` subclass in the assembly.

**`TrackHerWebApp/`** — an ASP.NET Core 8 MVC web app that references `TrackHer`:
- `Controllers/Home.cs` — serves the Index and Privacy pages.
- `Controllers/Symptoms.cs` — handles `POST /Symptoms/SubmitSymptoms`, receives a list of selected symptom IDs, concatenates them into a "colour" string, and returns `SubmissionConfirmation` view.
- `Models/` — two view models: `SymptomViewModel` (symptom name + list of levels) and `SubmissionResultViewModel` (confirmation message + colour).
- `Views/Home/Index.cshtml` — the main symptom-selection form. The form markup is currently commented out; only a placeholder button is rendered. The intended UI groups `SymptomLevel` instances by `SymptomGroup` and renders checkboxes.

## Key design intent

The app is meant to let a user select daily symptoms, then generate a colour that represents how they felt that day (planned integration with `https://www.thecolorapi.com`). The colour derivation logic in `Symptoms.SubmitSymptoms` is currently a placeholder (concatenation of IDs).

The `SymptomRepository` + reflection pattern means new symptom types can be added by simply creating a new `SymptomLevel` subclass in `Symptoms.cs` — no registration needed.
