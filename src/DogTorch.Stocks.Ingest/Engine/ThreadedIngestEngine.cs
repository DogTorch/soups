using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogTorch.Stocks.Ingest.Engine
{
	/// <summary>
	/// Stupidly runs all engines in parallel
	/// </summary>
	public class ThreadedIngestEngine : IIngestEngine
	{
		private readonly IEnumerable<SourceHandlerBase> _ingestEngines;

		public ThreadedIngestEngine(IEnumerable<SourceHandlerBase> ingestEngines)
		{
			_ingestEngines = ingestEngines;
		}

		/// <inheritdoc/>
		public void Ingest()
		{
			var engineTasks = _ingestEngines.Select(e => e.IngestAsync()).ToArray();
			Task.WaitAll(engineTasks);
		}
	}
}
