using ElasticSearchDemoApp.Models;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElasticSearchDemoApp.Domain
{
    [ElasticsearchType(Name = "Metadata")]
    public class Metadata
    {
        public List<FADSModel> FADS { get; set; }
       // public object FADS { get; internal set; }
    }
}
