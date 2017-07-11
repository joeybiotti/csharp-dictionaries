using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("APPL", "Apple");
            stocks.Add("GOOGL", "Google");
            stocks.Add("NKE", "Nike");
            stocks.Add("SBUX", "Starbucks");

            Console.WriteLine("Hello World!");            
            /* 
            Define a new Dictionary to hold the aggregated purchase information.
            - The key should be a string that is the full company name.
            - The value will be the valuation of each stock (price*amount)
            */
            
            List<(string ticker, int shares, double price)> purchases = new List <(string, int, double)>();
            
            purchases.Add((ticker: "Apple", shares: 125, price: 160.21));
            purchases.Add((ticker: "Starbucks", shares: 292, price: 11.21));
            purchases.Add((ticker: "Nike", shares: 11, price: 221.85));

            string apple = stocks["APPL"];
            string starbux = stocks["SBUX"];
            string nike = stocks["NKE"];           
            
            // Iterate over the purchases and 
            
            Dictionary<string, double> report = new Dictionary<string, double>();

            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                string name = purchase.ticker;
                int shares = purchase.shares;
                double price = purchase.price;
                double totalShares = (int) purchase.shares * (double) purchase.price;

                if(!report.ContainsKey("GM")){
                    Console.WriteLine($"{name}: {shares} shares, at ${price}. Total shares " + $"${totalShares}");
                    }else{
                    // report.Add(string, double);
                }
            }

        }
    }
}
