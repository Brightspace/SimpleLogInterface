
namespace SimpleLogInterface {

	public sealed class ConstantLogProvider : ILogProvider {

		private readonly ILog m_log;

		public ConstantLogProvider( ILog log ) {
			m_log = log;
		}

		public ILog Get( string name ) {
			return m_log;
		}
	}
}
