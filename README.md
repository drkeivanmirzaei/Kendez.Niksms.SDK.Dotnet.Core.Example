# راهنمای سریع - NikSms .NET Core SDK

## 📦 نصب

```bash
dotnet add package Kendez.Niksms.SDK
```

یا در Package Manager Console:

```powershell
Install-Package Kendez.Niksms.SDK
```

## 🔑 دریافت API Key

1. به [webservice.niksms.com](https://webservice.niksms.com) بروید
2. ثبت‌نام کنید
3. API Key خود را از پنل کاربری دریافت کنید

## 🚀 نمونه‌های ساده

### 1. ارسال SMS ساده

```csharp
using Kendez.Niksms.SDK.Dotnet.Core;

// ایجاد کلاینت
var client = new KendezNiksmsClient("your_api_key");

// ارسال SMS
var result = await client.SendSingleAsync(
    senderNumber: "10008663",
    phone: "09123456789",
    message: "سلام! این یک پیام تست است."
);

Console.WriteLine(result);
```

### 2. ارسال SMS گروهی

```csharp
using Kendez.Niksms.SDK.Dotnet.Core;

var client = new KendezNiksmsClient("your_api_key");

// آماده‌سازی لیست گیرندگان (با tuples)
var recipients = new[]
{
    ("09123456789", "msg1"),
    ("09987654321", "msg2")
};

// ارسال گروهی
var result = await client.SendGroupAsync(
    senderNumber: "10008663",
    message: "پیام گروهی",
    recipients: recipients
);

Console.WriteLine(result);
```

### 3. ارسال OTP

```csharp
using Kendez.Niksms.SDK.Dotnet.Core;

var client = new KendezNiksmsClient("your_api_key");

var result = await client.SendOtpAsync(
    senderNumber: "10008663",
    phone: "09123456789",
    message: "کد تایید شما: 123456"
);

Console.WriteLine(result);
```

### 4. ارسال PTP (هر نفر پیام متفاوت)

```csharp
using Kendez.Niksms.SDK.Dotnet.Core;

var client = new KendezNiksmsClient("your_api_key");

// آماده‌سازی گیرندگان PTP (با tuples)
var recipients = new[]
{
    ("09123456789", "سلام علی!", "ptp1"),
    ("09987654321", "سلام رضا!", "ptp2")
};

var result = await client.SendPtpAsync(
    senderNumber: "10008663",
    recipients: recipients
);

Console.WriteLine(result);
```

### 5. دریافت موجودی

```csharp
using Kendez.Niksms.SDK.Dotnet.Core;

var client = new KendezNiksmsClient("your_api_key");

var balance = await client.GetCreditAsync();
Console.WriteLine($"موجودی شما: {balance}");
```

### 6. دریافت تاریخ انقضای پنل

```csharp
using Kendez.Niksms.SDK.Dotnet.Core;

var client = new KendezNiksmsClient("your_api_key");

var expireDate = await client.GetPanelExpireDateAsync();
Console.WriteLine($"تاریخ انقضا: {expireDate}");
```

### 7. بررسی وضعیت SMS

```csharp
using Kendez.Niksms.SDK.Dotnet.Core;

var client = new KendezNiksmsClient("your_api_key");

// بررسی وضعیت پیام‌ها
var messageIds = new[] { "12345", "67890" };
var status = await client.SmsStatusAsync(messageIds);
Console.WriteLine(status);
```

## 📁 فایل‌های نمونه

- `SendSingleSms.cs` - ارسال SMS ساده
- `SendGroupSms.cs` - ارسال SMS گروهی
- `SendOtp.cs` - ارسال OTP
- `SendPtpSms.cs` - ارسال PTP SMS
- `GetBalance.cs` - دریافت موجودی
- `GetPanelExpireDate.cs` - دریافت تاریخ انقضا
- `CheckStatus.cs` - بررسی وضعیت
- `SimpleExamples.cs` - همه نمونه‌ها در یک فایل

## 🏃‍♂️ اجرای نمونه‌ها

```bash
# ارسال SMS ساده
dotnet run --project SendSingleSms.cs

# ارسال SMS گروهی
dotnet run --project SendGroupSms.cs

# ارسال OTP
dotnet run --project SendOtp.cs

# همه نمونه‌ها
dotnet run --project SimpleExamples.cs
```

## ⚠️ نکات مهم

1. **API Key را جایگزین کنید**: `"your_api_key"` را با API Key واقعی خود جایگزین کنید
2. **شماره فرستنده**: از شماره‌های معتبر استفاده کنید
3. **شماره گیرنده**: شماره موبایل گیرنده باید معتبر باشد
4. **پیام**: متن پیام را به فارسی یا انگلیسی بنویسید
5. **async/await**: همه متدها async هستند
6. **Tuples**: در .NET Core از tuples برای recipients استفاده می‌شود

## 🔧 مدیریت خطا

```csharp
try
{
    var result = await client.SendSingleAsync(
        senderNumber: "10008663",
        phone: "09123456789",
        message: "تست"
    );
    Console.WriteLine("موفق:", result);
}
catch (Exception ex)
{
    Console.WriteLine("خطا:", ex.Message);
}
```

## 🔄 تفاوت با .NET SDK

- **Recipients**: در .NET Core از tuples استفاده می‌شود به جای کلاس‌های مخصوص
- **Cross-platform**: .NET Core روی همه پلتفرم‌ها اجرا می‌شود
- **Modern**: از ویژگی‌های مدرن .NET استفاده می‌کند

## 📞 پشتیبانی

- وب‌سایت: [webservice.niksms.com](https://webservice.niksms.com)
- NuGet: [Kendez.Niksms.SDK](https://www.nuget.org/packages/Kendez.Niksms.SDK/)
- مستندات: [docs.webservice.niksms.com](https://docs.webservice.niksms.com)

