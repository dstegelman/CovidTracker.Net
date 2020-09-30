using System.Collections.Generic;
using System.Threading.Tasks;
using CovidTracker.Net.ResourceModels;
using RestSharp;

namespace CovidTracker.Net.Clients
{
    public class StateClient : IStateClient
    {
        private readonly RestClient _client;

        public StateClient(RestClient client)
        {
            _client = client;    
        }
        
        public async Task<List<HistoricValuesForStateResourceModel>> GetHistoricValuesForStateAsync(string state)
        {
            var request = new RestRequest($"v1/states/{state}/daily.json");
            var response = await _client.ExecuteAsync<List<HistoricValuesForStateResourceModel>>(request);
            if(response.IsSuccessful)
            {
                return response.Data;
            }
            throw new System.Exception("Failed to fetch state data");
        }
    }
}