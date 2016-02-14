using System;

namespace SimpleLogInterface {

	public static class ILogProviderExtensions {

		public static ILog Get<T>( this ILogProvider provider ) {

			ILog log = ILogProviderExtensions.Get( provider, typeof( T ) );
			return log;
		}

		public static ILog Get(
				this ILogProvider provider,
				Type type
			) {

			string name = type.FullName;

			ILog log = provider.Get( name );
			return log;
		}
	}
}
