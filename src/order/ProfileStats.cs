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

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((double)value <= (9.77 - 4.2)))
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
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
