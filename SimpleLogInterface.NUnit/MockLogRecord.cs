using System;

namespace SimpleLogInterface.NUnit {

	public sealed class MockLogRecord {

		private readonly Level m_level;
		private readonly object m_message;
		private readonly Exception m_exception;

		public MockLogRecord(
				Level level,
				object message,
				Exception exception
			) {

			m_level = level;
			m_message = message;
			m_exception = exception;
		}

		public Level Level {
			get { return m_level; }
		}

		public object Message {
			get { return m_message; }
		}

		public Exception Exception {
			get { return m_exception; }
		}

	}
}
