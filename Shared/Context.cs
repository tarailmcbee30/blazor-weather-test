using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp.Shared
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Context
    {
        [JsonProperty("@version")]
        public string version { get; set; }
    }

    public class Geometry
    {
        public string type { get; set; }
        public List<List<List<double>>> coordinates { get; set; }
    }

    public class Period
    {
        public int number { get; set; }
        public string name { get; set; }
        public string detailedForecast { get; set; }
    }

    public class Properties
    {
        public string zone { get; set; }
        public DateTime updated { get; set; }
        public List<Period> periods { get; set; }
    }

    public class Root
    {
        [JsonProperty("@context")]
        public Context context { get; set; }
        public string type { get; set; }
        public Geometry geometry { get; set; }
        public Properties properties { get; set; }
    }
}
