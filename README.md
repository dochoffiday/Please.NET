Please.NET
===============

An ASP.NET library for GETTING THINGS DONE.

Usage
---------------

```csharp
Please.Do(() =>
{
    // for code that you want to get done

    String temp = "HELLO. I AM CODE.";
});

Please.Dont(() =>
{
    // for code that you don't what to get done

    String temp = "HELLO. I AM CODE.";
});

Please.WeatherPermitting(() =>
{
    // for code that you may or may not want to get done

    String temp = "HELLO. I AM CODE.";
});

Please.PrettyPlease(() =>
{
    // for code that you DESPERATELY want to get done

    String temp = "HELLO. I AM CODE.";
}, true);

Please.Repeat(1000, i =>
{
    // for code that you want to get done many, many, times

    String temp = "HELLO. I AM CODE.";
});

```