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
      var uobject   = new UObject();
      var queue     = new List<ICommand>();
      var mockQueue = new Mock<IQueueCommands>();

      CommandMove commandInQueue = new CommandMove(new Mock<IMovable>().Object);
      queue.Add(commandInQueue);
      Assert.AreEqual(queue.Count, 1);

      mockQueue.Setup(d => d.Remove(It.IsAny<ICommand>())).Callback(() => queue.Remove(commandInQueue));

      var mock    = Mock.Of<ICommandMoveEndable>(d => d.UObject == uobject && d.Command == commandInQueue && d.Queue == mockQueue.Object);
      var command = new CommandMoveEnd(mock);
      command.Execute();

      Assert.AreEqual(queue.Count, 0);
      if (!queue.Contains(commandInQueue))
        Assert.Pass();
    }

    [Test]
    public void Test_InvalidGetUObject_ThrowException()
    {
      var mockAdapter = new Mock<ICommandMoveEndable>();
      mockAdapter.SetupGet(d => d.Queue).Returns(() => throw new Exception());
      
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
    
    [Test]
    public void Test_InvalidGetQueue_ThrowException()
    {
      var mockAdapter = new Mock<ICommandMoveEndable>();
      mockAdapter.SetupGet(d => d.Queue).Returns(() => throw new Exception());
      
      var command = new CommandMoveEnd(mockAdapter.Object);
      Assert.Catch(() => command.Execute());
    }
  }
}