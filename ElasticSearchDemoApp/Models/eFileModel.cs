using System;
using Nest;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElasticSearchDemoApp.Models
{
    public class EFileModel
    {
        //[Text(Name = "Name")]
        //public string Name { get; set; }

        [Text(Name = "XPath")]
        public string XPath { get; set; }

        //[Text(Name = "Description")]
        //public string Description { get; set; }

        //[Text(Name = "Annotation")]
        //public string Annotation { get; set; }
    }
}
