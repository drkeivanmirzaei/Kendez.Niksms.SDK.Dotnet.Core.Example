using Kendez.Niksms.SDK.Dotnet.Core;

namespace Kendez.Niksms.SDK.Dotnet.Core.Example;

/// <summary>
/// Simple example: Get Account Balance
/// </summary>
class GetBalance
{
    static async Task Main(string[] args)
    {
        // Configuration
        const string apiKey = "your_api_key_here"; // Replace with your actual API key

        try
        {
            // Create client
            var client = new KendezNiksmsClient(apiKey);

            // Get balance
            var result = await client.GetCreditAsync();

            Console.WriteLine("Account Balance:");
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

