using ElasticSearchDemoApp.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using YamlDotNet.RepresentationModel;

//namespace ElasticSearchDemoApp.Infrastructure
//{
//    public class MetadataRepository : IMetadataRepository     
//    {
//        private readonly IElasticClientFactory _clientFactory;
//        public MetadataRepository (IElasticClientFactory clientFactory)
//        {
//            clientFactory = _clientFactory;
//        }

//        public IList<Metadata> Search()
//        {
//            var client = _clientFactory.CreateClient();
//            var response = client.Search<Metadata>(s => s
//                .From(0)
//                .Size(10));
//            return response.Documents.ToList();
//        }
//    }
//}
namespace ElasticSearchDemoApp.Infrastructure
{
    public class MetadataRepository : IMetadataRepository
    {
        private readonly IElasticClientFactory _clientFactory;
        public MetadataRepository(IElasticClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public IList<Metadata> Search()
        {
            var client = _clientFactory.CreateClient();

            //------- using config.yaml file to access fields based on weights--------

            //var input = new StringReader(Document);
            //var yaml = new YamlStream();
            //yaml.Load(input);


            // ------Match query for Fads fields-------------------------------------------
            //var response = client.Search<Metadata>(s => s
            //.Index("metadata1120")
            //.Query(q => q
            //.Match(m => m.Field("FADS.iDesignDetail.iDesign.ControlText").Query("Minnesota")
            //    )));
            //return response.Documents.ToList();


            //----------Match query for efile fields----------------------------------------------------------
            var response = client.Search<Metadata>(s => s
              .Index("metadata1120")
              .Query(q => q
              .Match(m => m.Field("FADS.iDesignDetail.iDesign.eFileDetail.eFile.XPath").Query("a")
                  )));
            return response.Documents.ToList();
        }
    }
}