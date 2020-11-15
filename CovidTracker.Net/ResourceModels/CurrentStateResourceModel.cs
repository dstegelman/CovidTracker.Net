using System;

namespace CovidTracker.Net.ResourceModels
{
    public class CurrentStateResourceModel
    {
        public string state { get; set; }
        public int positive { get; set; }
        public int probableCases { get; set; }
        public int negative { get; set; }
        public int pending { get; set; }
        public string totalTestResultsSource { get; set; }
        public int totalTestResults { get; set; }
        public int hopsitalizedCurrently { get; set; }
        public int hospitalizedCumulative { get; set; }
        public int inIcuCurrently { get; set; }
        public int positiveIncrease { get; set; }

    }
}