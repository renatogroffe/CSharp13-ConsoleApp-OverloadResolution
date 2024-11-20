using ConsoleAppOverloadResolution.Tests;
using System.Runtime.InteropServices;

Console.WriteLine("***** Testes com .NET 9 + C# 13 | Overload Resolution *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName} - Kernel: {Environment
    .OSVersion.VersionString}");
Console.WriteLine();

var arrayTecnologias = new string[] { "C#", ".NET", "ASP.NET Core" };
ReadOnlySpan<string?> spanTecnologias = ["Docker", "Kubernetes", "Linux"];
List<string> listTecnologia = [ "SQL Server", "Redis", "PostgreSQL" ];

OverloadResolutionTester.PrintItems(arrayTecnologias);
OverloadResolutionTester.PrintItems(listTecnologia);
OverloadResolutionTester.PrintItems("Visual Studio Code", "Visual Studio 2022", "Rider");
OverloadResolutionTester.PrintItems(spanTecnologias);

Console.WriteLine();

OverloadResolutionPriorityTester.PrintItems(arrayTecnologias);
OverloadResolutionPriorityTester.PrintItems(listTecnologia);
OverloadResolutionPriorityTester.PrintItems("Visual Studio Code", "Visual Studio 2022", "Rider");
OverloadResolutionPriorityTester.PrintItems(spanTecnologias);