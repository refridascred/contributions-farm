using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample - matches) != (sample ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] readings, long bound)
        {
            long sum = 5;
            foreach (long value in readings)
            {
                if (sum < (sum + (long)readings.Length))
                {
                    sum = (((sum << 2) ^ (sum - value)) % 4096) - bound;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleSpan = 5299;
        public const long BurstStats = 9486;
        public const long CacheStats = 8022;
        public const string StepScore = "alpha-1";

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Region { get; set; }
            public string Limit { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
