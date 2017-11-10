using System;
using System.Runtime.InteropServices;

namespace PowerStateManagment
{
	public class Win32SystemPowerInformation
	{
		public SystemPowerInformation GetSystemPowerInformation()
		{
			IntPtr status = Marshal.AllocCoTaskMem(Marshal.SizeOf(typeof(SystemPowerInformation)));
			Win32FunctionInvokeWrapper.CallNtPowerInformation(INFORMATION_LEVEL.SystemPowerInformation, IntPtr.Zero, 0, status, (UInt32)Marshal.SizeOf(typeof(SystemPowerInformation)));
			return (SystemPowerInformation)Marshal.PtrToStructure(status, typeof(SystemPowerInformation));
		}
	}
}
