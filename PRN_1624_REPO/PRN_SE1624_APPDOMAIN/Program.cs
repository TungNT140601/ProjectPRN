using System;
using System.Reflection;
using ProcessDemo;
/*
//Truy cập tới AppDomain từ main thread
AppDomain defaultAd = AppDomain.CurrentDomain;
//Load all assemblies
Assembly[] loadAssemblies = defaultAd.GetAssemblies();
Console.WriteLine($"The assemblies loaded in {defaultAd.FriendlyName}");
foreach (Assembly a in loadAssemblies)
{
    Console.WriteLine($"Name: {a.GetName().Name}, Version: {a.GetName().Version}");
}
*/
ProgramProcess.Main();

