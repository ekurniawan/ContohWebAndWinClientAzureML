using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WindowsFormsClient
{
    public class Hasil
    {
        public string Class { get; set; }
        [JsonProperty(PropertyName = "sepal-length")]
        public string sepallength { get; set; }
        [JsonProperty(PropertyName = "sepal-width")]
        public string sepalwidth { get; set; }
        [JsonProperty(PropertyName = "petal-length")]
        public string petallength { get; set; }
        [JsonProperty(PropertyName = "petal-width")]
        public string petalwidth { get; set; }
        [JsonProperty(PropertyName = "Scored Labels")]
        public string ScoredLabels { get; set; }
        [JsonProperty(PropertyName = "Scored Probabilities")]
        public string ScoredProbabilities { get; set; }
    }
}
