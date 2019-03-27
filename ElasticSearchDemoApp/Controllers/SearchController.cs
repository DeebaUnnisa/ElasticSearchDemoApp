using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ElasticSearchDemoApp.Domain;
using ElasticSearchDemoApp.Infrastructure;

namespace ElasticSearchDemoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly IQueryRepository _repository;
        private readonly StopwordTool _stopwordTool;

        public SearchController(IQueryRepository repository, StopwordTool stopwordTool)
        {
            _repository = repository;
            _stopwordTool = stopwordTool;
        }
        [HttpGet("{nlq}")]
        public IList<Metadata> GetJson(string nlq)
        {

            string processedQuery = StopwordTool.RemoveStopwords(nlq);

            return _repository.SearchJson(processedQuery);
        }
    }
}