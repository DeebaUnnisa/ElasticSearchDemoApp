using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElasticSearchDemoApp.Domain;
using ElasticSearchDemoApp.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

//namespace ElasticSearchDemoApp.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class MetadataController : ControllerBase
//    {
//        private readonly ISearchRepository<Metadata> _repository;
//        public MetadataController(ISearchRepository<Metadata> repository)
//        {
//            _repository = repository;
//        }

//        [HttpGet()]
//        public IList<Metadata> Getdata([FromQuery]int from, [FromQuery]int size)
//        {
//            return _repository.Search("metadata1120", from, size);
//        }
//    }
//}

namespace ElasticSearchDemoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MetadataController : ControllerBase
    {
        private readonly IMetadataRepository _repository;
        public MetadataController(IMetadataRepository repository)
        {
            _repository = repository;
        }

        [HttpGet()]
        //public IList<Metadata> Getdata([FromQuery]int from, [FromQuery]int size)
            public IList<Metadata> Getdata()
        {
            return _repository.Search();
        }
    }
}