using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElasticSearchDemoApp.Infrastructure
{
    public class SearchRepository<T> : ISearchRepository<T> where T : class
    {
        private IElasticClientFactory _elasticClientFactory;
        public SearchRepository(IElasticClientFactory elasticClientFactory)
        {
            _elasticClientFactory = elasticClientFactory;
        }

        public IList<T> Search(string index, int from, int size)
        {
            var client = _elasticClientFactory.CreateClient();
            var searchRequest = new SearchRequest(index, Types.Type<T>())
            {
                From = from,
                Size = size
            };
            return client.Search<T>(searchRequest).Documents.ToList();
        }
    }
}
