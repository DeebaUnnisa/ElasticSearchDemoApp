using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElasticSearchDemoApp.Models
{
    public class RootObject
    {
        [JsonProperty("FADS.iDesignDetail.iDesign.LeftText")]
        public int LeftText { get; set; }
        [JsonProperty("FADS.iDesignDetail.iDesign.BottomText")]
        public int BottomText { get; set; }
        [JsonProperty("FADS.iDesignDetail.iDesign.ControlText")]
        public int ControlText { get; set; }
        [JsonProperty("FADS.iDesignDetail.iDesign.WinSubCategory")]
        public int WinSubCategory { get; set; }
        [JsonProperty("FADS.iDesignDetail.iDesign.eFileDetail.eFile.XPath")]
        public int XPath { get; set; }
        [JsonProperty("FADS.iDesignDetail.iDesign.AreaLongName")]
        public int AreaLongName { get; set; }
        [JsonProperty("FADS.iDesignDetail.iDesign.ScreenLongName")]
        public int ScreenLongName { get; set; }
        //[JsonProperty("__invalid_name__FADS.iDesignDetail.iDesign.NavDataDetail.none.XPath")]
        //public int __invalid_name__FADS.iDesignDetail.iDesign.NavDataDetail.none.XPath { get; set; }
    }
}
