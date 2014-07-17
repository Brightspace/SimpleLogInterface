using System;

namespace SimpleLogInterface {

	public interface ILog {

		void Debug(
				Func<object> message,
				Exception exception = null
			);

		void Info(
				Func<object> message,
				Exception exception = null
			);

		void Warn(
				Func<object> message,
				Exception exception = null
			);

		void Error(
				Func<object> message,
				Exception exception = null
			);

		void Fatal(
				Func<object> message,
				Exception exception = null
			);

	}
}
