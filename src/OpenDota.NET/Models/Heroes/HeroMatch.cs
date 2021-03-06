﻿namespace OpenDotaDotNet.Models.Heroes
{
    using System.Text.Json.Serialization;

    public class HeroMatch
    {
        /// <summary>
        /// Gets or sets ID used to identify individual matches, e.g. 3703866531.
        /// </summary>
        [JsonPropertyName("match_id")]
        public long MatchId { get; set; }

        /// <summary>
        /// Gets or sets Unix timestamp of when the match began.
        /// </summary>
        [JsonPropertyName("start_time")]
        public long StartTime { get; set; }

        /// <summary>
        /// Gets or sets length of the match.
        /// </summary>
        [JsonPropertyName("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not the Radiant won the match.
        /// </summary>
        [JsonPropertyName("radiant_win")]
        public bool RadiantWin { get; set; }

        /// <summary>
        /// Gets or sets identifier for the league the match took place in.
        /// </summary>
        [JsonPropertyName("leagueid")]
        public long LeagueId { get; set; }

        /// <summary>
        /// Gets or sets name of league the match took place in.
        /// </summary>
        [JsonPropertyName("league_name")]
        public string LeagueName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the team/player/hero was on Radiant.
        /// </summary>
        [JsonPropertyName("radiant")]
        public bool Radiant { get; set; }

        /// <summary>
        /// Gets or sets the slot in which the hero/player was.
        /// </summary>
        [JsonPropertyName("player_slot")]
        public long PlayerSlot { get; set; }

        /// <summary>
        /// Gets or sets account id of the player playing the hero.
        /// </summary>
        [JsonPropertyName("account_id")]
        public long AccountId { get; set; }

        /// <summary>
        /// Gets or sets number of kills the hero had.
        /// </summary>
        [JsonPropertyName("kills")]
        public long Kills { get; set; }

        /// <summary>
        /// Gets or sets number of deaths the hero had.
        /// </summary>
        [JsonPropertyName("deaths")]
        public long Deaths { get; set; }

        /// <summary>
        /// Gets or sets number of assists the hero had.
        /// </summary>
        [JsonPropertyName("assists")]
        public long Assists { get; set; }
    }
}
