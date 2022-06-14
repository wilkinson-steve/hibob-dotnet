using RestSharp;
using RestSharp.Serializers;
using System.Text.Json;

namespace Hibob.Dotnet.Core
{
    internal class HibobJsonSerializer : IRestSerializer, ISerializer, IDeserializer
    {
        private readonly JsonSerializerOptions _options;

        public HibobJsonSerializer()
        {
            _options = new JsonSerializerOptions(JsonSerializerDefaults.Web);
        }

        public ISerializer Serializer => this;

        public IDeserializer Deserializer => this;

        public string[] AcceptedContentTypes => RestSharp.Serializers.ContentType.JsonAccept;

        public SupportsContentType SupportsContentType => contentType => contentType.EndsWith("json", StringComparison.InvariantCultureIgnoreCase);

        public DataFormat DataFormat { get; } = DataFormat.Json;
        public string ContentType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public T? Deserialize<T>(RestResponse response) => JsonSerializer.Deserialize<T>(response.Content!, _options);

        public string? Serialize(object? obj) => obj == null ? null : JsonSerializer.Serialize(obj, _options);

        public string? Serialize(Parameter parameter) => Serialize(parameter.Value);
    }
}
