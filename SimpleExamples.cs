using Kendez.Niksms.SDK.Dotnet.Core;

namespace Kendez.Niksms.SDK.Dotnet.Core.Example;

/// <summary>
/// Simple Examples for Kendez.NikSms .NET Core SDK
/// This file contains simple examples for each SDK method
/// </summary>
class SimpleExamples
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Kendez.NikSms .NET Core SDK - Simple Examples");
        Console.WriteLine("=" + new string('=', 50));

        // Configuration
        const string apiKey = "your_api_key_here"; // Replace with your actual API key
        const string senderNumber = "10008663";
        const string recipientNumber = "09123456789";

        try
        {
            // Create client
            var client = new KendezNiksmsClient(apiKey);

            // 1. Send single SMS
            Console.WriteLine("\n1. Send Single SMS:");
            var singleResult = await client.SendSingleAsync(
                senderNumber: senderNumber,
                phone: recipientNumber,
                message: "Hello from NikSms .NET Core SDK!"
            );
            Console.WriteLine($"Result: {singleResult}");

            // 2. Send group SMS
            Console.WriteLine("\n2. Send Group SMS:");
            var recipients = new[]
            {
                ("09123456789", "msg1"),
                ("09987654321", "msg2")
            };
            var groupResult = await client.SendGroupAsync(
                senderNumber: senderNumber,
                message: "Group message",
                recipients: recipients
            );
            Console.WriteLine($"Result: {groupResult}");

            // 3. Send OTP
            Console.WriteLine("\n3. Send OTP:");
            var otpResult = await client.SendOtpAsync(
                senderNumber: senderNumber,
                phone: recipientNumber,
                message: "Your OTP code is: 123456"
            );
            Console.WriteLine($"Result: {otpResult}");

            // 4. Send PTP SMS
            Console.WriteLine("\n4. Send PTP SMS:");
            var ptpRecipients = new[]
            {
                ("09123456789", "Hello Ali!", "ptp1"),
                ("09987654321", "Hello Reza!", "ptp2")
            };
            var ptpResult = await client.SendPtpAsync(
                senderNumber: senderNumber,
                recipients: ptpRecipients
            );
            Console.WriteLine($"Result: {ptpResult}");

            // 5. Get credit/balance
            Console.WriteLine("\n5. Get Balance:");
            var creditResult = await client.GetCreditAsync();
            Console.WriteLine($"Balance: {creditResult}");

            // 6. Get panel expire date
            Console.WriteLine("\n6. Get Panel Expire Date:");
            var expireResult = await client.GetPanelExpireDateAsync();
            Console.WriteLine($"Expire Date: {expireResult}");

            // 7. Check SMS status
            Console.WriteLine("\n7. Check SMS Status:");
            var messageIds = new[] { "12345", "67890" }; // Replace with actual message IDs
            var statusResult = await client.SmsStatusAsync(messageIds);
            Console.WriteLine($"Status: {statusResult}");

            Console.WriteLine("\n" + new string('=', 52));
            Console.WriteLine("Examples completed!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nError: {ex.Message}");
            Console.WriteLine("\nMake sure to:");
            Console.WriteLine("1. Replace 'your_api_key_here' with your actual API key");
            Console.WriteLine("2. Check your internet connection");
            Console.WriteLine("3. Verify your API key is correct");
        }

        Console.WriteLine("\nNote: Replace 'your_api_key_here' with your actual API key");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

