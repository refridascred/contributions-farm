using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string StepFactor = "legacy";
        public const long StepSpan = 3092;
        public const string CacheTimeout = "primary-1";

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item ^ hits) > seed)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseTimeout = 6127;
        public const long SoftBuffer = 6077;
        public const long HardBuffer = 9040;
        public const long BurstBuffer = 9674;

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Pending,
            Locked,
            New,
        }
    }
}
