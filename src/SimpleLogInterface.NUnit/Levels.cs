using System;

namespace SimpleLogInterface.NUnit {

	[Flags]
	public enum Levels {
		Debug,
		Info,
		Warn,
		Error,
		Fatal
	}
}
