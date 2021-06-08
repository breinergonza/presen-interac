using FluentAssertions;
using PresInteractivas.Api.BL;
using PresInteractivas.Api.Models;
using System;
using TechTalk.SpecFlow;

namespace PresInteractivas.Test.Steps
{
    [Binding]
    public sealed class PresentationsStepDefinitions
    {

        private readonly ScenarioContext _scenarioContext;
        private readonly WebPresentationBL _pre;
        private string _nombre;
        private int _usuario;
        private DateTime _fechaCreacion;
        private bool _result;

        public PresentationsStepDefinitions(ScenarioContext scenarioContext, WebPresentationBL pre)
        {
            _scenarioContext = scenarioContext;
            _pre = pre;
        }

        [Given("el nombre de la presentacion es (.*)")]
        public void GivenTheName(string nombre)
        {
            _nombre = nombre;
        }

        [Given("el usuario es el (.*)")]
        public void GivenTheUserId(int iduser)
        {
            _usuario = iduser;
        }
        
        [When("cuando la presentacion es creada")]
        public void WhenThePresentacionAdd()
        {
            var addUser = _pre.AddPresentation(new PresentacionDto()
            {
                name = _nombre,
                userCreates = _usuario,
                dateCreation = DateTime.Now
            });

            _result = addUser != null;
        }

        [Then("la respuesta debe ser (.*)")]
        public void ThenTheResultShouldBe(bool result)
        {
            _result.Should().Be(result);
        }
    }
}
