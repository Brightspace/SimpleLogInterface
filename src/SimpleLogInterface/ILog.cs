using System;

namespace SimpleLogInterface {

	public interface ILog {

		void Debug(
				Func<object> messageBuilder,
				Exception exception = null
			);

		void Info(
				Func<object> messageBuilder,
				Exception exception = null
			);

		void Warn(
				Func<object> messageBuilder,
				Exception exception = null
			);

		void Error(
				Func<object> messageBuilder,
				Exception exception = null
			);

		void Fatal(
				Func<object> messageBuilder,
				Exception exception = null
			);

	}
}
