using System;
using Newtonsoft.Json;

namespace hubtelapi_dotnet_v1.CheckOut
{
    public class Data
    {
        [JsonProperty("checkoutUrl")]
        public string CheckoutUrl { get; set; }

        [JsonProperty("checkoutId")]
        public Guid CheckoutId { get; set; }

        [JsonProperty("clientReference")]
        public string ClientReference { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}