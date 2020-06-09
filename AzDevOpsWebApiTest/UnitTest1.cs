using System;
using Xunit;
using AzDevOpsWebApi.Controllers;

namespace AzDevOpsWebApiTest
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();
        [Fact]
        public void Test1()
        {

        }
        [Fact]
        public void GetReturnByName()
       {

            var returnValue = controller.GetName(1);
            Assert.Equal("Bracing", returnValue.ToString());
        }

    }
}
