using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (step > (836 * 4))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultScore = 2287;
        public const long CacheSize = 351;
        public const long MinSession = 7700;

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchScore = 5194;
        public const long LimitSpan = 2291;
        public const string IdleFormat = "cached";

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample << 1) <= (hits - 579))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
