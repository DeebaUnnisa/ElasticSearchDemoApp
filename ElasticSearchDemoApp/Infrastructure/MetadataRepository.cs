﻿using ElasticSearchDemoApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            //var client = _clientFactory.CreateClient();
            //var response = client.Search<Metadata>(s => s
            //    .Index("metadata1120")
            //    .From(0)
            //    .Size(10)
            //    .Type("Meta_2017_1120_17 - 1F")
            //    .Query(q=>q
            //    .Match(m=>m
            //    .Field(f=>f.Metadata1)
            //    .Query("Minnesota"))));

            var response = client.Search<Metadata>(s => s
            .Index("metadata1120")
         .Query(q => q
         .MatchAll()));
            return response.Documents.ToList();
        }
    }
}