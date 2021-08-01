using FluentAssertions;
using HelloWorld.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace HeloWorld.Api.Tests
{
    public class HelloWorldControllerTests
    {
        [Fact]
        public void Index__ShouldReturnNonEmptyResponse()
        {
            // Arrange
            var controller = new HelloWorldController();

            // Act
            var result = controller.HelloWorld();

            // Assert
            result.Should().NotBeNull();
        }

        [Fact]
        public void Index__ShouldReturnOkResponse()
        {
            // Arrange
            var controller = new HelloWorldController();

            // Act
            var result = controller.HelloWorld();

            // Assert
            result.Should().BeOfType(typeof(OkObjectResult));
        }

        [Fact]
        public void Index__ShouldReturnExpectedStringResponse()
        {
            // Arrange
            var controller = new HelloWorldController();

            // Act
            var result = controller.HelloWorld();

            // Assert
            var okActionResult = result as OkObjectResult;
            okActionResult.Value.Should().Be("Hello World!");
        }
    }
}