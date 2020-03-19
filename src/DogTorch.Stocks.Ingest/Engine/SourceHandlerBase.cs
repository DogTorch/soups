using DogTorch.Stocks.Ingest.DataReader;
using DogTorch.Stocks.Ingest.Queue;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DogTorch.Stocks.Ingest.Engine
{
	/// <summary>
	/// The base for the ingest engine process
	/// </summary>
	public class SourceHandlerBase
	{
		private readonly IDataSource _dataSource;
		private readonly IQueuePopulator _queuePopulator;

		protected SourceHandlerBase(IDataSource dataSource, IQueuePopulator queuePopulator) 
		{
			_dataSource = dataSource;
			_queuePopulator = queuePopulator;
		}

		/// <summary>
		/// Ingest's all data from the data engines
		/// </summary>
		public virtual async Task IngestAsync()
		{
			IEnumerable<Queue.Messages.Message> messages = await _dataSource.ReadAsync();
			await _queuePopulator.SendAsync(messages);
		}
	}
}
