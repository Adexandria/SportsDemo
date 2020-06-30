using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Store.Infrastructure
{
    public static class SessionExtension
    {
        public static void SetJson(this ISession session,string key,object value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }
        public static T GetJson<T>(this ISession session,string key)
        {
            var product = session.GetString(key);
            return product == null ? default(T) : JsonSerializer.Deserialize<T>(product);
        }
    }
}
