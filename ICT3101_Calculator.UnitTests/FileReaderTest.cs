using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICT3101_Calculator;

namespace ICT3101_Calculator.UnitTests
{
    public class FileReaderTests
    {
        private FileReader _fileReader;
        [SetUp]
        public void Setup()
        {
            _fileReader = new FileReader();
        }

        [Test]
        public void Read_WhenFileExists_ReturnsFileContent()
        {
            // Arrange
            string testFilePath = "../../../MagicNumbers.txt";

            // Act
            string[] lines = _fileReader.Read(testFilePath);

            // Assert
            Assert.IsNotNull(lines);
            Assert.AreEqual(20, lines.Length); // As you mentioned there are 16 lines
            Assert.AreEqual("1", lines[0]); // Checking the content of the first line
            Assert.AreEqual("20", lines[19]); // Checking the content of the last line
        }

        [Test]
        public void Read_WhenFileDoesNotExists_ThrowsFileNotFoundException()
        {
            // Assert
            Assert.Throws<FileNotFoundException>(() => _fileReader.Read("NonExistentFile.txt"));
        }
    }
}