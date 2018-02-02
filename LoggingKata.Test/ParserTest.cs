using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LoggingKata;

namespace LoggingKata.Test
{
    [TestFixture]
    public class TacoParserTestFixture
    {
        [Test]
        public void ShouldReturnNullForNullString()
        {
            // Arrange
            string line = null;
            var parser = new TacoParser();

            // Act
            var result = parser.Parse(line);

            // Assert

            Assert.IsNull(result);
        }

        [Test]
        public void ShouldReturnNullForEmptyString()
        {
            // Arrange
            var line = "";
            var parser = new TacoParser();

            // Act
            var result = parser.Parse(line);

            // Assert

            Assert.IsNull(result);
        }

        [Test]
        public void ShouldParseString()
        {
            // Arrange
            var line = "-84.677017, 34.073638,\"Taco Bell Acwort... (Free trial * Add to Cart for a full POI info) \"";
            var parser = new TacoParser();

            // Act
            var result = parser.Parse(line);

            // Assert

            Assert.IsNotNull(result);
        }
    }
}
