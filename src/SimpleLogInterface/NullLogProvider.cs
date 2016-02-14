
namespace SimpleLogInterface {

	public sealed class NullLogProvider : ILogProvider {

		public static readonly ILogProvider Instance = new NullLogProvider();

		private NullLogProvider() {
		}

		ILog ILogProvider.Get( string name ) {
			return NullLog.Instance;
		}
	}
}
