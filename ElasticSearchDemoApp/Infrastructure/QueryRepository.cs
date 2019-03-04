using ElasticSearchDemoApp.Domain;
using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using YamlDotNet.RepresentationModel;
using Newtonsoft.Json.Linq;
using ElasticSearchDemoApp.Models;

namespace ElasticSearchDemoApp.Infrastructure
{
    public class QueryRepository : IQueryRepository
    {

        //public IList<Metadata> Query()
        //public normalise(YamlDocument yamlDocument)
        //{
        //    var yaml_doc = new StreamReader("C: /Users/U6072725/Desktop/main/config.yaml");
        //    var yaml = new YamlStream();
        //    var yml_doc = yaml.Load(reader);
        //    foreach(KeyValuePair keyValue in yaml)
        //    {
        //    }
        //}
        //}
        private readonly IElasticClientFactory _clientFactory;
        public QueryRepository(IElasticClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public static List<string> LoadJson()
        {

            string filepath = "config.json";
            var a = File.ReadAllText(@"Configuration\\" + filepath);
            var root = JsonConvert.DeserializeObject<RootObject>(a);
            //string readResult = string.Empty;
            //string writeResult = string.Empty;
            //int normalise_factor = 10;
            var fields = new List<string>();
            var  weights = new List<int>();
            // root.LeftText = root.LeftText / norm;

            var dict = JsonConvert.DeserializeObject<Dictionary<string, int>>(a);
            foreach (var kv in dict)
            {
               // Console.WriteLine(kv.Key + ":" + kv.Value);
                weights.Add(kv.Value);
                fields.Add(kv.Key + "^" + kv.Value);
                //fields.Add(kv.Key);
                // kv.Value = kv.Value / normalise_factor;

            }

            //weights.Add(root.LeftText);
            //weights.Add(root.BottomText);
            //weights.Add(root.ControlText);
            //for(int i =0; i<3; i++)
            //{
            //    var normalise_value = weights[i] / 5;
            //}
            // root.ControlText.va
            return fields;
        }
        public IList<Metadata> SearchJson()
        {
            var client = _clientFactory.CreateClient();
            string simplified_search="Date";

            //var response = client.Search<Metadata>(s => s
            //  .Index("metadata1120")
            //  .Query(q => q
            //  .Match(m => m.Field(LoadJson().First()).Query(simplified_search)
            //      )));
          //  Console.WriteLine(LoadJson().ToString());

            var response = client.Search<Metadata>(s => s
            .Index("metadata1120")
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
o