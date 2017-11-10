using System;
using System.Runtime.InteropServices;

namespace PowerStateManagment
{
	class Program
	{
		static void Main(string[] args)
		{
			//usage of Win32SleepAwakeTime
			Console.WriteLine("Last awake and sleep time info:");
			Console.WriteLine("---------------------------------------------------------------");
			Win32SleepAwakeTime win32SleepAwakeTime = new Win32SleepAwakeTime();
			DateTime dtLastAwakeTime = win32SleepAwakeTime.GetLastAwakeTime();
			DateTime dtLastSleepTime = win32SleepAwakeTime.GetLastSleepTime();
			Console.WriteLine($"Last awake time: {dtLastAwakeTime}");
			Console.WriteLine($"Last sleep time: {dtLastSleepTime}");
			Console.WriteLine("");
			Console.WriteLine("");


			//usage of Win32SystemBatteryState
			Console.WriteLine("System battery state info:");
			Console.WriteLine("---------------------------------------------------------------");
			Win32SystemBatteryState win32SystemBatteryState = new Win32SystemBatteryState();
			SystemBatteryState batteryState = win32SystemBatteryState.GetSystemBatteryState();
			Console.WriteLine($"AcOnLine: {batteryState.AcOnLine}");
			Console.WriteLine($"Battery Present: {batteryState.BatteryPresent}");
			Console.WriteLine($"Charging: {batteryState.Charging}");
			Console.WriteLine($"Discharging: {batteryState.Discharging}");
			Console.WriteLine("");
			Console.WriteLine("");


			//usage of Win32SystemPowerInformation
			Console.WriteLine("System Power Information:");
			Console.WriteLine("---------------------------------------------------------------");
			Win32SystemPowerInformation win32SystemPowerInformation = new Win32SystemPowerInformation();
			SystemPowerInformation powerInfo = win32SystemPowerInformation.GetSystemPowerInformation();
			Console.WriteLine($"Cooling mode: {powerInfo.CoolingMode}");
			Console.WriteLine($"Idleness: {powerInfo.Idleness}");
			Console.WriteLine($"MaxIdlenessAllowed: {powerInfo.MaxIdlenessAllowed}");
			Console.WriteLine($"Time remaining: {powerInfo.TimeRemaining}");
		}
	}
}
