
using System;
using System.Linq;
using System.Threading.Tasks;

public class WeatherForeCastService
{
    public static readonly string[] Summaries = new[] {      /// new[] or new string[]
        "Frezzing", "Chilly","Bracing","Normal","Cool", "Warm", "Hot","Sweltering"
    };
    public WeatherForecast[] GetForeCastAsync(DateTime startdate)
    {
        var rng = new Random();
        var results = Enumerable.Range(start: 1, count: 10).Select(index => new WeatherForecast
        {
            Date = startdate.AddDays(index),
            TemperatureInF = rng.Next(minValue: -20, maxValue: 85),
            //   Summary = Summaries[rng.Next(Summaries.Length)]
        }).ToArray();
        
        /*
        /// Relational pattern matching enhacemements using switch statement.
        */
        foreach (var rec in results)
        {
            rec.Summary = rec.TemperatureInF switch   
            {
                < 0 => "Well Before Freezing",
                >= 85 => "Hot",
                >=0 and < 32 => "Freezing",
                32 or 212 => "Exactly Freezing or Boiling",
                _ => "Unknown"
            };
        }
        return results;
    }
}