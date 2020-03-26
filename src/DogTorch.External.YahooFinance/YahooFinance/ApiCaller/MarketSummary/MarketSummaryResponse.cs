using System.Collections.Generic;

namespace DogTorch.External.YahooFinance.ApiCaller
{
    public class RegularMarketChange
    {
        public double Raw { get; set; }
        public string Fmt { get; set; }
    }

    public class RegularMarketTime
    {
        public int Raw { get; set; }
        public string Fmt { get; set; }
    }

    public class RegularMarketChangePercent
    {
        public double Raw { get; set; }
        public string Fmt { get; set; }
    }

    public class RegularMarketPrice
    {
        public double Raw { get; set; }
        public string Fmt { get; set; }
    }

    public class RegularMarketPreviousClose
    {
        public double Raw { get; set; }
        public string Fmt { get; set; }
    }

    public class Result
    {
        public string FullExchangeName { get; set; }
        public string ExchangeTimezoneName { get; set; }
        public string Symbol { get; set; }
        public RegularMarketChange RegularMarketChange { get; set; }
        public int GmtOffSetMilliseconds { get; set; }
        public int ExchangeDataDelayedBy { get; set; }
        public string Language { get; set; }
        public RegularMarketTime RegularMarketTime { get; set; }
        public string ExchangeTimezoneShortName { get; set; }
        public RegularMarketChangePercent RegularMarketChangePercent { get; set; }
        public string QuoteType { get; set; }
        public string MarketState { get; set; }
        public RegularMarketPrice RegularMarketPrice { get; set; }
        public string Market { get; set; }
        public int PriceHint { get; set; }
        public bool Tradeable { get; set; }
        public int SourceInterval { get; set; }
        public string Exchange { get; set; }
        public string ShortName { get; set; }
        public string Tegion { get; set; }
        public bool Triggerable { get; set; }
        public RegularMarketPreviousClose RegularMarketPreviousClose { get; set; }
        public string HeadSymbolAsString { get; set; }
        public string Currency { get; set; }
        public string LongName { get; set; }
        public string QuoteSourceName { get; set; }
    }

    public class MarketSummaryResponse
    {
        public List<Result> Result { get; set; }
        public object Error { get; set; }
    }

    public class MarketSummaryEndpointResponse
    {
        public MarketSummaryResponse MarketSummaryResponse { get; set; }
    }
}
