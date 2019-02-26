using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElasticSearchDemoApp.Domain
{
    [ElasticsearchType(Name = "account")]
    public class Account
    {
        [Text(Name = "firstname")]
        public string FirstName { get; set; }
        [Text(Name = "lastname")]
        public string LastName { get; set; }
        [Number(Name = "account_number")]
        public string AccountNumber { get; set; }
    }
}
