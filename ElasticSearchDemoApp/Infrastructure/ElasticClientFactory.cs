using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElasticSearchDemoApp.Infrastructure
{
    public class ElasticClientFactory : IElasticClientFactory
    {
        private readonly IElasticClient _client;
        public ElasticClientFactory()
        {
            var settings = new ConnectionSettings(new Uri("http://localhost:9200"));
            _client = new ElasticClient(settings);
        }

        public IElasticClient CreateClient()
        {
            return _client;
        }
    }
}