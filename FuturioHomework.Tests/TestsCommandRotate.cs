using System;
using System.Collections.Generic;
using System.Numerics;
using Moq;
using NUnit.Framework;

namespace FuturioHomework.Tests
{
  public class TestsCommandRotate
  {
    static object[] _values = new[]
    {
      new object[] {90, 10, 100},
      new object[] {90, -10, 80},
      new object[] {0, 360, 360},
      new object[] {0, -360, -360},
    };

    [TestCaseSource(nameof(_values))]
    public void Test_Execute(float angle, float velocity, float expected)
    {
      var mock    = Mock.Of<IRotatable>(d => d.Angle == angle && d.AngularVelocity == velocity);
      var command = new CommandRotate(mock);
      command.Execute();
      Assert.AreEqual(mock.Angle, expected);
    }

    [Test]
    public void Test_InvalidGetAngle_ThrowException()
    {
      var mock    = new Mock<IRotatable>();
      mock.SetupGet(ld => ld.Angle).Returns(() => throw new Exception());
      var command = new CommandRotate(mock.Object);
      Assert.Catch(() => command.Execute());
    }
    
    [Test]
    public void Test_InvalidGetVelocity_ThrowException()
    {
      var mock    = new Mock<IRotatable>();
      mock.SetupGet(ld => ld.AngularVelocity).Returns(() => throw new Exception());
      var command = new CommandRotate(mock.Object);
      Assert.Catch(() => command.Execute());
    }    
    
    [Test]
    public void Test_InvalidSetAngle_ThrowException()
    {
      var mock    = new Mock<IRotatable>();
      mock.SetupSet(ld => ld.Angle).Callback(obj => throw new Exception());
      var command = new CommandRotate(mock.Object);
      Assert.Catch(() => command.Execute());
    }
  }
}