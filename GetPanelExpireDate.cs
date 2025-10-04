using Kendez.Niksms.SDK.Dotnet.Core;

namespace Kendez.Niksms.SDK.Dotnet.Core.Example;

/// <summary>
/// Simple example: Get Panel Expire Date
/// </summary>
class GetPanelExpireDate
{
    static async Task Main(string[] args)
    {
        // Configuration
        const string apiKey = "your_api_key_here"; // Replace with your actual API key

        try
        {
            // Create client
            var client = new KendezNiksmsClient(apiKey);

            // Get panel expire date
            var result = await client.GetPanelExpireDateAsync();

            Console.WriteLine("Panel Expire Date:");
            Console.WriteLine($"Result: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            Console.WriteLine("\nMake sure to:");
            Console.WriteLine("1. Replace 'your_api_key_here' with your actual API key");
            Console.WriteLine("2. Check your internet connection");
            Console.WriteLine("3. Verify your API key is correct");
        }
    }
}

