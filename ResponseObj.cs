using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Stats data
    /// </summary>
    public class Stats
    {
        [JsonProperty("characters")]
        public int Characters { get; set; }

        [JsonProperty("dits")]
        public int Dits { get; set; }

        [JsonProperty("dahs")]
        public int Dahs { get; set; }

    }
    /// <summary>
    /// Audio data
    /// </summary>
    public class Audio
    {
        [JsonProperty("audioFile")]
        public string AudioFile { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("downloadURL")]
        public string DownloadURL { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("frequency")]
        public string Frequency { get; set; }

        [JsonProperty("sampleRate")]
        public string SampleRate { get; set; }

        [JsonProperty("expires")]
        public int Expires { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("morse")]
        public string Morse { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        [JsonProperty("valid")]
        public bool Valid { get; set; }

        [JsonProperty("audio")]
        public Audio Audio { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
