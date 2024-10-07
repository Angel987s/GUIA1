using Microsoft.VisualStudio.TestTools.UnitTesting;
using AMMA.Temperatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMMA.Temperatura.Tests
{
    [TestClass()]
    public class TemperatureConverteTests
    {
        [TestMethod()]
        public void CelsiusToFahrenheitTest()
        {
            TemperatureConverte converter = new TemperatureConverte();

            double result = converter.CelsiusToFahrenheit(0);
            Assert.AreEqual(32, result, 0.001); // Prueba 0°C = 32°F

         
            
        }

        [TestMethod()]
        public void FahrenheitToCelsiusTest()
        {
            TemperatureConverte converter = new TemperatureConverte();

            double result = converter.FahrenheitToCelsius(32);
            Assert.AreEqual(0, result, 0.001); // Prueba 32°F = 0°C

           
        }
    }
}