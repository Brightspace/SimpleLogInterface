using System;

namespace SimpleLogInterface {

	public sealed class NullLog : ILog {

		public static readonly ILog Instance = new NullLog();

		private NullLog() {
		}

		void ILog.Debug( Func<object> messageBuilder, Exception exception ) {
		}

		void ILog.Info( Func<object> messageBuilder, Exception exception ) {
		}

		void ILog.Warn( Func<object> messageBuilder, Exception exception ) {
		}

		void ILog.Error( Func<object> messageBuilder, Exception exception ) {
		}

		void ILog.Fatal( Func<object> messageBuilder, Exception exception ) {
		}

	}
}
