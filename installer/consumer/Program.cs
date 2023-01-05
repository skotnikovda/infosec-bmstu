using System;
using System.IO;
using Installer.Utils;

var expectedID = "";
try
{
    expectedID = File.ReadAllText("license.txt");
}
catch
{
    Console.WriteLine("License not found");
    Environment.Exit(1);
}
var actualID = IOPlatformSerialNumberProvider.Provide();
if (expectedID == actualID)
{
    Console.WriteLine("License confirmed. Hello world!");
}
else
{
    Console.WriteLine("Lisense confirmation failed");
    Environment.Exit(1);
}
