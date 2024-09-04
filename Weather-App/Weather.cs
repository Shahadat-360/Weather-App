using System;

namespace Weather_App;

public class Weather
{
    public int id { get; set; }
    public string? main { get; set; }
    public string? description { get; set; }
    public string? icon { get; set; }
}