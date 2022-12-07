using Newtonsoft.Json;
using System;
using UnityEngine;

namespace Mo.HTTPClient
{
    public class JsonSerializationOption : ISerializationOption
    {
        public string ContentType => "application/json";

        public T Deserialize<T>(string text)
        {
            var result = JsonConvert.DeserializeObject<T>(text);
            return result;
        }

        public string Serialize<T>(T model)
        {
            var result = JsonConvert.SerializeObject(model);
            return result;
        }
    }
}