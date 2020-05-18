using NUnit.Framework;
using SimpleApplicationWithTest;

namespace SimpleApplicationWithTestTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            WeatherForecast weatherForecast = new WeatherForecast();
            weatherForecast.TemperatureC = 0;
            Assert.AreEqual(32, weatherForecast.TemperatureF);
            Assert.Pass();
        }
    }
}