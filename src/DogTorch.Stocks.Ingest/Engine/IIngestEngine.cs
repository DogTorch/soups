using System.Collections.Generic;
using System.Threading.Tasks;

namespace DogTorch.Stocks.Ingest.Engine
{
	/// <summary>
	/// Performs the ingestion action
	/// </summary>
	public interface IIngestEngine
	{
		/// <summary>
		/// Ingests data from a source
		/// </summary>
		void Ingest();
	}
}
