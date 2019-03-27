using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ElasticSearchDemoApp.Domain;
using ElasticSearchDemoApp.Infrastructure;
using Core.NLP.TaxDomainInterpreter.Interfaces;
using Core.NLP.Interfaces;
using Core.NLP.Models;

namespace ElasticSearchDemoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        // private readonly IQueryRepository _repository;
        //public SearchController (IQueryRepository repository)
        //{
        //    _repository = repository;
        //}
        //[HttpGet("{query}")]
        //public IList<Metadata> GetJson(string query)
        //{
        //    return _repository.SearchJson(query);
        //}
        private readonly ICoreNlp _coreNlp;
        private readonly ITaxDomainInterpreter _taxDomainInterpreter;
        private readonly IQueryRepository _repository;
        private readonly StopwordTool _stopwordTool;

        public SearchController(ICoreNlp coreNlp, ITaxDomainInterpreter taxDomainInterpreter, IQueryRepository repository, StopwordTool stopwordTool)
        {
            _coreNlp = coreNlp;
            _taxDomainInterpreter = taxDomainInterpreter;
            _repository = repository;
            _stopwordTool = stopwordTool;
        }
        [HttpGet("{nlq}")]
        public IList<Metadata> GetJson(string nlq)
        {

            ////pre processing
            //nlq = _taxDomainInterpreter.PreprocessQuery(nlq);


            //// core NLP parse
            //NlpParsedResult result = _coreNlp.Parse(nlq);
            string processedQuery = StopwordTool.RemoveStopwords(nlq);


            return _repository.SearchJson(processedQuery);
        }
    }
}