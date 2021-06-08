using FluentAssertions;
using PresInteractivas.Api.BL;
using TechTalk.SpecFlow;

namespace PresInteractivas.Test.Steps
{
    [Binding]
    public sealed class LoginStepDefinitions
    {

        private readonly ScenarioContext _scenarioContext;
        private readonly LoginBL _login;
        private string _user;
        private string _password;
        private int _social;
        private bool _result;

        public LoginStepDefinitions(ScenarioContext scenarioContext, LoginBL login)
        {
            _scenarioContext = scenarioContext;
            _login = login;
        }

        [Given("El usuario (.*)")]
        public void GivenTheUserIs(string user)
        {
            _user = user;
        }

        [Given("El password (.*)")]
        public void GivenThePasswordIs(string password)
        {
            _password = password;
        }

        [Given("el tipo de red social es (.*)")]
        public void GivenTheSocialNet(int social)
        {
            _social = social;
        }

        [When("se valida el login")]
        public void WhenTheUserAreLoggin()
        {
            _result = _login.Auth(new Api.Models.LoginDto { user = _user, password = _password });            
        }

        [Then("el resultado debera ser (.*)")]
        public void ThenTheResultShouldBe(bool result)
        {
            _result.Should().Be(result);
        }
    }
}
