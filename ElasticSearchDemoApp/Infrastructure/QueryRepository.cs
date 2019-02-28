//using ElasticSearchDemoApp.Domain;
//using System;
//using System.Linq;
//using System.Collections.Generic;
//using System.IO;
//using Newtonsoft.Json;
//using YamlDotNet.RepresentationModel;
//using Newtonsoft.Json.Linq;
//using ElasticSearchDemoApp.Models;

//namespace ElasticSearchDemoApp.Infrastructure
//{
//    public class QueryRepository
//    {
//      //public IList<Metadata> Query()
//            //public normalise(YamlDocument yamlDocument)
//            //{
//            //    var yaml_doc = new StreamReader("C: /Users/U6072725/Desktop/main/config.yaml");
//            //    var yaml = new YamlStream();
//            //    var yml_doc = yaml.Load(reader);
//            //    foreach(KeyValuePair keyValue in yaml)
//            //    {

//            //    }
                
//            //}
//        //}
//        public static void LoadJson()
//        {
      
//                string filepath = "config.json";
//                string readResult = string.Empty;
//                string writeResult = string.Empty;
//                int[] weights = new int[6];
//                var a = File.ReadAllText(@"Configuration\\"+ filepath);
//            var root =  JsonConvert.DeserializeObject<RootObject>(a);
//            root.LeftText = root.LeftText / norm;
//                using (StreamReader r = new StreamReader(filepath))
//                {
//                    var json = r.ReadToEnd();
//                    var jobj = JObject.Parse(json);
//                    readResult = jobj.ToString();
//                    foreach (var item in jobj.Properties())
//                    {
//                       // weights[] = item.Value;
//                       // item.Value = item.Value.ToString().Replace("v1", "v2");
//                    }
//                }

//        }
        
//    }
//}
