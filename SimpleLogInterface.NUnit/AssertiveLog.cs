using System;

using NUnit.Framework;

namespace SimpleLogInterface.NUnit {

	public sealed class AssertiveLog : ILog {

		[Flags]
		public enum Levels {
			Debug,
			Info,
			Warn,
			Error,
			Fatal
		}

		/// <summary>
		/// Allows Debug and Info messages.
		/// </summary>
		public static readonly ILog Default = new AssertiveLog(
				Levels.Debug | Levels.Info
			);

		private readonly Levels m_allowedLevels;

		public AssertiveLog( Levels allowedLevels ) {
			m_allowedLevels = allowedLevels;
		}

		void ILog.Debug( Func<object> messageBuilder, Exception exception ) {

			if( !m_allowedLevels.HasFlag( Levels.Debug ) ) {
				Fail( messageBuilder, exception );
			}
		}

		void ILog.Info( Func<object> messageBuilder, Exception exception ) {

			if( !m_allowedLevels.HasFlag( Levels.Info ) ) {
				Fail( messageBuilder, exception );
			}
		}

		void ILog.Warn( Func<object> messageBuilder, Exception exception ) {

			if( !m_allowedLevels.HasFlag( Levels.Warn ) ) {
				Fail( messageBuilder, exception );
			}
		}

		void ILog.Error( Func<object> messageBuilder, Exception exception ) {

			if( !m_allowedLevels.HasFlag( Levels.Error ) ) {
				Fail( messageBuilder, exception );
			}
		}

		void ILog.Fatal( Func<object> messageBuilder, Exception exception ) {

			if( !m_allowedLevels.HasFlag( Levels.Fatal ) ) {
				Fail( messageBuilder, exception );
			}
		}

		private static void Fail( Func<object> messageBuilder, Exception exception ) {

			object envelope =
				new {
					Message = messageBuilder(),
					Exception = exception
				};

			Assert.Fail( envelope.ToString() );
		}

	}
}
