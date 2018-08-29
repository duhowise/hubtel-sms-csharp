using Newtonsoft.Json;

namespace hubtelapi_dotnet_v1.CheckOut
{
    public class Item
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        [JsonProperty("unitPrice")]
        public long UnitPrice { get; set; }
    }
}