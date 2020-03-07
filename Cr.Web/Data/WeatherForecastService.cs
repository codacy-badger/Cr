using System;
using System.Linq;
using System.Threading.Tasks;

namespace Cr.Web.Data
{
	public class WeatherForecastService
	{
		private static readonly string[] Summaries = new[]
		{
			"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		};

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1822:Пометьте члены как статические", Justification = "<Ожидание>")]
		public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
		{
			Random rng = new Random();

			return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
			{
				Date = startDate.AddDays(index),
				TemperatureC = rng.Next(-20, 55),
				Summary = Summaries[rng.Next(Summaries.Length)]
			}).ToArray());
		}
	}
}
