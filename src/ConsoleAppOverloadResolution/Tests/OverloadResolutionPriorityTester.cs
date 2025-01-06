using System.Runtime.CompilerServices;

namespace ConsoleAppOverloadResolution.Tests;

public class OverloadResolutionPriorityTester
{
    [OverloadResolutionPriority(1)]
    public static void PrintItems(params string[] items)
       => Console.WriteLine($"{nameof(OverloadResolutionPriorityTester)} - " +
           $"string[]: [ {String.Join(" | ", items)} ]");

    [OverloadResolutionPriority(2)]
    public static void PrintItems(params ReadOnlySpan<string?> items)
       => Console.WriteLine($"{nameof(OverloadResolutionPriorityTester)} - " +
           $"ReadOnlySpan<string?>: [ {String.Join(" | ", items)} ]");

    [OverloadResolutionPriority(3)]
    public static void PrintItems(params IEnumerable<string> items)
       => Console.WriteLine($"{nameof(OverloadResolutionPriorityTester)} - " +
           $"IEnumerable<string>: [ {String.Join(" | ", items)} ]");
}
