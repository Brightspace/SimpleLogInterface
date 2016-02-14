using System;

namespace SimpleLogInterface {

	public static class ILogExtensions {

		public static void Debug(
				this ILog log,
				string message,
				Exception exception = null
			) {

			log.Debug(
					() => new {
						Message = message
					},
					exception
				);
		}

		public static void Info(
				this ILog log,
				string message,
				Exception exception = null
			) {

			log.Info(
					() => new {
						Message = message
					},
					exception
				);
		}

		public static void Warn(
				this ILog log,
				string message,
				Exception exception = null
			) {

			log.Warn(
					() => new {
						Message = message
					},
					exception
				);
		}

		public static void Error(
				this ILog log,
				string message,
				Exception exception = null
			) {

			log.Error(
					() => new {
						Message = message
					},
					exception
				);
		}

		public static void Fatal(
				this ILog log,
				string message,
				Exception exception = null
			) {

			log.Fatal(
					() => new {
						Message = message
					},
					exception
				);
		}

	}
}
