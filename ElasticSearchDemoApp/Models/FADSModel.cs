using System;
using Nest;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElasticSearchDemoApp.Models
{
    public class FADSModel
    {
        // public IList<IDesignDetailModel> FADS { get; set; }
        [Text(Name ="CreateDate")]
        public DateTimeOffset CreateDate { get; set; }

        [Text(Name ="Category")]
        public string Category { get; set; }

        [Text(Name ="FieldDescription")]
        public string FieldDescription { get; set; }

        [Text(Name ="Name")]
        public string Name { get; set; }

        [Text(Name ="FadsScreenTitle")]
        public string FadsScreenTitle { get; set; }

        [Text(Name ="DosArea")]
        public long DosArea { get; set; }

        [Text(Name ="DosScreen")]
        public long DosScreen { get; set; }

        [Text(Name ="ExternalField")]
        public long ExternalField { get; set; }

        [Text(Name = "IDesignDetail")]
        public IDesignDetailModel IDesignDetail { get; set; }
    }
}
