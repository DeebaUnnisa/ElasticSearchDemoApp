using ElasticSearchDemoApp.Models;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElasticSearchDemoApp.Domain
{
    [ElasticsearchType(Name = "Meta_2017_1120_17-1F")]
    public class Metadata
    {
        public List<FADSModel> FADS { get; set; }
       // public object FADS { get; internal set; }
    }
}
