using System;
using System.Collections.Generic;
using System.Numerics;
using Moq;
using NUnit.Framework;

namespace FuturioHomework.Tests
{
  public class TestsCommandMove
  {
    static object[] _values = new[]
    {
      new object[]
      {
        new Vector2(12, 5),
        new Vector2(-7, 3),
        new Vector2(5,  8),
      }
    };

    [TestCaseSource(nameof(_values))]
    public void Test_Execute(Vector2 position, Vector2 velocity, Vector2 expected)
    {
      var mock    = Mock.Of<IMovable>(d => d.Position == position && d.Velocity == velocity);
      var command = new CommandMove(mock);
      command.Execute();
      Assert.AreEqual(mock.Position, expected);
    }

    [Test]
    public void Test_InvalidGetPosition_ThrowException()
    {
      var mock    = new Mock<IMovable>();
      mock.SetupGet(ld => ld.Position).Returns(() => throw new Exception());
      var command = new CommandMove(mock.Object);
      Assert.Catch(() => command.Execute());
    }
    
    [Test]
    public void Test_InvalidGetVelocity_ThrowException()
    {
      var mock    = new Mock<IMovable>();
      mock.SetupGet(ld => ld.Velocity).Returns(() => throw new Exception());
      var command = new CommandMove(mock.Object);
      Assert.Catch(() => command.Execute());
    }    
    
    [Test]
    public void Test_InvalidSetPosition_ThrowException()
    {
      var mock    = new Mock<IMovable>();
      mock.SetupSet(ld => ld.Position).Callback(obj => throw new Exception());
      var command = new CommandMove(mock.Object);
      Assert.Catch(() => command.Execute());
    }
  }
}