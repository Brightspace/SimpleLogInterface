using System;

namespace SimpleLogInterface.Log4Net {

	internal sealed class Log4NetLog : ILog {

		private readonly log4net.ILog m_log;

		internal Log4NetLog( log4net.ILog log ) {
			m_log = log;
		}

		void ILog.Debug( Func<object> message, Exception exception ) {

			Log(
				() => m_log.IsDebugEnabled,
				( m, e ) => m_log.Debug( m, e ),
				message,
				exception
			);
		}

		void ILog.Info( Func<object> message, Exception exception ) {

			Log(
				() => m_log.IsInfoEnabled,
				( m, e ) => m_log.Info( m, e ),
				message,
				exception
			);
		}

		void ILog.Warn( Func<object> message, Exception exception ) {

			Log(
				() => m_log.IsWarnEnabled,
				( m, e ) => m_log.Warn( m, e ),
				message,
				exception
			);
		}

		void ILog.Error( Func<object> message, Exception exception ) {

			Log(
				() => m_log.IsErrorEnabled,
				( m, e ) => m_log.Error( m, e ),
				message,
				exception
			);
		}

		void ILog.Fatal( Func<object> message, Exception exception ) {

			Log(
				() => m_log.IsFatalEnabled,
				( m, e ) => m_log.Fatal( m, e ),
				message,
				exception
			);
		}

		private void Log(
				Func<bool> enabledCheck,
				Action<object, Exception> logger,
				Func<object> messageGetter,
				Exception exception
			) {

			try {
				bool enabled = enabledCheck();
				if( enabled ) {

					object message = messageGetter();
					logger( message, exception );
				}

			} catch {
			}
		}

	}
}
