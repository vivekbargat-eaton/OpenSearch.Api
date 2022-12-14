using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SpikeElasticSearch.Opensearch
{
    public partial class Response
    {
        [JsonProperty("Aggregations")]
        public Aggregations Aggregations { get; set; }

        [JsonProperty("Clusters")]
        public object Clusters { get; set; }

        [JsonProperty("HitsMetadata")]
        public HitsMetadata HitsMetadata { get; set; }

        [JsonProperty("NumberOfReducePhases")]
        public long NumberOfReducePhases { get; set; }

        [JsonProperty("Profile")]
        public object Profile { get; set; }

        [JsonProperty("ScrollId")]
        public object ScrollId { get; set; }

        [JsonProperty("Shards")]
        public Shards Shards { get; set; }

        [JsonProperty("Suggest")]
        public Aggregations Suggest { get; set; }

        [JsonProperty("TerminatedEarly")]
        public bool TerminatedEarly { get; set; }

        [JsonProperty("TimedOut")]
        public bool TimedOut { get; set; }

        [JsonProperty("Took")]
        public long Took { get; set; }

        [JsonProperty("ApiCall")]
        public ApiCall ApiCall { get; set; }
    }

    public partial class Aggregations
    {
    }

    public partial class ApiCall
    {
        [JsonProperty("AuditTrail")]
        public List<AuditTrail> AuditTrail { get; set; }

        [JsonProperty("ThreadPoolStats")]
        public object ThreadPoolStats { get; set; }

        [JsonProperty("TcpStats")]
        public object TcpStats { get; set; }

        [JsonProperty("DebugInformation")]
        public string DebugInformation { get; set; }

        [JsonProperty("DeprecationWarnings")]
        public List<object> DeprecationWarnings { get; set; }

        [JsonProperty("HttpMethod")]
        public long HttpMethod { get; set; }

        [JsonProperty("HttpStatusCode")]
        public long HttpStatusCode { get; set; }

        [JsonProperty("OriginalException")]
        public object OriginalException { get; set; }

        [JsonProperty("RequestBodyInBytes")]
        public object RequestBodyInBytes { get; set; }

        [JsonProperty("ResponseBodyInBytes")]
        public object ResponseBodyInBytes { get; set; }

        [JsonProperty("ResponseMimeType")]
        public string ResponseMimeType { get; set; }

        [JsonProperty("Success")]
        public bool Success { get; set; }

        [JsonProperty("SuccessOrKnownError")]
        public bool SuccessOrKnownError { get; set; }

        [JsonProperty("Uri")]
        public Uri Uri { get; set; }

        [JsonProperty("ConnectionConfiguration")]
        public Aggregations ConnectionConfiguration { get; set; }
    }

    public partial class AuditTrail
    {
        [JsonProperty("Event")]
        public long Event { get; set; }

        [JsonProperty("Node")]
        public Node Node { get; set; }

        [JsonProperty("Path")]
        public string Path { get; set; }

        [JsonProperty("Ended")]
        public DateTimeOffset Ended { get; set; }

        [JsonProperty("Started")]
        public DateTimeOffset Started { get; set; }

        [JsonProperty("Exception")]
        public object Exception { get; set; }
    }

    public partial class Node
    {
        [JsonProperty("ClientNode")]
        public bool ClientNode { get; set; }

        [JsonProperty("DeadUntil")]
        public DateTimeOffset DeadUntil { get; set; }

        [JsonProperty("FailedAttempts")]
        public long FailedAttempts { get; set; }

        [JsonProperty("HoldsData")]
        public bool HoldsData { get; set; }

        [JsonProperty("HttpEnabled")]
        public bool HttpEnabled { get; set; }

        [JsonProperty("Id")]
        public object Id { get; set; }

        [JsonProperty("IngestEnabled")]
        public bool IngestEnabled { get; set; }

        [JsonProperty("IsAlive")]
        public bool IsAlive { get; set; }

        [JsonProperty("IsResurrected")]
        public bool IsResurrected { get; set; }

        [JsonProperty("ClusterManagerEligible")]
        public bool ClusterManagerEligible { get; set; }

        [JsonProperty("MasterEligible")]
        public bool MasterEligible { get; set; }

        [JsonProperty("ClusterManagerOnlyNode")]
        public bool ClusterManagerOnlyNode { get; set; }

        [JsonProperty("MasterOnlyNode")]
        public bool MasterOnlyNode { get; set; }

        [JsonProperty("Name")]
        public object Name { get; set; }

        [JsonProperty("Settings")]
        public Aggregations Settings { get; set; }

        [JsonProperty("Uri")]
        public Uri Uri { get; set; }
    }

    public partial class HitsMetadata
    {
        [JsonProperty("Hits")]
        public List<Hit> Hits { get; set; }

        [JsonProperty("MaxScore")]
        public long MaxScore { get; set; }

        [JsonProperty("Total")]
        public Total Total { get; set; }
    }

    public partial class Hit
    {
        [JsonProperty("Explanation")]
        public object Explanation { get; set; }

        [JsonProperty("Fields")]
        public object Fields { get; set; }

        [JsonProperty("Highlight")]
        public Aggregations Highlight { get; set; }

        [JsonProperty("Id")]
        public string Id { get; set; }

        [JsonProperty("Index")]
        public string Index { get; set; }

        [JsonProperty("InnerHits")]
        public Aggregations InnerHits { get; set; }

        [JsonProperty("MatchedQueries")]
        public List<object> MatchedQueries { get; set; }

        [JsonProperty("Nested")]
        public object Nested { get; set; }

        [JsonProperty("PrimaryTerm")]
        public object PrimaryTerm { get; set; }

        [JsonProperty("Routing")]
        public object Routing { get; set; }

        [JsonProperty("Score")]
        public long Score { get; set; }

        [JsonProperty("SequenceNumber")]
        public object SequenceNumber { get; set; }

        [JsonProperty("Sorts")]
        public List<object> Sorts { get; set; }

        [JsonProperty("Source")]
        public Source Source { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Version")]
        public long Version { get; set; }
    }

    public partial class Source
    {
        [JsonProperty("@timestamp")]
        public DateTimeOffset Timestamp { get; set; }

        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("messageTemplate")]
        public string MessageTemplate { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("fields")]
        public Fields Fields { get; set; }

        [JsonProperty("renderings")]
        public Renderings Renderings { get; set; }
    }

    //public partial class Fields
    //{
    //    [JsonProperty("Event")]
    //    public object Event { get; set; }

    //    [JsonProperty("RequestMethod")]
    //    public string RequestMethod { get; set; }

    //    [JsonProperty("RequestPath")]
    //    public string RequestPath { get; set; }

    //    [JsonProperty("StatusCode")]
    //    public long StatusCode { get; set; }

    //    [JsonProperty("Elapsed")]
    //    public double Elapsed { get; set; }

    //    [JsonProperty("SourceContext")]
    //    public string SourceContext { get; set; }

    //    [JsonProperty("RequestId")]
    //    public string RequestId { get; set; }

    //    [JsonProperty("ConnectionId")]
    //    public string ConnectionId { get; set; }

    //    [JsonProperty("Environment")]
    //    public string Environment { get; set; }

    //    [JsonProperty("Application")]
    //    public string Application { get; set; }

    //    [JsonProperty("Version")]
    //    [JsonConverter(typeof(ParseStringConverter))]
    //    public long Version { get; set; }
    //}

    //public partial class Renderings
    //{
    //    [JsonProperty("Elapsed")]
    //    public List<Elapsed> Elapsed { get; set; }
    //}

    //public partial class Elapsed
    //{
    //    [JsonProperty("Format")]
    //    public string Format { get; set; }

    //    [JsonProperty("Rendering")]
    //    public string Rendering { get; set; }
    //}

    public partial class Total
    {
        [JsonProperty("Relation")]
        public long Relation { get; set; }

        [JsonProperty("Value")]
        public long Value { get; set; }
    }

    public partial class Shards
    {
        [JsonProperty("Failed")]
        public long Failed { get; set; }

        [JsonProperty("Failures")]
        public List<object> Failures { get; set; }

        [JsonProperty("Successful")]
        public long Successful { get; set; }

        [JsonProperty("Total")]
        public long Total { get; set; }
    }
}

