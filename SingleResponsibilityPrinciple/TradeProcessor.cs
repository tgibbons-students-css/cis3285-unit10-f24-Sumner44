using SingleResponsibilityPrinciple.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class TradeProcessor
    {
        public TradeProcessor(ITradeDataProvider tradeDataProvider, ITradeParser tradeParser, ITradeStorage tradeStorage)
        {
            this.tradeDataProvider = tradeDataProvider;
            this.tradeParser = tradeParser;
            this.tradeStorage = tradeStorage;
        }

        // Make ProcessTrades asynchronous to call GetTradeData() with await
        public async Task ProcessTradesAsync()
        {
            // Use await to get the trade data asynchronously
            var lines = await tradeDataProvider.GetTradeData();  // This line is now asynchronous

            // Parse the lines (assuming Parse is synchronous)
            var trades = tradeParser.Parse(lines);

            // Persist the parsed trades (assuming Persist is synchronous)
            tradeStorage.Persist(trades);
        }

        private readonly ITradeDataProvider tradeDataProvider;
        private readonly ITradeParser tradeParser;
        private readonly ITradeStorage tradeStorage;
    }
}

