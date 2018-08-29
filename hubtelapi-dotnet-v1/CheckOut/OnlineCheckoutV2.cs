using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Text;
using hubtelapi_dotnet_v1.Hubtel;
using hubtelapi_dotnet_v1.Payments;
using Newtonsoft.Json;

namespace hubtelapi_dotnet_v1.CheckOut
{
    public class OnlineCheckoutV2:AbstractApi
    {
        
        private readonly string _merchant;
        public OnlineCheckoutV2(ApiHost host) : base(host)
        {
            _merchant = ConfigurationManager.AppSettings["MerchantNumber"];
        }
        public CheckoutResponse InitiateInvoice(CheckoutRequest request)
        {


            try
            {
                var resource = $"/v2/pos/onlinecheckout/items/initiate";
                var stringWriter = new StringWriter();
                new JsonSerializer().Serialize(stringWriter, request);
                const string contentType = "application/json";
                var response = RestClient.Post(resource, contentType, Encoding.UTF8.GetBytes(stringWriter.ToString()));
                if (response == null) throw new Exception("Request Failed. Unable to get server response");
                if (response.Status == Convert.ToInt32(HttpStatusCode.OK))
                    return  JsonConvert.DeserializeObject<CheckoutResponse>(response.GetBodyAsString());
                var errorMessage = $"Status Code={response.Status}, Message={response.GetBodyAsString()}";
                throw new Exception("Request Failed : " + errorMessage);
            }
            catch (Exception e)
            {
               
                throw new Exception(e.Message,e); 
            }
        }
    }
}