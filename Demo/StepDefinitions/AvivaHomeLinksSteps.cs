using Bdd.Practice.Framework;
using Bdd.Practice.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

using System.Linq;
using TechTalk.SpecFlow;

namespace Bdd.Practice.StepDefinitions
{
    [Binding]
    public class AvivaHomeLinksSteps
    {
        public GoogleHomePage googlePage = new GoogleHomePage();

        [Given(@"User launch google\.com")]
        public void GivenLaunchGoogle_Com()
        {
            CustomDriver.driver.Navigate().GoToUrl("https://www.google.com");
            Console.WriteLine("Launched Google site.");
        }

        [When(@"User search for Aviva in Google")]
        public void WhenUserIsOnGooglePageSearchForAviva()
        {
            this.googlePage.TriggerSearch("Aviva");
            Console.WriteLine("Written Aviva in search box and hit submit");
        }

        [Then(@"They should see (.*) links in the first search page")]
        public void ThenAllTheRelatedSearchesShouldAppear(int linksExpected)
        {
            int linkCount = googlePage.LinkElements.Count();
            Console.WriteLine("Number of links present: " + linkCount);
            Assert.IsTrue(linksExpected == linkCount);
        }

        [Then(@"They should see the fifth link text")]
        public void ThenTheyShouldSeeTheFifthLinkText()
        {
           Console.WriteLine("The text of fifth link is : " + googlePage.LinkElements[4].Text);
        }
    }
}
