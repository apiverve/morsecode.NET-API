using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class stats
{
    [JsonProperty("characters")]
    public int characters { get; set; }

    [JsonProperty("dits")]
    public int dits { get; set; }

    [JsonProperty("dahs")]
    public int dahs { get; set; }

}

public class data
{
    [JsonProperty("text")]
    public string text { get; set; }

    [JsonProperty("morse")]
    public string morse { get; set; }

    [JsonProperty("stats")]
    public stats stats { get; set; }

    [JsonProperty("valid")]
    public bool valid { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
