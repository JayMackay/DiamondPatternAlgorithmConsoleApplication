using NUnit.Framework;
using Moq;
using DiamondPatternAlgorithmConsoleApplication.Interfaces;
using DiamondPatternAlgorithmConsoleApplication.Services;

namespace DiamondPatternAlgorithmConsoleApplication.Tests
{
    public class Tests
    {
        private Mock<IDiamondPatternService> _mockDiamondPatternService;
        private DiamondPatternService _diamondPatternService;

        [SetUp]
        public void Setup()
        {
            // Initialize Moq mock and service instance
            _mockDiamondPatternService = new Mock<IDiamondPatternService>();
            _diamondPatternService = new DiamondPatternService();
        }

        [Test]
        public void TestBuildDiamond_A()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}
