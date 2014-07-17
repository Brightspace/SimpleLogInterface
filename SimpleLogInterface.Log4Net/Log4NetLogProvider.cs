using System;

namespace SimpleLogInterface.Log4Net {

	public sealed class Log4NetLogProvider : ILogProvider {

		private readonly Func<string, log4net.ILog> m_logProvider;

		public Log4NetLogProvider( Func<string, log4net.ILog> logProvider ) {
			m_logProvider = logProvider;
		}

		public ILog Get( string name ) {

			log4net.ILog log = m_logProvider( name );

			ILog adapted = new Log4NetLog( log );
			return adapted;
		}

	}
}
