using NUnit.Framework;
using DiamondPatternAlgorithmConsoleApplication.Interfaces;
using Moq;
using DiamondPatternAlgorithmConsoleApplication.Services;
using System.IO;
using System;

namespace DiamondPatternAlgorithmConsoleApplication.Tests
{
    public class DiamondPatternServiceTests
    {
        private Mock<IDiamondPatternService> _mockDiamondPatternService;
        private DiamondPatternService _diamondPatternService;
        private StringWriter _consoleOutput;

        [SetUp]
        public void Setup()
        {
            // Initialize mock for IDiamondPatternService
            _mockDiamondPatternService = new Mock<IDiamondPatternService>();

            // Initialize DiamondPatternService
            _diamondPatternService = new DiamondPatternService();

            // Console output initialization
            _consoleOutput = new StringWriter();
            Console.SetOut(_consoleOutput);
        }

        // Example test case demonstrating the usage of mocking for IDiamondPatternService interface
        // In this instance, mocking is unnecessary for DiamondPatternService since it does not have external dependencies
        // Mocking would be beneficial if DiamondPatternService depended on other services/interfaces to isolate their behavior
        [Test]
        public void BuildDiamond_Returns_Pattern_For_A()
        {
            // Arrange
            char inputCharacter = 'A';
            string expectedPattern = "A\n";

            _mockDiamondPatternService.Setup(service => service.BuildDiamond(inputCharacter))
                .Returns(expectedPattern);

            // Act
            string generatedPattern = _diamondPatternService.BuildDiamond(inputCharacter);

            // Assert
            Assert.AreEqual(expectedPattern, generatedPattern);
        }

        [Test]
        public void BuildDiamond_Returns_Pattern_For_C()
        {
            // Arrange
            char inputCharacter = 'C';

            string expectedPattern =
                "  A  \n" +
                " B B \n" +
                "C   C\n" +
                " B B \n" +
                "  A  \n";

            // Act
            string generatedPattern = _diamondPatternService.BuildDiamond(inputCharacter);

            // Assert
            Assert.AreEqual(expectedPattern, generatedPattern);
        }

        [Test]
        public void BuildDiamond_Returns_Error_Message_For_Invalid_Input()
        {
            // Arrange
            char invalidCharacter = '1';
            string expectedErrorMessage = "Please only input a single valid character from the alphabet.";

            // Act & Assert
            var ex = Assert.Throws<ArgumentException>(() => _diamondPatternService.BuildDiamond(invalidCharacter));

            // Check if the exception message matches the expected message
            Assert.AreEqual(expectedErrorMessage, ex.Message);
        }

        [TearDown]
        public void Cleanup()
        {
            // Clean up StringWriter
            _consoleOutput.Dispose();
        }
    }
}