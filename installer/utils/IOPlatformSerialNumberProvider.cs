namespace Installer.Utils;

using System.Diagnostics;

public class IOPlatformSerialNumberProvider
{
    public static string Provide()
    {
        var arguments = "-c \"ioreg -l | awk '/IOPlatformSerialNumber/ { print $4;}'\"";
        var info = new ProcessStartInfo("sh", arguments);
        info.RedirectStandardOutput = true;
        var process = Process.Start(info);
        process!.WaitForExit();
        return process.StandardOutput.ReadLine()!;
    }
}
