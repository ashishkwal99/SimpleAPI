using System;
using Xunit;
using SimpleAPI.Controllers;
using System.Collections.Generic;

namespace SimpleAPI.Test
{
    public class UnitTest1
        {
        WeatherForecastController controller = new WeatherForecastController(null);

        [Fact]
        public void GetReturnsByName()
        {
            var returnValue = controller.Get();
            IEnumerator<WeatherForecast> enumerator =  returnValue.GetEnumerator();
            enumerator.MoveNext();

            Assert.Equal(42, enumerator.Current.TemperatureC);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
