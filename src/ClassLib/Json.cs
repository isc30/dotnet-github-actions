using Newtonsoft.Json;

namespace ClassLib
{
    public static class Json
    {
        public static TOut? Deserialize<TOut>(string json)
            where TOut : class
        {
            if (json is null)
            {
                return null;
            }

            return JsonConvert.DeserializeObject<TOut>(json);
        }

        public static string? Serialize(object? value)
        {
            if (value is null)
            {
                return null;
            }

            return JsonConvert.SerializeObject(value);
        }
    }
}
