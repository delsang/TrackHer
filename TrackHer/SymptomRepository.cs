using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace TrackHer
{
    public static class SymptomRepository
    {
        public static List<SymptomLevel> GetAllSymptoms()
        {
            // Get all classes in the current assembly that inherit from SymptomLevel
            var symptomTypes = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof(SymptomLevel)));

            // Instantiate them using their parameterless constructor
            var symptoms = symptomTypes
                .Select(t => Activator.CreateInstance(t) as SymptomLevel)
                .ToList();

            return symptoms;
        }
    }
}
