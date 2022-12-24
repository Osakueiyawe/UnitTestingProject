using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace DemoProject.Tests
{
    [TestClass]
    public class SampleClassTests
    {
        [TestMethod]
        public async Task GetAverageTest()
        {
            Mock<INumerics> mock= new Mock<INumerics>();
            mock
                .Setup(x => x.AddNumbers(It.IsAny<int>(),It.IsAny<int>()))
                .ReturnsAsync(2);
            mock
                .Setup(x => x.SubtractNumbers(It.IsAny<int>(), It.IsAny<int>()))
                .ReturnsAsync(1);
            var sampleClass = new SampleClass(mock.Object);
            double res = await sampleClass.GetAverage(3, 4);
            Assert.AreEqual(1, res);
            mock.Verify(x => x.AddNumbers(It.IsAny<int>(), It.IsAny<int>()), Times.Once);
            mock.Verify(x => x.SubtractNumbers(It.IsAny<int>(), It.IsAny<int>()), Times.Once);
        }
    }
}