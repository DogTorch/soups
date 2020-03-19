using System;

namespace DogTorch.Stocks.Ingest.Queue.Messages
{
	/// <summary>
	/// A queue message.
	/// </summary>
	public class Message
	{
		/// <summary>
		/// Gets the id of the message.
		/// </summary>
		public string Id { get; } = Guid.NewGuid().ToString();

		/// <summary>
		/// Gets or sets the time the message was created.
		/// </summary>
		public DateTime CreatedTime { get; } = DateTime.Now;

		/// <summary>
		/// Gets or sets the source of the message.
		/// </summary>
		public string Source { get; set; }

		/// <summary>
		/// Gets or sets the serialized data for the message.
		/// </summary>
		public string Data { get; set; }
	}
}
