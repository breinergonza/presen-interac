using FluentAssertions;
using PresInteractivas.Api.BL;
using PresInteractivas.Api.Models;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace PresInteractivas.Test.Steps
{
    [Binding]
    public sealed class UsersStepDefinitions
    {

        private readonly ScenarioContext _scenarioContext;
        private readonly RegisterBL _reg;
        private string _nombres;
        private string _apellidos;
        private DateTime _fechaNacimiento;
        private int _social;
        private bool _result;

        public UsersStepDefinitions(ScenarioContext scenarioContext, RegisterBL reg)
        {
            _scenarioContext = scenarioContext;
            _reg = reg;
        }

        [Given("El nombre del usuario es (.*)")]
        public void GivenTheFirstName(string nombres)
        {
            _nombres = nombres;
        }

        [Given("El apellido es (.*)")]
        public void GivenTheLastName(string apellidos)
        {
            _apellidos = apellidos;
        }

        [Given("la fecha de nacimiento es (.*)")]
        public void GivenDate(string nacimiento)
        {
            _fechaNacimiento = Convert.ToDateTime(nacimiento);
        }

        [Given("el tipo de red social a registrar (.*)")]
        public void GivenTheSocialNet(int social)
        {
            _social = social;
        }

        [When("se valida el registro")]
        public void WhenTheUserAreLogginAsync()
        {
            var resp = _reg.AddUser(new UserDto() 
            {
                nombres = _nombres,
                apellidos = _apellidos,
                fechaNacimiento = _fechaNacimiento,
                idRedSocial = _social                
            });

            _result = resp != null;
        }

        [Then("el resultado debe ser (.*)")]
        public void ThenTheResultShouldBe(bool result)
        {
            _result.Should().Be(result);
        }
    }
}
