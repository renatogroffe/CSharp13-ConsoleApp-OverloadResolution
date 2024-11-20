namespace ConsoleAppOverloadResolution.Tests;

public static class OverloadResolutionTester
{
    public static void PrintItems(params string[] items)
       => Console.WriteLine($"{nameof(OverloadResolutionTester)} - " +
           $"string[]: [ {String.Join(" | ", items)} ]");

    public static void PrintItems(params ReadOnlySpan<string?> items)
       => Console.WriteLine($"{nameof(OverloadResolutionTester)} - " +
           $"ReadOnlySpan<string?>: [ {String.Join(" | ", items)} ]");

    public static void PrintItems(params IEnumerable<string> items)
       => Console.WriteLine($"{nameof(OverloadResolutionTester)} - " +
           $"IEnumerable<string>: [ {String.Join(" | ", items)} ]");
}