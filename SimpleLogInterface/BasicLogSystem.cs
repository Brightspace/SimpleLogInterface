using System;

namespace SimpleLogInterface {

	public sealed class BasicLogSystem : ILogSystem {

		private readonly ILogProvider m_logProvider;
		private readonly Action m_shutdown;

		public BasicLogSystem(
				ILogProvider logProvider,
				Action shutdown
			) {

			m_logProvider = logProvider;
			m_shutdown = shutdown;
		}

		ILogProvider ILogSystem.LogProvider {
			get { return m_logProvider; }
		}

		void IDisposable.Dispose() {
			m_shutdown();
		}

	}
}
