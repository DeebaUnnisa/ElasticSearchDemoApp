using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElasticSearchDemoApp.Domain;
using ElasticSearchDemoApp.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ElasticSearchDemoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QueryController : ControllerBase
    {
        private readonly IQueryRepository _repository;
        public QueryController (IQueryRepository repository)
        {
            _repository = repository;
        }
        [HttpGet("{query}")]
        public IList<Metadata> GetJson(string query)
        {
            return _repository.SearchJson(query);
        }
    }
}