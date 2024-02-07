using Moq;
using N5Challenge.WebApi.Controllers;
using MediatR;
using N5Challenge.WebApi.Services.DataContracts.Response;
using N5Challenge.WebApi.Services.Queries;
using N5Challenge.WebApi.Services.Commands;

namespace N5Challenge.WebApi.Tests.Controllers
{
    public class PermissionControllerTests
    {
        [Fact]
        public void GetAll_ReturnsValidResponse()
        {
            // Arrange
            var mediatorMock = new Mock<IMediator>();
            var controller = new PermissionController(mediatorMock.Object);
            var expectedResult = new GetPermissionsResponse(); // Set your expected result here

            mediatorMock.Setup(x => x.Send(It.IsAny<GetPermissionsQuery>(), default))
                        .ReturnsAsync(expectedResult);

            // Act
            var result = controller.GetAll();

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Create_ReturnsValidResponse()
        {
            // Arrange
            var mediatorMock = new Mock<IMediator>();
            var controller = new PermissionController(mediatorMock.Object);
            var command = new CreatePermissionCommand(It.IsAny<string>(), It.IsAny<string>(),
                It.IsAny<DateTime>(), It.IsAny<string>());
            var expectedResult = new CreatePermissionResponse(); // Set your expected result here

            mediatorMock.Setup(x => x.Send(command, default))
                        .ReturnsAsync(expectedResult);

            // Act
            var result = controller.Create(command);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Update_ReturnsValidResponse()
        {
            // Arrange
            var mediatorMock = new Mock<IMediator>();
            var controller = new PermissionController(mediatorMock.Object);
            var command = new UpdatePermissionCommand(It.IsAny<int>(), It.IsAny<string>(), It.IsAny<string>(), 
                It.IsAny<DateTime>(), It.IsAny<string>());
            var expectedResult = new UpdatePermissionResponse(); // Set your expected result here

            mediatorMock.Setup(x => x.Send(command, default))
                        .ReturnsAsync(expectedResult);

            // Act
            var result = controller.Update(command);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}