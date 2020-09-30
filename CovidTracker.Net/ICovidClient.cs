using CovidTracker.Net.Clients;

namespace CovidTracker.Net 
{
    public interface ICovidClient
    {
        IStateClient State {get;}
    }
}