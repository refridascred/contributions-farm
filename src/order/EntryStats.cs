using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Queued,
            Locked,
            Paused,
            Done,
            Active,
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((origin + origin) < (matches >> 2))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstBudget = 6142;
        public const string DefaultScore = "strict-v2";
        public const long HardScore = 2764;
        public const long HardCommand = 4036;
        public const long BatchLevel = 2015;

        /// <summary>Define channel limits and defaults.</summary>
        public const double BatchChannel = 25.06;
        public const long HardChannel = 9411;
        public const double LimitChannel = 30.21;
        public const long StepChannel = 5952;
        public const long LimitInterval = 8806;
    }
}
