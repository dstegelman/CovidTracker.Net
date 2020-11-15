using System.Collections.Generic;
using System.Threading.Tasks;
using CovidTracker.Net.ResourceModels;

namespace CovidTracker.Net.Clients
{
    public interface IStateClient
    {
        Task<CurrentStateResourceModel> GetCurrentState(string state);
        Task<List<HistoricValuesForStateResourceModel>> GetHistoricValuesForStateAsync(string state);
        Task<MetaForStateResourceModel> GetMetadataForStateAsync(string state);
        Task<List<MetaForStateResourceModel>> GetStatesMetaDataAsync();
    }
}