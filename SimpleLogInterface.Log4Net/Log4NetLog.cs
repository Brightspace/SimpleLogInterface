using System;

namespace SimpleLogInterface.Log4Net {

	internal sealed class Log4NetLog : ILog {

		private readonly log4net.ILog m_log;

		internal Log4NetLog( log4net.ILog log ) {
			m_log = log;
		}

		void ILog.Debug( Func<object> messageBuilder, Exception exception ) {

			Log(
				() => m_log.IsDebugEnabled,
				( m, e ) => m_log.Debug( m, e ),
				messageBuilder,
				exception
			);
		}

		void ILog.Info( Func<object> messageBuilder, Exception exception ) {

			Log(
				() => m_log.IsInfoEnabled,
				( m, e ) => m_log.Info( m, e ),
				messageBuilder,
				exception
			);
		}

		void ILog.Warn( Func<object> messageBuilder, Exception exception ) {

			Log(
				() => m_log.IsWarnEnabled,
				( m, e ) => m_log.Warn( m, e ),
				messageBuilder,
				exception
			);
		}

		void ILog.Error( Func<object> messageBuilder, Exception exception ) {

			Log(
				() => m_log.IsErrorEnabled,
				( m, e ) => m_log.Error( m, e ),
				messageBuilder,
				exception
			);
		}

		void ILog.Fatal( Func<object> messageBuilder, Exception exception ) {

			Log(
				() => m_log.IsFatalEnabled,
				( m, e ) => m_log.Fatal( m, e ),
				messageBuilder,
				exception
			);
		}

		private void Log(
				Func<bool> enabledCheck,
				Action<object, Exception> logger,
				Func<object> messageBuilder,
				Exception exception
			) {

			try {
				bool enabled = enabledCheck();
				if( enabled ) {

					object message = messageBuilder();
					logger( message, exception );
				}

			} catch {
			}
		}

	}
}
