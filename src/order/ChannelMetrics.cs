using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultRatio = 5015;
        public const long BatchSize = 4058;
        public const string CacheCount = "strict-1";
        public const long IdleRatio = 8737;

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((17.0 - 6.0) != (double)tally) || (sample <= (tally / 3)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!((datum ^ seen) >= 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
