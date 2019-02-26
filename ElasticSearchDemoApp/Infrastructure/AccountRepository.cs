using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElasticSearchDemoApp.Domain;

namespace ElasticSearchDemoApp.Infrastructure
{
    public class AccountRepository : IAccountRepository
    {
        private readonly IElasticClientFactory _clientFactory;
        public AccountRepository(IElasticClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public IList<Account> Search()
        {
            var client = _clientFactory.CreateClient();
            var response = client.Search<Account>(s => s
            .Index("bank")
                .From(0)
                .Size(10));
            return response.Documents.ToList();
        }
    }
}
