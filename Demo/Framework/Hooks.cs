using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bdd.Practice.Framework;
using TechTalk.SpecFlow;

namespace Bdd.Practice.Framework
{
    [Binding]
    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            CustomDriver.SetBrowser();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            CustomDriver.Close();
        }
    }
}
