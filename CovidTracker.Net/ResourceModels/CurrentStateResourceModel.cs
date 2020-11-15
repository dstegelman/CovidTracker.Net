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
        public int inIcuCumulative { get; set; }
        public int onVentilatorCurrently { get; set; }
        public int onVentilatorCumulative { get; set; }
        public int recovered { get; set; }
        public string dataQualityGrade { get; set; }
        public DateTime dateModified { get; set; }
        public int death { get; set; }
        public int hospitalized { get; set; }
        public DateTime dateChecked { get; set; }
        public int totalTestsViral { get; set; }
        public int positiveTestsViral { get; set; }
        public int negativeTestsViral { get; set; }
        public int positiveCasesViral { get; set; }
        public int deathConfirmed { get; set; }
        public int deathProbable { get; set; }
        public int totalTestEncountersViral { get; set; }
        public int totalTestsPeopleViral { get; set; }
        public int totalTestsAntibody { get; set; }
        public int positiveTestsAntibody { get; set; }
        public int negativeTestsAntibody { get; set; }
        public int totalTestsPeopleAntibody { get; set; }
        public int positiveTestsPeopleAntibody { get; set; }
        public int negativeTestsPeopleAntibody { get; set; }
        public int totalTestsPeopleAntigen { get; set; }
        public int positiveTestsPeopleAntigen { get; set; }
        public int totalTestsAntigen { get; set; }
        public int positiveTestsAntigen { get; set; }
        public string fips { get; set; }
        public int positiveIncrease { get; set; }
        public int negativeIncrease { get; set; }
        public int total { get; set; }
        public int totalTestResultsIncrease { get; set; }
        public int posNeg { get; set; }
        public int deathIncrease { get; set; }
        public int hospitalizedIncrease { get; set; }
        public int commercialScore { get; set; }
        public int negativeRegularScore { get; set; }
        public int negativeScore { get; set; }
        public int positiveScore { get; set; }
        public int score { get; set; }
        public string grade { get; set; }

    }
}