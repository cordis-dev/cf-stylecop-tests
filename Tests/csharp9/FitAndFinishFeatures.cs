using System;
using System.Collections.Generic;

namespace Tests.csharp9
{
    public class FitAndFinishFeatures
    {
        // you can omit the type in a new expression when the created object's type is already known
        private List<WeatherObservation> _observations = new();

        public WeatherForecast ForecastFor(DateTime forecastDate, WeatherForecastOptions options)
        {
            return new WeatherForecast();
        }

        public void Test()
        {
            var forecast = ForecastFor(DateTime.Now.AddDays(2), new());

            //combine it with init only properties to initialize a new object:
            WeatherStation station = new() { Location = "Seattle, WA" };
        }
    }

    public class WeatherStation
    {
        public string Location { get; set; }
    }

    public class WeatherForecastOptions
    {
    }

    public class WeatherForecast
    {
    }
}