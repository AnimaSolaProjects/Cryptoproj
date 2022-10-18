using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptoproj.Models
{
    // List with cryptocurrency
    public class AssetsList
    {
        [JsonProperty("data")]
        public ObservableCollection<Assets> data { get; set; }
    }
}
