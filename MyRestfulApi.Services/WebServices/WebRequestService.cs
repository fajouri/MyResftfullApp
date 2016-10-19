namespace MyRestfulApi.Services.WebServices
{
    using System.Net;

    public class WebRequestService: IWebRequestService
    {

        public string DoServiceCall(string url)
        {
            string response;

            using (var client = new WebClient())
            {
                client.Headers.Add("content-type", "text/xml");
                client.Headers.Add("charset", "utf-8");
                client.Headers["SOAPAction"] = "";

                response = client.UploadString(url, "GET");
            }

            return response;
        }
    }
}