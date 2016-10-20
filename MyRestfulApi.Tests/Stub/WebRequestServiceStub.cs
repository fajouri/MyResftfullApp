namespace MyRestfulApi.Tests.Stub
{
    using Services.WebServices;


    public class WebRequestServiceStub : IWebRequestService
    {
        public string DoServiceCall(string url)
        {
            return "[\"15.000\",\"15.400\",\"Actualizada al 19/10/2016 15:00\"]";
        }
    }
}
