using Core.NLP;
using Core.NLP.Interfaces;
using Core.NLP.TaxDomainInterpreter;
using Core.NLP.TaxDomainInterpreter.Interfaces;
using Lamar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElasticSearchDemoApp.DependencyInjection
{
    public class SearchRegistry : ServiceRegistry
    {
        public SearchRegistry()
        {
            For<ICoreNlp>().Use<SfNlp>();
            For<ITaxDomainInterpreter>().Use<TaxDomainInterpreter>();
        }
    }
}
