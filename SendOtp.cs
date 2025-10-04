using Kendez.Niksms.SDK.Dotnet.Core;

namespace Kendez.Niksms.SDK.Dotnet.Core.Example;

/// <summary>
/// Simple example: Send OTP SMS
/// </summary>
class SendOtp
{
    static async Task Main(string[] args)
    {
        // Configuration
        const string apiKey = "your_api_key_here"; // Replace with your actual API key
        const string senderNumber = "10008663";
        const string recipientNumber = "09123456789";
        const string otpCode = "123456";

        try
        {
            // Create client
            var client = new KendezNiksmsClient(apiKey);

            // Send OTP
            var result = await client.SendOtpAsync(
                senderNumber: senderNumber,
                phone: recipientNumber,
                message: $"Your OTP code is: {otpCode}"
            );

            Console.WriteLine("OTP sent successfully!");
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

