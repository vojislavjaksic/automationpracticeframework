﻿using System;
using AutomationPracticeFramework.Helpers;
using AutomationPracticeFramework.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AutomationPracticeFramework.Steps
{
    [Binding]
    public class MyAccountSteps : Base 
    {
        Utilities ut = new Utilities(Driver);
        HomePage hp = new HomePage(Driver);

        [Given(@"user clicks on Sign in section")]
        public void GivenUserClicksOnSection()
        {
            ut.ClickOnElement(hp.signin);
        }

        [When(@"user fills the fields '(.*)' emailaddress and '(.*)' password")]
        public void WhenUserFillsTheFieldsEmailaddressAndPassword(string emailaddress, string password)
        {
            SignUpPage sip = new SignUpPage(Driver);
            ut.EnterTextInElement(sip.email, emailaddress);
            ut.EnterTextInElement(sip.password, password);
        }

        [When(@"submits the form")]
        public void WhenSubmitsTheForm()
        {
            SignUpPage sip = new SignUpPage(Driver);
            ut.ClickOnElement(sip.signinbtn);
        }

        [Then(@"then the correct '(.*)' is displayed")]
        public void ThenHeShouldBeAbleToAccess(string page)
        {
            MyAccountPage map = new MyAccountPage(Driver);
            Assert.True(map.MyAccountPageIsDisplayed(page), "Expected page is not displayed");

        }

        [Given(@"types in the email address")]
        public void GivenTypesInTheEmailAddress()
        {
            SignUpPage sip = new SignUpPage(Driver);
            ut.EnterTextInElement(sip.email, ut.GenerateRandomEmail);
        }

        [Given(@"clicks '(.*)' button")]
        public void GivenClicksButton(string p0)
        {
            SignUpPage sip = new SignUpPage(Driver);
            ut.ClickOnElement(sip.createaccount);
        }

        [When(@"fiils the all required fields")]
        public void WhenFiilsTheAllRequiredFields()
        {
            CreateAccountPage cap = new CreateAccountPage(Driver);
            ut.EnterTextInElement(cap.firstname, TestConstants.FirstName);

        }

        [Then(@"the he should be able to create an account")]
        public void ThenTheHeShouldBeAbleToCreateAnAccount()
        {
            ScenarioContext.Current.Pending();
        }

    }
}