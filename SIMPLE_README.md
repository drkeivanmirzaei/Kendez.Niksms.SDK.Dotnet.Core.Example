# Kendez.NikSms .NET Core SDK - Simple Examples

Simple examples for using the NikSms .NET Core SDK

## Installation

```bash
dotnet add package Kendez.Niksms.SDK
```

Or in Package Manager Console:

```powershell
Install-Package Kendez.Niksms.SDK
```

## Configuration

Before running examples, replace your API Key in the files:

```csharp
const string apiKey = "your_actual_api_key_here";
```

## Simple Examples

### 1. Send Single SMS
```bash
dotnet run --project SendSingleSms.cs
```

### 2. Send Group SMS
```bash
dotnet run --project SendGroupSms.cs
```

### 3. Send OTP
```bash
dotnet run --project SendOtp.cs
```

### 4. Send PTP SMS
```bash
dotnet run --project SendPtpSms.cs
```

### 5. Get Balance
```bash
dotnet run --project GetBalance.cs
```

### 6. Get Panel Expire Date
```bash
dotnet run --project GetPanelExpireDate.cs
```

### 7. Check SMS Status
```bash
dotnet run --project CheckStatus.cs
```

### 8. All Examples
```bash
dotnet run --project SimpleExamples.cs
```

## Simple Code

```csharp
using Kendez.Niksms.SDK.Dotnet.Core;

// Create client
var client = new KendezNiksmsClient("your_api_key");

// Send SMS
var result = await client.SendSingleAsync(
    senderNumber: "10008663",
    phone: "09123456789",
    message: "Hello!"
);

Console.WriteLine(result);
```

## Key Differences from .NET SDK

- **Recipients**: Uses tuples instead of custom classes
- **Cross-platform**: Runs on all platforms
- **Modern**: Uses modern .NET features

## Get API Key

1. Go to [webservice.niksms.com](https://webservice.niksms.com)
2. Register
3. Get your API Key from user panel

