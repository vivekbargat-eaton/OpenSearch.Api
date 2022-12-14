using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SpikeElasticSearch.Opensearch;

public partial class Document
{
    [JsonProperty("@timestamp")]
    public DateTimeOffset Timestamp { get; set; }

    [JsonProperty("level")]
    public string? Level { get; set; }

    [JsonProperty("messageTemplate")]
    public string? MessageTemplate { get; set; }

    [JsonProperty("message")]
    public string? Message { get; set; }

    [JsonProperty("fields")]
    public Fields? Fields { get; set; }

    [JsonProperty("renderings")]
    public Renderings? Renderings { get; set; }
}

public partial class Fields
{
    [JsonProperty("Event")]
    public object Event { get; set; }

    [JsonProperty("RequestMethod")]
    public string RequestMethod { get; set; }

    [JsonProperty("RequestPath")]
    public string RequestPath { get; set; }

    [JsonProperty("StatusCode")]
    public long StatusCode { get; set; }

    [JsonProperty("Elapsed")]
    public double Elapsed { get; set; }

    [JsonProperty("SourceContext")]
    public string SourceContext { get; set; }

    [JsonProperty("RequestId")]
    public string RequestId { get; set; }

    [JsonProperty("ConnectionId")]
    public string ConnectionId { get; set; }

    [JsonProperty("Environment")]
    public string Environment { get; set; }

    [JsonProperty("Application")]
    public string Application { get; set; }

    [JsonProperty("Version")]
   // [JsonConverter(typeof(ParseStringConverter))]
    public long Version { get; set; }
}

public partial class Renderings
{
    [JsonProperty("Elapsed")]
    public Elapsed[] Elapsed { get; set; }
}

public partial class Elapsed
{
    [JsonProperty("Format")]
    public string Format { get; set; }

    [JsonProperty("Rendering")]
    public string Rendering { get; set; }
}

