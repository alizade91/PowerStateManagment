using System.Runtime.InteropServices;

namespace PowerStateManagment
{
	class ComputerState
	{
		[DllImport("Powrprof.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
		public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);

		public void SetHibernate()
		{
			SetSuspendState(true, true, true);
		}

		public void SetStandBy()
		{
			SetSuspendState(false, true, true);
		}

	}
}
