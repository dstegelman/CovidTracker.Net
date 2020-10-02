using System.Collections.Generic;
using System.Threading.Tasks;
using CovidTracker.Net.Exceptions;
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
            throw new FailedToFetchException("Failed to fetch state data");
        }

        public async Task<MetaForStateResourceModel> GetMetadataForStateAsync(string state)
        {
            var request = new RestRequest($"v1/states/{state}/info.json");
            var response = await _client.ExecuteAsync<MetaForStateResourceModel>(request);
            if (response.IsSuccessful)
            {
                return response.Data;
            }
            throw new FailedToFetchException("Failed to fetch state meta data");
        }

        public async Task<List<MetaForStateResourceModel>> GetStatesMetaDataAsync()
        {
            var request = new RestRequest($"v1/states/info.json");
            var response = await _client.ExecuteAsync<List<MetaForStateResourceModel>>(request);
            if (response.IsSuccessful)
            {
                return response.Data;
            }
            throw new FailedToFetchException("Failed to fetch meta for all states");
        }
    }
}