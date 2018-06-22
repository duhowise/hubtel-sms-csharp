﻿using System;
using System.Configuration;
using hubtelapi_dotnet_v1.Hubtel;

namespace hubtelapi_dotnet_v1
{
    internal class Demo
    {
        private static void Main(string[] args)
        {
            Config("clientId", "clientSecret", "merchantNumber");

            

            try
            {

                var clientId = ConfigurationManager.AppSettings["ClientId"];
                var clientSecret = ConfigurationManager.AppSettings["ClientSecret"];
                var merchant = ConfigurationManager.AppSettings["MerchantNumber"];
                var host = new ApiHost(new BasicAuth(clientId, clientSecret));


                //Messaging Example
                //var messageApi = new MessagingApi(host);
                //MessageResponse msg = messageApi.SendQuickMessage("DevUniverse", "+233241952532", "Welcome to planet Hubtel!", true);
                //Console.WriteLine(msg.Status);       


                //  //Payment request example
                //var payments=  new PaymentsApi(host);
                //  var paymentResponse =
                //      payments.RequestPayment("233241952532", 0.1M, "Duho wise", "mtn-gh", "Hire Purchase", "http://requestb.in/1minotz1", "http://requestb.in/1minotz1");
                //  Console.WriteLine(paymentResponse.Data.Description);


                // Transaction Status Check
                //var payments = new PaymentsApi(host);
                //var statusResponse =
                //    payments.CheckPaymentStatus(new Transaction
                //    {
                //        HubtelTransactionId = "76dc69dea253404f9924c70a56e589c3"
                //    });
                // Console.WriteLine(statusResponse?.Data?.FirstOrDefault()?.TransactionStatus);



                //Online Checkout status 

                //var payments = new PaymentsApi(host);
                //var statusResponse =
                //    payments.OnlinePaymentStatusV1("755b8f0979f34d44");
                //Console.WriteLine(statusResponse);

            }
            catch (Exception e)
            {
                if (e.GetType() == typeof(HttpRequestException))
                {
                    var ex = e as HttpRequestException;
                    if (ex != null && ex.HttpResponse != null)
                    {
                        Console.WriteLine("Error Status Code " + ex.HttpResponse.Status);
                    }
                }

                Console.WriteLine(e);
                
            }

            Console.ReadKey();
        }

        private static void Config(string clientId, string clientSecret, string merchantNumber)
        {
            var config = ConfigurationManager.OpenExeConfiguration(System.Reflection.Assembly.GetExecutingAssembly().Location);
            // set api keys clientid and secret
            config.AppSettings.Settings.Remove("ClientId");
            config.AppSettings.Settings.Add("ClientId",clientId);


            config.AppSettings.Settings.Remove("ClientSecret");
            config.AppSettings.Settings.Add("ClientSecret",clientSecret);


            config.AppSettings.Settings.Remove("MerchantNumber");
            config.AppSettings.Settings.Add("MerchantNumber", merchantNumber);

            //save new values
            config.Save(ConfigurationSaveMode.Modified,true);
            Console.WriteLine(ConfigurationManager.AppSettings["MerchantNumber"]);
            Console.WriteLine(ConfigurationManager.AppSettings["ClientSecret"]);
            Console.WriteLine(ConfigurationManager.AppSettings["ClientId"]);
        }
    }
}