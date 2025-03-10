---

# Persian Identity Error Describer in .Net 9

This repository contains a custom implementation of `IdentityErrorDescriber` for ASP.NET Core Identity that translates default error messages into Persian. This project can be integrated into your ASP.NET Core applications to provide Persian language error messages.

## Usage (English)

1. **Add the Class**  
   Include the `PersianIdentityErrorDescriber` class in your project.

2. **Configure Identity**  
   In your `Startup.cs` (or `Program.cs` for .NET 6+), configure Identity to use the Persian error describer by adding it to the Identity builder:
   ```csharp
   services.AddIdentity<IdentityUser, IdentityRole>(options =>
   {
       // Configure your Identity options here.
   })
   .AddErrorDescriber<PersianIdentityErrorDescriber>()
   .AddEntityFrameworkStores<ApplicationDbContext>()
   .AddDefaultTokenProviders();
   ```
   
3. **Run Your Application**  
   Build and run your application. Identity errors will now be displayed in Persian.

4. **Contributions**  
   Contributions and suggestions are welcome. Feel free to open issues or submit pull requests.

---

# توصیف کننده خطای هویت به فارسی

این مخزن شامل پیاده‌سازی سفارشی `IdentityErrorDescriber` برای ASP.NET Core Identity است که پیام‌های خطای پیش‌فرض را به فارسی ترجمه می‌کند. با استفاده از این پروژه می‌توانید پیام‌های خطای سیستم هویت را در برنامه‌های ASP.NET Core به زبان فارسی نمایش دهید.

## نحوه استفاده (فارسی)

1. **افزودن کلاس**  
   کلاس `PersianIdentityErrorDescriber` را به پروژه‌ی خود اضافه کنید.

2. **تنظیم Identity**  
   در فایل `Startup.cs` (یا `Program.cs` در نسخه‌های .NET 6 به بالا)، تنظیمات Identity را به صورت زیر پیکربندی کنید:
   ```csharp
   services.AddIdentity<IdentityUser, IdentityRole>(options =>
   {
       // پیکربندی گزینه‌های Identity در اینجا
   })
   .AddErrorDescriber<PersianIdentityErrorDescriber>()
   .AddEntityFrameworkStores<ApplicationDbContext>()
   .AddDefaultTokenProviders();
   ```
   
3. **اجرای برنامه**  
   برنامه خود را بیلد و اجرا کنید. از این پس، پیام‌های خطای Identity به زبان فارسی نمایش داده خواهند شد.

4. **مشارکت**  
   هر گونه پیشنهاد و یا بهبود پروژه خوش‌آمد است. در صورت نیاز به گزارش مشکل یا ارسال درخواست‌های تغییر (pull request)، می‌توانید اقدام کنید.

---

## License

This project is open source and available under the [MIT License](LICENSE).

---

Feel free to modify this README file to best suit your project’s needs.
