using Kendez.Niksms.SDK.Dotnet.Core;

namespace Kendez.Niksms.SDK.Dotnet.Core.Example;

/// <summary>
/// Simple example: Send Group SMS
/// </summary>
class SendGroupSms
{
    static async Task Main(string[] args)
    {
        // Configuration
        const string apiKey = "your_api_key_here"; // Replace with your actual API key
        const string senderNumber = "10008663";
        const string message = "Group message from NikSms .NET Core SDK";

        try
        {
            // Create client
            var client = new KendezNiksmsClient(apiKey);

            // Prepare recipients (using tuples for .NET Core version)
            var recipients = new[]
            {
                ("09123456789", "msg1"),
                ("09987654321", "msg2")
            };

            // Send group SMS
            var result = await client.SendGroupAsync(
                senderNumber: senderNumber,
                message: message,
                recipients: recipients
            );

            Console.WriteLine("Group SMS sent successfully!");
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

