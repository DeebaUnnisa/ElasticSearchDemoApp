using ElasticSearchDemoApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//namespace ElasticSearchDemoApp.Infrastructure
//{
//    public interface IMetadataRepository
//    {
//        IList<Metadata> Search();
//    }
//}
namespace ElasticSearchDemoApp.Infrastructure
{
    public interface IMetadataRepository
    {
        IList<Metadata> Search();
    }
}
