using System.Collections.Generic;
using System.Threading.Tasks;
using CovidTracker.Net.ResourceModels;

namespace CovidTracker.Net.Clients
{
    public interface IStateClient
    {
        Task<List<HistoricValuesForStateResourceModel>> GetHistoricValuesForStateAsync(string state);
    }
}