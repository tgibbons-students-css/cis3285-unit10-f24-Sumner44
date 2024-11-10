using SingleResponsibilityPrinciple.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    internal class URLAsyncProvider : ITradeDataProvider
    {
        private readonly ITradeDataProvider baseProvider;

        public URLAsyncProvider(ITradeDataProvider baseProvider)
        {
            this.baseProvider = baseProvider;
        }

        public async Task<IEnumerable<string>> GetTradeData()
        {
            // Call the baseProvider's GetTradeData asynchronously and return the result
            return await baseProvider.GetTradeData();
        }
    }
}
