using Kendez.Niksms.SDK.Dotnet.Core;

namespace Kendez.Niksms.SDK.Dotnet.Core.Example;

/// <summary>
/// Simple example: Send Single SMS
/// </summary>
class SendSingleSms
{
    static async Task Main(string[] args)
    {
        // Configuration
        const string apiKey = "your_api_key_here"; // Replace with your actual API key
        const string senderNumber = "10008663";
        const string recipientNumber = "09123456789";
        const string message = "Hello from NikSms .NET Core SDK!";

        try
        {
            // Create client
            var client = new KendezNiksmsClient(apiKey);

            // Send SMS
            var result = await client.SendSingleAsync(
                senderNumber: senderNumber,
                phone: recipientNumber,
                message: message
            );

            Console.WriteLine("SMS sent successfully!");
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

