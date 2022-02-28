using System;
using System.Collections.Generic;
using Moq;
using NUnit.Framework;

namespace FuturioHomework.Tests
{
  public class TestsCommandMoveEnd
  {
    [Test]
    public void Test_Execute()
    {
      var uobject     = new UObject();
      var mockBridge  = new Mock<ICommandInjectable>();
      var mockAdapter = Mock.Of<ICommandMoveEndable>(d => d.UObject == uobject && d.Command == mockBridge.Object);
      var command     = new CommandMoveEnd(mockAdapter);
      command.Execute();
 
      mockBridge.Verify(d => d.Inject(It.IsAny<ICommand>()), Times.Once);
      object t;
      Assert.Catch(() => t = uobject[Index.k_Velocity]);
    }

    [Test]
    public void Test_InvalidGetUObject_ThrowException()
    {
      var mockAdapter = new Mock<ICommandMoveEndable>();
      mockAdapter.SetupGet(d => d.UObject).Returns(() => throw new Exception());

      var command = new CommandMoveEnd(mockAdapter.Object);
      Assert.Catch(() => command.Execute());
    }

    [Test]
    public void Test_InvalidGetCommand_ThrowException()
    {
      var mockAdapter = new Mock<ICommandMoveEndable>();
      mockAdapter.SetupGet(d => d.Command).Returns(() => throw new Exception());

      var command = new CommandMoveEnd(mockAdapter.Object);
      Assert.Catch(() => command.Execute());
    }
  }
}