using Microsoft.Data.SqlClient;
using SingleResponsibilityPrinciple.Contracts;
using SingleResponsibilityPrinciple;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    internal class RestfulTradeDataProvider : ITradeDataProvider
    {
        private readonly string restfulURL;
        private readonly ILogger logger;

        public RestfulTradeDataProvider(string restfulURL, ILogger logger)
        {
            this.restfulURL = restfulURL;
            this.logger = logger;
        }

        public async Task<IEnumerable<string>> GetTradeData()
        {
            try
            {
                // Try to fetch trade data asynchronously
                return await GetProductAsync();
            }
            catch (Exception ex)
            {
                // Log the error and return an empty list if an exception occurs
                logger.LogWarning("Error retrieving trade data: {ExceptionMessage}", ex.Message);
                return await Task.FromResult(Enumerable.Empty<string>());
            }
        }

        private async Task<IEnumerable<string>> GetProductAsync()
        {
            // Simulate an asynchronous operation, e.g., fetching data from an API or DB.
            await Task.Delay(1000);  // Simulating a network delay
            return new List<string> { "Trade1", "Trade2", "Trade3" }; // Returning mock trade data
        }
    }
}

