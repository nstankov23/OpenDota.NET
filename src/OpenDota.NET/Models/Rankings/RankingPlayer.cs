﻿namespace OpenDotaDotNet.Models.Rankings
{
    using System;
    using System.Text.Json.Serialization;

    public class RankingPlayer
    {
        [JsonPropertyName("account_id")]
        public long AccountId { get; set; }

        [JsonPropertyName("score")]
        public double Score { get; set; }

        [JsonPropertyName("personaname")]
        public string Personaname { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("avatar")]
        public Uri Avatar { get; set; }

        [JsonPropertyName("last_login")]
        public DateTimeOffset? LastLogin { get; set; }

        [JsonPropertyName("rank_tier")]
        public int? RankTier { get; set; }
    }
}
