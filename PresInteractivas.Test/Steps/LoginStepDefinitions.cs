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
        private bool _result;

        public LoginStepDefinitions(ScenarioContext scenarioContext, LoginBL login)
        {
            _scenarioContext = scenarioContext;
            _login = login;
        }

        [Given("El usuario es (.*)")]
        public void GivenTheUserIs(string user)
        {
            _user = user;
        }

        [Given("El password es (.*)")]
        public void GivenThePasswordIs(string password)
        {
            _password = password;
        }

        [When("se valida el login")]
        public void WhenTheUserAreLoggin()
        {
            _result = _login.Auth(new Api.Models.LoginDto { user = _user, password = _password });            
        }

        [Then("el resultado debe ser (.*)")]
        public void ThenTheResultShouldBe(bool result)
        {
            _result.Should().Be(result);
        }
    }
}
