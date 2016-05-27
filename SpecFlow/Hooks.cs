using OpenQA.Selenium.IE;
using TechTalk.SpecFlow;

namespace SpecFlow
{
    [Binding]
    public sealed class Hooks
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            ScenarioContext.Current["DRIVER"] = new InternetExplorerDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //clear db
            ((InternetExplorerDriver)ScenarioContext.Current["DRIVER"]).Quit();
        }
    }
}
