using SingleResponsibilityPrinciple.Contracts;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class StreamTradeDataProvider : ITradeDataProvider
    {
        private readonly Stream stream;
        private readonly ILogger logger;

        public StreamTradeDataProvider(Stream stream, ILogger logger)
        {
            this.stream = stream;
            this.logger = logger;
        }

        public async Task<IEnumerable<string>> GetTradeData()
        {
            var tradeData = new List<string>();
            logger.LogInfo("Reading trades from file stream.");

            using (var reader = new StreamReader(stream))
            {
                string line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    tradeData.Add(line);
                }
            }

            // Returning the trade data as a Task
            return await Task.FromResult(tradeData);
        }
    }
}
