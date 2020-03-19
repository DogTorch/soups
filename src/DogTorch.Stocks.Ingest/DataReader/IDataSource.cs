using DogTorch.Stocks.Ingest.Queue.Messages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DogTorch.Stocks.Ingest.DataReader
{
	/// <summary>
	/// For reading data from a data source
	/// </summary>
	public interface IDataSource
	{
		/// <summary>
		/// Gets data from a data source
		/// </summary>
		/// <returns>A collection of data from the data source</returns>
		Task<IEnumerable<Message>> ReadAsync();

		/// <summary>
		/// Gets data from a data source
		/// </summary>
		/// <returns>A collection of data from the data source</returns>
		IEnumerable<Message> Read();
	}
}
