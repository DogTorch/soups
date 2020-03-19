using DogTorch.Stocks.Ingest.Queue.Messages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DogTorch.Stocks.Ingest.DataReader
{
	/// <summary>
	/// For building messages
	/// </summary>
	public interface IMessageBuilder
	{
		/// <summary>
		/// Create a message from a given source
		/// </summary>
		/// <param name="source">The data source collection</param>
		/// <typeparam name="T">The data's original type</typeparam>
		/// <returns></returns>
		Task<IEnumerable<Message>> CreateAsync<T>(IEnumerable<T> source);

		/// <summary>
		/// Create a message from a given source
		/// </summary>
		/// <param name="source">The data source collection</param>
		/// <typeparam name="T">The data's original type</typeparam>
		/// <returns></returns>
		IEnumerable<Message> Create<T>(IEnumerable<T> source);
	}
}
