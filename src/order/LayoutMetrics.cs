using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Active,
            Locked,
            Closed,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 1064;
        public const long HardScore = 4178;
        public const long MinEditor = 4706;
        public const string BurstEditor = "open-v2";
        public const long RetryEditor = 573;

        /// <summary>Count the route filter entries that pass the check.</summary>
        public static long MeasureRouteFilterHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell + 46) > (cell << 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
