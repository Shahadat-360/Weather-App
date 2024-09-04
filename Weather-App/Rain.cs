using System;
using Newtonsoft.Json;

namespace Weather_App;

public class Rain
{
    [JsonProperty("1h")]
    public double _1h { get; set; }
}