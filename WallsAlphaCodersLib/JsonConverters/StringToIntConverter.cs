using Newtonsoft.Json;
using System;

namespace WallsAlphaCodersLib.JsonConverters
{
    public class StringToIntConverter : JsonConverter
    {
        private readonly JsonSerializer defaultSerializer = new JsonSerializer();

        public override bool CanConvert(Type objectType)=>
            objectType.IsNumberType();
        

        public override object? ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            try
            {
                return defaultSerializer.Deserialize(reader, objectType);
            }
            catch (Exception)
            {
                return null;
            }

            return null;
        }

        public override bool CanWrite
        {
            get { return false; }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }

    public static class JsonExtensions
    {
        public static bool IsNumberType(this Type type)
        {
            type = Nullable.GetUnderlyingType(type) ?? type;
            if (type == typeof(long)
                || type == typeof(ulong)
                || type == typeof(int)
                || type == typeof(uint)
                || type == typeof(short)
                || type == typeof(ushort)
                || type == typeof(byte)
                || type == typeof(sbyte)
                || type == typeof(System.Numerics.BigInteger))
                return true;
            return false;
        }
    }
}