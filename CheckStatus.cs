using Kendez.Niksms.SDK.Dotnet.Core;

namespace Kendez.Niksms.SDK.Dotnet.Core.Example;

/// <summary>
/// Simple example: Check SMS Status
/// </summary>
class CheckStatus
{
    static async Task Main(string[] args)
    {
        // Configuration
        const string apiKey = "your_api_key_here"; // Replace with your actual API key
        var messageIds = new[] { "12345", "67890" }; // Replace with actual message IDs

        try
        {
            // Create client
            var client = new KendezNiksmsClient(apiKey);

            // Check status
            var result = await client.SmsStatusAsync(messageIds);

            Console.WriteLine("SMS Status:");
            Console.WriteLine($"Result: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            Console.WriteLine("\nMake sure to:");
            Console.WriteLine("1. Replace 'your_api_key_here' with your actual API key");
            Console.WriteLine("2. Replace message IDs with actual message IDs");
            Console.WriteLine("3. Check your internet connection");
            Console.WriteLine("4. Verify your API key is correct");
        }
    }
}

