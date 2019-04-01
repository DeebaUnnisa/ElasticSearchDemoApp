using ElasticSearchDemoApp.Domain;
using System;
using Nest;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ElasticSearchDemoApp.Models;

namespace ElasticSearchDemoApp.Infrastructure
{
    public class QueryRepository : IQueryRepository
    {

        private readonly IElasticClientFactory _clientFactory;
        public QueryRepository(IElasticClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public static List<string> LoadJson()
        {

            string filepath = "config.json";
            //var a = File.ReadAllText(@"Configuration\\" + filepath);
            var a = File.ReadAllText(@"./Configuration/" + filepath);
            var root = JsonConvert.DeserializeObject<JsonObject>(a);
            var fields = new List<string>();
            var  weights = new List<int>();
            var dict = JsonConvert.DeserializeObject<Dictionary<string, int>>(a);
            foreach (var kv in dict)
            {
                weights.Add(kv.Value);
                fields.Add(kv.Key + "^" + kv.Value);
            }
            return fields;
        }
        public IList<Metadata> SearchJson(string query)
        {
            var client = _clientFactory.CreateClient();
            string simplified_search=query;

            var response = client.Search<Metadata>(s => s
            .Index("metadata1120")
            .TypedKeys(true)
            .Query(q => q
            .Bool(b => b
            .Must(m => m
            .MultiMatch(mm => mm
            .Query(simplified_search)
            .Fields(LoadJson().ToArray())
             )))));
            return response.Documents.ToList();
        }

    }
}
