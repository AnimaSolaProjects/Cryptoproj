using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace Cryptoproj.Models
{
    public class AssetsList
    {
        [JsonProperty("data")]
        public ObservableCollection<Assets> data { get; set; }
    }
}
