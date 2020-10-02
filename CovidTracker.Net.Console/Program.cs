using System;
using System.Threading.Tasks;

namespace CovidTracker.Net.Console
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            
            ICovidClient client = new CovidClient();
            foreach (var item in await client.State.GetHistoricValuesForStateAsync("co"))
            {
                System.Console.WriteLine(item.positive);
            }

            var coloradoMetaData = await client.State.GetMetadataForStateAsync("co");
            System.Console.WriteLine(coloradoMetaData.twitter);

            foreach (var item in await client.State.GetStatesMetaDataAsync())
            {
                System.Console.WriteLine(item.twitter);
            }

        }
    }
}