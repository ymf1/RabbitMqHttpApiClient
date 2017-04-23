﻿using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.ConsoleApp.Models.DefinitionModel
{
    public class User
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("password_hash")]
        public string PasswordHash { get; set; }

        [JsonProperty("hashing_algorithm")]
        public string HashingAlgorithm { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }
    }

}
