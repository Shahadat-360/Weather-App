using System;

namespace Weather_App;

public class ApiHelper
{
    public string ApiUrl = "https://api.openweathermap.org/data/2.5/weather?q=pabna&appid=d85e986d235a2163fa54f8af9e3751a4";
    public HttpClient client {get;set;}
    public ApiHelper()
    {
        client = new HttpClient();
        client.BaseAddress = new Uri(ApiUrl);
    }
    public string GetWeatherData()
    {
        return client.GetStringAsync(ApiUrl).Result;
    }
}
