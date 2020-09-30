using CovidTracker.Net.Clients;
using RestSharp;

namespace CovidTracker.Net
{
    public class CovidClient : ICovidClient
    {
        public CovidClient()
        {
            string apiBase = "https://api.covidtracking.com/";
            RestClient client = new RestClient(apiBase);
            State = new StateClient(client);
        }

        public IStateClient State {get;}
    }
}