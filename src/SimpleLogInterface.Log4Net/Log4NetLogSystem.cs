using System.Reflection;

using log4net;

namespace SimpleLogInterface.Log4Net {

	public static class Log4NetLogSystem {

		/// <summary>
		/// Creates a log system for the default log4net repository.
		/// </summary>
		/// <returns>Returns the log system.</returns>
		public static ILogSystem Create() {

			ILogProvider provider = new Log4NetLogProvider(
					( name ) => LogManager.GetLogger( name )
				);

			ILogSystem system = new BasicLogSystem(
					provider,
					() => LogManager.Shutdown()
				);

			return system;
		}

		/// <summary>
		/// Creates a log system for the specified <param name="repository" />.
		/// </summary>
		/// <returns>Returns the log system.</returns>
		public static ILogSystem Create( string repository ) {

			ILogProvider provider = new Log4NetLogProvider(
					( name ) => LogManager.GetLogger( repository, name )
				);

			ILogSystem system = new BasicLogSystem(
					provider,
					() => LogManager.ShutdownRepository( repository )
				);

			return system;
		}

		/// <summary>
		/// Creates a log system for the specified <param name="repositoryAssembly" />.
		/// </summary>
		/// <returns>Returns the log system.</returns>
		public static ILogSystem Create( Assembly repositoryAssembly ) {

			ILogProvider provider = new Log4NetLogProvider(
					( name ) => LogManager.GetLogger( repositoryAssembly, name )
				);

			ILogSystem system = new BasicLogSystem(
					provider,
					() => LogManager.ShutdownRepository( repositoryAssembly )
				);

			return system;
		}
	}
}
