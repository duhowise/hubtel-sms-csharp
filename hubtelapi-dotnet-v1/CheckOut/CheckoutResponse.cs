using Newtonsoft.Json;

namespace hubtelapi_dotnet_v1.CheckOut
{
    public class CheckoutResponse
    {
        [JsonProperty("responseCode")]
        public object ResponseCode { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}