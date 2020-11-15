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
                //System.Console.WriteLine(item.positive);
                //System.Console.WriteLine(item.positiveIncrease);
            }

            var coloradoMetaData = await client.State.GetMetadataForStateAsync("co");
            System.Console.WriteLine(coloradoMetaData.twitter);
            var currentColoradoData = await client.State.GetCurrentState("co");
            System.Console.WriteLine(currentColoradoData.positiveIncrease);
            System.Console.WriteLine(currentColoradoData.inIcuCurrently);
            foreach (var item in await client.State.GetStatesMetaDataAsync())
            {
                //System.Console.WriteLine(item.twitter);
            }

        }
    }
}