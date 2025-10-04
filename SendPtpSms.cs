using Kendez.Niksms.SDK.Dotnet.Core;

namespace Kendez.Niksms.SDK.Dotnet.Core.Example;

/// <summary>
/// Simple example: Send PTP (Point to Point) SMS
/// </summary>
class SendPtpSms
{
    static async Task Main(string[] args)
    {
        // Configuration
        const string apiKey = "your_api_key_here"; // Replace with your actual API key
        const string senderNumber = "10008663";

        try
        {
            // Create client
            var client = new KendezNiksmsClient(apiKey);

            // Prepare PTP recipients (each person gets a different message)
            var recipients = new[]
            {
                ("09123456789", "Hello Ali!", "ptp1"),
                ("09987654321", "Hello Reza!", "ptp2")
            };

            // Send PTP SMS
            var result = await client.SendPtpAsync(
                senderNumber: senderNumber,
                recipients: recipients
            );

            Console.WriteLine("PTP SMS sent successfully!");
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

