﻿using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.Models.DefinitionModel
{
    public class VirtualHost
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
