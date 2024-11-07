using SingleResponsibilityPrinciple.Contracts;
using System;
using System.Collections.Generic;

namespace SingleResponsibilityPrinciple
{
    public class AdjustTradeDataProvider : ITradeDataProvider
    {
        ITradeDataProvider originProvider;

     
        public AdjustTradeDataProvider(ITradeDataProvider originProvider)
        {

            this.originProvider = originProvider;
        }


        public IEnumerable<string> GetTradeData()
        {

            var tradeData = originProvider.GetTradeData();
            var changeTradeData = new List<string>();
           

            foreach (var trade in tradeData)
            {
                
                var adjustedTrade = trade.Replace("GBP", "EUR");
                changeTradeData.Add(adjustedTrade);
            }

           
            return changeTradeData;
        }
    }
}
        
    

