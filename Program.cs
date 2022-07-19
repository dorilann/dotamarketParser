using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace rest_api
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var key = "53vjd1Wcoy4K23wp13nr5QY2ai654fj";
            var data = DateTime.Now;
            var hashNames = new string[] {"Demon Eater"};
            var minPrices = new int[] { 180000 };


            while (true)
            {
                for (int i = 0; i < hashNames.Length; i++)
                {
                    RequestHandler.MakeRequest(key, hashNames[i], minPrices[i]);
                }
                Thread.Sleep(10000);
                Console.Clear();
            }

        }

    }
}
