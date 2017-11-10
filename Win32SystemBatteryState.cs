using System;
using System.Runtime.InteropServices;

namespace PowerStateManagment
{
	public class Win32SystemBatteryState
	{
		public SystemBatteryState GetSystemBatteryState()
		{
			IntPtr status = Marshal.AllocCoTaskMem(Marshal.SizeOf(typeof(SystemBatteryState)));
			Win32FunctionInvokeWrapper.CallNtPowerInformation(INFORMATION_LEVEL.SystemBatteryState, IntPtr.Zero, 0, status, (UInt32)Marshal.SizeOf(typeof(SystemBatteryState)));
			return (SystemBatteryState)Marshal.PtrToStructure(status, typeof(SystemBatteryState));
		}
	}
}
