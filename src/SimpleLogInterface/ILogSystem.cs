using System;

namespace SimpleLogInterface {

	public interface ILogSystem : IDisposable {

		ILogProvider LogProvider { get; }
	}
}
