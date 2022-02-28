using System;
using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using static FuturioHomework.Index;

namespace FuturioHomework.Tests
{
  public class TestsCommandMoveStart
  {
    [Test]
    public void Test_Execute()
    {
      var uobject   = new UObject();
      var velocity  = 2;
      var queue     = new List<ICommand>();
      var mockQueue = new Mock<IQueueCommands>();

      CommandMove commandInQueue = new CommandMove(new Mock<IMovable>().Object);
      mockQueue.Setup(d => d.Add(It.IsAny<ICommand>())).Callback(() => queue.Add(commandInQueue));

      var mock = Mock.Of<ICommandMoveStartable>(d => d.UObject == uobject && d.Velocity == velocity && d.Queue == mockQueue.Object);

      var command = new CommandMoveStart(mock);
      command.Execute();
      
      Assert.AreEqual(uobject[k_Velocity], velocity);
      Assert.AreEqual(queue.Count,   1);
      Assert.Contains(commandInQueue, queue);
    }

    [Test]
    public void Test_InvalidGetUObject_ThrowException()
    {
      var mockAdapter = new Mock<ICommandMoveStartable>();
      mockAdapter.SetupGet(d => d.Queue).Returns(() => throw new Exception());
      
      var command = new CommandMoveStart(mockAdapter.Object);
      Assert.Catch(() => command.Execute());
    }

    [Test]
    public void Test_InvalidGetVelocity_ThrowException()
    {
      var mockAdapter = new Mock<ICommandMoveStartable>();
      mockAdapter.SetupGet(d => d.Velocity).Returns(() => throw new Exception());
      
      var command = new CommandMoveStart(mockAdapter.Object);
      Assert.Catch(() => command.Execute());
    }
    
    [Test]
    public void Test_InvalidGetQueue_ThrowException()
    {
      var mockAdapter = new Mock<ICommandMoveStartable>();
      mockAdapter.SetupGet(d => d.Queue).Returns(() => throw new Exception());
      
      var command = new CommandMoveStart(mockAdapter.Object);
      Assert.Catch(() => command.Execute());
    }
  }
}