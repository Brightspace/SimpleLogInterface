using System;
using System.Collections.Generic;

namespace SimpleLogInterface.NUnit {

	public sealed class MockLog : ILog {

		private readonly List<MockLogRecord> m_logs = new List<MockLogRecord>();

		public IReadOnlyList<MockLogRecord> Logs {
			get { return m_logs; }
		}

		void ILog.Debug( Func<object> messageBuilder, Exception exception ) {

			MockLogRecord record = new MockLogRecord(
					Level.Debug,
					messageBuilder(),
					exception
				);

			m_logs.Add( record );
		}

		void ILog.Info( Func<object> messageBuilder, Exception exception ) {

			MockLogRecord record = new MockLogRecord(
					Level.Info,
					messageBuilder(),
					exception
				);

			m_logs.Add( record );
		}

		void ILog.Warn( Func<object> messageBuilder, Exception exception ) {

			MockLogRecord record = new MockLogRecord(
					Level.Warn,
					messageBuilder(),
					exception
				);

			m_logs.Add( record );
		}

		void ILog.Error( Func<object> messageBuilder, Exception exception ) {

			MockLogRecord record = new MockLogRecord(
					Level.Error,
					messageBuilder(),
					exception
				);

			m_logs.Add( record );
		}

		void ILog.Fatal( Func<object> messageBuilder, Exception exception ) {

			MockLogRecord record = new MockLogRecord(
					Level.Fatal,
					messageBuilder(),
					exception
				);

			m_logs.Add( record );
		}

	}
}
