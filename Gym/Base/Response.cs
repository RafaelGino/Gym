using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.Net;
namespace Gym.Base
{
    public class Response<TData> : StatusCodeResult
    {
        public bool Success { get; set; }
        public TData Data { get; set; }
        public IEnumerable<string> Messages { get; set; }

        public Response(TData data, bool success, HttpStatusCode statusCode)
            : base((int)statusCode)
        {
            this.Data = data;
            this.Success = success;
        }

        public Response(TData data, bool success, HttpStatusCode statusCode, IEnumerable<string> messages)
            : this(data, success, statusCode)
        {
            this.Messages = messages;
        }

        public override string ToString()
        {
            var contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };

            return JsonConvert.SerializeObject(this, new JsonSerializerSettings
            {
                ContractResolver = contractResolver,
                Formatting = Formatting.Indented
            });
        }
    }
}
