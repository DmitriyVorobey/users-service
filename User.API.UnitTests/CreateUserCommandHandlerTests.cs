using AutoFixture;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Threading;
using System.Threading.Tasks;
using User.API.ServiceLayer.Commands;
using User.API.ServiceLayer.Handlers;

namespace User.API.UnitTests
{
    public class CreateUserHandlerTests
    {
        private CreateUserHandler _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new Fixture().Create<CreateUserHandler>();
        }

        [Test]
        public async Task Handle_CreateUserCommand_ReturnSuccessResult()
        {
            // Arrange
            var command = new CreateUserCommand()
            {
                DateOfBirth = DateTime.UtcNow,
                Email = "vasya@gmail.com",
                FirstName = "Vasya",
                LastName = "Antonovich"
            };

            // Act
            var result = await _sut.Handle(command, new CancellationToken());

            // Assert
            result.Result.Should().BeTrue();
        }
    }
}