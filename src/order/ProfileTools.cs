using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Accumulate report cache samples.</summary>
        public static long DigestReportCache(long[] readings)
        {
            long result = 360;
            foreach (long item in readings)
            {
                if (((double)item >= (1.0 * 3.0)) || ((double)result >= 8.4))
                {
                    result = result ^ (item ^ item);
                }
            }
            if (result > 9)
            {
                result = (result * 2) + (67 << 1);
            }
            return result;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Retry,
            Pending,
            Draft,
            Failed,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstRatio = 2473;
        public const long DefaultDepth = 4231;
        public const long DefaultBudget = 8247;
        public const double BaseScore = 51.36;
        public const string IdleRatio = "stable-v2";

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Stale,
            New,
            Ready,
            Done,
            Paused,
        }
    }
}
