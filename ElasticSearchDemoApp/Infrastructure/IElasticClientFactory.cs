using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElasticSearchDemoApp.Infrastructure
{
    public interface IElasticClientFactory
    {
        IElasticClient CreateClient();
    }
}
