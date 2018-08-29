using System;
using Newtonsoft.Json;

namespace hubtelapi_dotnet_v1.CheckOut
{
    public class CheckoutCallback
    {
        [JsonProperty("ResponseCode")]
        public string ResponseCode { get; set; }

        [JsonProperty("Status")]
        public string Status { get; set; }

        [JsonProperty("Data")]
        public CallbackData Data { get; set; }
    }

    public class CallbackData
    {
        [JsonProperty("CheckoutId")]
        public Guid CheckoutId { get; set; }

        [JsonProperty("SalesInvoiceId")]
        public string SalesInvoiceId { get; set; }

        [JsonProperty("ClientReference")]
        public string ClientReference { get; set; }

        [JsonProperty("Status")]
        public string Status { get; set; }

        [JsonProperty("Amount")]
        public long Amount { get; set; }

        [JsonProperty("CustomerPhoneNumber")]
        public string CustomerPhoneNumber { get; set; }

        [JsonProperty("PaymentDetails")]
        public PaymentDetails PaymentDetails { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }
    }

    public class PaymentDetails
    {
        [JsonProperty("MobileMoneyNumber")]
        public string MobileMoneyNumber { get; set; }

        [JsonProperty("PaymentType")]
        public string PaymentType { get; set; }
    }
}