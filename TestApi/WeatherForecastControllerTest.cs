using ApiDeMilhoes.Controllers;
using Xunit;

namespace TestApi
{
    public class WeatherForecastControllerTest
    {
        [Fact]
        public void DevFazerGetComSucesso()
        {
            var controller = new WeatherForecastController();

            var result = controller.Get();

            Assert.True(result.Count() > 0);
        }
    }
}