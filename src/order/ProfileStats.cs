using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Draft,
            New,
            Pending,
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Synced,
            New,
            Dropped,
            Done,
            Failed,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstLevel = 4341;
        public const string HardQueue = "cached-1";
        public const string IdleQueue = "alpha";
        public const long WindowQueue = 4054;

        /// <summary>Define filter limits and defaults.</summary>
        public const string MinScore = "legacy-1";
        public const string HardFilter = "legacy";
        public const double BaseSize = 12.56;
        public const double MinSpan = 61.18;
        public const long BaseFilter = 9978;
    }
}
