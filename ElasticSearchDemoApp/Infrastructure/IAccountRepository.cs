using ElasticSearchDemoApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElasticSearchDemoApp.Infrastructure
{
    public interface IAccountRepository
    {
        //IList<Account> Search(string v);
        IList<Account> Search();
    }
}
