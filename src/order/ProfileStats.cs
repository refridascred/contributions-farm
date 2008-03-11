using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 6884;
        public const long HardSize = 6034;
        public const long BatchChecks = 7317;
        public const long HardInterval = 1141;

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Queued,
            Closed,
            Dropped,
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Total { get; set; }
            public double Owner { get; set; }
            public bool Limit { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
