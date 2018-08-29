using Newtonsoft.Json;

namespace hubtelapi_dotnet_v1.CheckOut
{
    public class CheckoutRequest
    {
        [JsonProperty("items")]
        public Item[] Items { get; set; }

        [JsonProperty("totalAmount")]
        public long TotalAmount { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("callbackUrl")]
        public string CallbackUrl { get; set; }

        [JsonProperty("returnUrl")]
        public string ReturnUrl { get; set; }

        [JsonProperty("merchantBusinessLogoUrl")]
        public string MerchantBusinessLogoUrl { get; set; }

        [JsonProperty("merchantAccountNumber")]
        public string MerchantAccountNumber { get; set; }

        [JsonProperty("cancellationUrl")]
        public string CancellationUrl { get; set; }

        [JsonProperty("clientReference")]
        public string ClientReference { get; set; }
    }
}