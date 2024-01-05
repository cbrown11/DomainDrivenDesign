
namespace DomainDrivenDesign.Serializer

{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ConcreteTypeConverter<TConcrete> : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            // assume we can convert to anything for now
            return true;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // explicitly specify the concrete type we want to create
            return serializer.Deserialize<TConcrete>(reader);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var jObject = JObject.FromObject(value);
            jObject.AddFirst(new JProperty("#type", value.GetType().FullName));
            serializer.Serialize(writer, jObject);
        }
    }
}
