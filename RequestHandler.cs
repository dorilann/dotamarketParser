using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rest_api
{
    public static class RequestHandler
    {
        public static void MakeRequest(string key , string hashName, int minPrice)
        {
            var request = new GetRequest($"https://market.dota2.net/api/v2/search-item-by-hash-name?key={key}&hash_name={hashName}");
            request.Run();
            var response = request.Response;
            var json = JObject.Parse(response);
            var items = json["data"];
            foreach ( var item in items )
            {
                if ((int)item["price"] < minPrice)
                {
                    Console.WriteLine(item["market_hash_name"]);
                    Console.WriteLine((float)item["price"]/100);
                    Console.WriteLine("---------------");
                }
            }
            //Console.WriteLine(json);
        }

    }
}
