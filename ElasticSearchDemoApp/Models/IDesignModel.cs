using System;
using Nest;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElasticSearchDemoApp.Models
{
    public class IDesignModel
    {
        //[Text (Name = "AreaName")]
        //public string AreaName { get; set; }

        [Text(Name = "AreaLongName")]
        public string AreaLongName { get; set; }

        //[Text(Name = "AreaName")]
        //public string OwnerName { get; set; }

        //[Text(Name = "AreaName")]
        //public string ScreenName { get; set; }

        [Text(Name = "ScreenLongName")]
        public string ScreenLongName { get; set; }

        //[Text(Name = "AreaName")]
        //public string ScreenType { get; set; }

        [Text(Name = "WinSubCategory")]
        public string WinSubCategory { get; set; }

        //[Text(Name = "AreaName")]
        //public bool SingleTarget { get; set; }

        //[Text(Name = "AreaName")]
        //public string CtrlLabel { get; set; }

        //[Text(Name = "AreaName")]
        //public string IDesignFieldType { get; set; }

        [Text(Name = "AreaName")]
        public string CtrlEORG { get; set; }

        //[Text(Name = "AreaName")]
        //public string CtrlStroreValue { get; set; }

        //[Text(Name = "AreaName")]
        //public string DefaultText { get; set; }

        //[Text(Name = "AreaName")]
        //public int WinArea { get; set; }

        //[Text(Name = "AreaName")]
        //public int WinScreen { get; set; }

        //[Text(Name = "AreaName")]
        //public int ObjectID { get; set; }

        //[Text(Name = "AreaName")]
        //public int Levels { get; set; }

        //[Text(Name = "AreaName")]
        //public int FieldDefaultValue { get; set; }

        //[Text(Name = "AreaName")]
        //public int FieldFlag { get; set; }

        //[Text(Name = "AreaName")]
        //public string CtrlScript { get; set; }

        //[Text(Name = "AreaName")]
        //public string TopText { get; set; }

        [Text(Name = "BottomText")]
        public string BottomText { get; set; }

        [Text(Name = "LeftText")]
        public string LeftText { get; set; }

        //[Text(Name = "AreaName")]
        //public string RightText { get; set; }

        [Text(Name = "ControlText")]
        public string ControlText { get; set; }

        //[Text(Name = "AreaName")]
        //public string GroupText2 { get; set; }

        //[Text(Name = "AreaName")]
        //public string GroupText3 { get; set; }

        //[Text(Name = "AreaName")]
        //public string GroupText4 { get; set; }

        //[Text(Name = "AreaName")]
        //public string GroupText5 { get; set; }

        //[Text(Name = "AreaName")]
        //public string GroupText6 { get; set; }

        //[Text(Name = "AreaName")]
        //public string GroupText7 { get; set; }

        //[Text(Name = "AreaName")]
        //public string GroupText8 { get; set; }

        //[Text(Name = "AreaName")]
        //public string GroupText9 { get; set; }

        //[Text(Name = "AreaName")]
        //public int TabOrder { get; set; }

        //[Text(Name = "AreaName")]
        //public int WinFieldWidth { get; set; }

        //[Text(Name = "AreaName")]
        //public bool IsHyperLink { get; set; }

        //[Text(Name = "AreaName")]
        //public string RadioButtonStringTable { get; set; }

        //[Text(Name = "AreaName")]
        //public string LineNumber { get; set; }


        [Text(Name = "EFileDetail")]
        public EFileDetailModel EFileDetail { get; set; }


    }
}
