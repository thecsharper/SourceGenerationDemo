using System.Text.Json.Serialization;

[JsonSourceGenerationOptions(WriteIndented = true, DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                             PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase)]
[JsonSerializable(typeof(TestRecord))]
public partial class TestRecordSerializationContext : JsonSerializerContext { }
