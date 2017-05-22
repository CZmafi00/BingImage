using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingImage
{
    /// <summary>
    /// Contains Bing image of the day data. Data is parsed from json: http://www.bing.com/HPImageArchive.aspx?format=js&idx=0&n=1&mkt=en-US
    /// </summary>
    public class BingImage
    {
        [JsonProperty(PropertyName = "images")]
        public Image[] Images { get; set; }
        [JsonProperty(PropertyName = "tooltips")]
        public Tooltips ToolTips { get; set; }
    }
    public class Image
    {
        [JsonProperty(PropertyName = "startdate")]
        public string StartDate { get; set; }
        [JsonProperty(PropertyName = "fullstartdate")]
        public string FullStartDate { get; set; }
        [JsonProperty(PropertyName = "enddate")]
        public string EndDate { get; set; }
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
        [JsonProperty(PropertyName = "urlbase")]
        public string UrlBase { get; set; }
        [JsonProperty(PropertyName = "copyright")]
        public string CopyRight { get; set; }
        [JsonProperty(PropertyName = "copyrightlink")]
        public string CopyRightLink { get; set; }
        [JsonProperty(PropertyName = "quiz")]
        public string Quiz { get; set; }
        [JsonProperty(PropertyName = "wp")]
        public string Wp { get; set; }
        [JsonProperty(PropertyName = "hsh")]
        public string Hsh { get; set; }
        [JsonProperty(PropertyName = "drk")]
        public string Drk { get; set; }
        [JsonProperty(PropertyName = "top")]
        public string Top { get; set; }
        [JsonProperty(PropertyName = "bot")]
        public string Bot { get; set; }
        [JsonProperty(PropertyName = "hs")]
        public string[] Hs { get; set; }
    }
    public class Tooltips
    {
        [JsonProperty(PropertyName = "loading")]
        public string Loading { get; set; }
        [JsonProperty(PropertyName = "previous")]
        public string Previous { get; set; }
        [JsonProperty(PropertyName = "next")]
        public string Next { get; set; }
        [JsonProperty(PropertyName = "walle")]
        public string Walle { get; set; }
        [JsonProperty(PropertyName = "walls")]
        public string Walls { get; set; }
    }
}
