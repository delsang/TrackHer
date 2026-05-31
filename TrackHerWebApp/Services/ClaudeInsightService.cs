using Anthropic;
using Anthropic.Models.Messages;
using Microsoft.Extensions.Configuration;
using System.Text.Json;

namespace TrackHerWebApp.Services
{
    public class ClaudeInsightService : ILlmInsightService
    {
        private readonly AnthropicClient _client;

        public ClaudeInsightService(IConfiguration configuration)
        {
            _client = new AnthropicClient { ApiKey = configuration["ANTHROPIC_API_KEY"] };
        }

        public async Task<LlmInsight> GetInsightAsync(
            string colourName,
            string hexColour,
            IReadOnlyDictionary<string, string> selectedSymptoms)
        {
            var symptomLines = selectedSymptoms.Any()
                ? string.Join("\n", selectedSymptoms.Select(kvp => $"- {kvp.Key}: {kvp.Value}"))
                : "No notable symptoms today.";

            var prompt = $$"""
                A person is tracking their menopause symptoms. Today their daily colour is {{colourName}} ({{hexColour}}).

                Symptoms logged today:
                {{symptomLines}}

                Respond with exactly this JSON structure and nothing else:
                {
                  "supportiveMessage": "2-3 warm empathetic sentences acknowledging how they feel today",
                  "alleviationSuggestions": "2-4 sentences with gentle practical tips for their specific symptoms"
                }
                """;

            var response = await _client.Messages.Create(new MessageCreateParams
            {
                Model = "claude-opus-4-7",
                MaxTokens = 1024,
                System = "You are a compassionate companion for people going through menopause. You respond with warmth, understanding, and practical care. Never be dismissive or clinical. Always respond with valid JSON only.",
                Messages = [new() { Role = Role.User, Content = prompt }]
            });

            var text = response.Content
                .Select(b => b.Value)
                .OfType<TextBlock>()
                .FirstOrDefault()?.Text ?? "{}";

            using var doc = JsonDocument.Parse(text);
            var root = doc.RootElement;

            return new LlmInsight(
                SupportiveMessage: root.GetProperty("supportiveMessage").GetString() ?? "",
                AlleviationSuggestions: root.GetProperty("alleviationSuggestions").GetString() ?? "");
        }
    }
}
