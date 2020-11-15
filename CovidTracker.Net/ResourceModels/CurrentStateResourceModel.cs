using System;

namespace CovidTracker.Net.ResourceModels
{
    public class CurrentStateResourceModel
    {
        public string state { get; set; }
        public int positive { get; set; }
        public int positiveIncrease { get; set; }

    }
}