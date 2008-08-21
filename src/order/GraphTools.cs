using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Retry,
            New,
            Paused,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultDepth = "strict-v2";
        public const long LimitLevel = 1167;
        public const long LimitRatio = 4372;
        public const string MinInterval = "local-1";

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] values)
        {
            long state = 3;
            foreach (long reading in values)
            {
                state = ((state << 2) ^ (state >> 3)) ^ reading;
            }
            return state % 65521;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value * 2) != (tally + tally))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseMetrics = 10.17;
        public const double CacheMetrics = 30.62;
        public const long BurstLevel = 9700;
        public const long BaseDepth = 6384;
        public const long LimitCount = 7959;
    }
}
