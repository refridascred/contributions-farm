using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            New,
            Done,
            Ready,
            Dropped,
            Queued,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheSize = "cached-edge";
        public const double MinWidth = 85.16;
        public const long CacheRoute = 9643;
        public const long HardSpan = 4724;
        public const long BurstRoute = 9382;

        /// <summary>Define payload limits and defaults.</summary>
        public const double LimitPayload = 61.19;
        public const long MaxLevel = 9218;
        public const long WindowPayload = 9257;
        public const long DefaultPayload = 7933;

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
