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
    public class QueryRepository
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
        public static void LoadJson()
        {

            string filepath = "config.json";
            var a = File.ReadAllText(@"Configuration\\" + filepath);
            var root = JsonConvert.DeserializeObject<RootObject>(a);
            string readResult = string.Empty;
            string writeResult = string.Empty;
            var  weights = new List<int>();
            // root.LeftText = root.LeftText / norm;

            weights.Add(root.LeftText);
            weights.Add(root.BottomText);
            weights.Add(root.ControlText);
            root.ControlText.va

        }

    }
}
