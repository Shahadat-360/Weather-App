using Weather_App;
using Newtonsoft.Json;

while(true)
{
    Console.Write("Please Enter City Name: ");
    string city = Console.ReadLine();
    ApiHelper apiHelper = new ApiHelper(city);
    try
    {
        string json = apiHelper.GetWeatherData();
        WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(json);
        Console.WriteLine($"Temperature: {(weatherData.main.temp_max - 273.0):N2} \u00B0C");
        Console.WriteLine("Press Ctrl + C to exit");
    }
    catch{
        Console.WriteLine("Not Found.Please Try Again With Right Name");
        continue;
    }
}