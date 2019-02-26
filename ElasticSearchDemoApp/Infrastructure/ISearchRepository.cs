using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElasticSearchDemoApp.Infrastructure
{
    public interface ISearchRepository<T> where T : class
    {
        IList<T> Search(string index, int from, int size);
    }
}
