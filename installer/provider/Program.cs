using System.IO;
using Installer.Utils;

var id = IOPlatformSerialNumberProvider.Provide();
await File.WriteAllTextAsync("license.txt", id);
