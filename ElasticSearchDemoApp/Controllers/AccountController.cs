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
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository _repository;
       // private readonly ISearchRepository<Account> _repository;
       // public AccountController(ISearchRepository<Account> repository)
       public AccountController(IAccountRepository repository)
        {
            _repository = repository;
        }

        [HttpGet()]
        public IList<Account> GetBanks([FromQuery]int from, [FromQuery]int size)
        {
            return _repository.Search();
          //  return _repository.Search("bank", from, size);
        }
    }
}