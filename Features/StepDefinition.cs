using ddmrp;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace ddmrp.FeatureFiles
{
    [Binding]
    public sealed class StepDefinition
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        [Given("I am on HomePage")]
        public void GivenIAmOnHomePage()
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see http://go.specflow.org/doc-sharingdata 
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            Assert.AreEqual(1, actual: 1);
        }

        [When(@"I search for terms (.*) in searchbox")]
        public void WhenISearchForTermsInSearchbox(string searchTerms)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see http://go.specflow.org/doc-sharingdata 
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 
            
            Assert.AreEqual(1, actual: 1);
        }

         [Then("result items relevant to search terms (.*) should appear")]
        public void ThenResultItemsRelevantToSearchTermsShouldAppear(string searchTerms)
        {
            //TODO: implement assert (verification) logic

            Assert.AreEqual(1, actual: 1);
        }
    }
}
