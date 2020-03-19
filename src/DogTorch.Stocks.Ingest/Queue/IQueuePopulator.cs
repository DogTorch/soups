using DogTorch.Stocks.Ingest.Queue.Messages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DogTorch.Stocks.Ingest.Queue
{
	/// <summary>
	/// For populating the message queue
	/// </summary>
	public interface IQueuePopulator
	{
		/// <summary>
		/// Sends a collection of messages to the queue
		/// </summary>
		/// <param name="messages">The messages to send ot the queue</param>
		void Send(IEnumerable<Message> messages);

		/// <summary>
		/// Sends a collection of messages to the queue
		/// </summary>
		/// <param name="messages">The messages to send ot the queue</param>
		Task SendAsync(IEnumerable<Message> messages);
	}
}
