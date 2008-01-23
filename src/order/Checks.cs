using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double MinCount = 51.39;
        public const double HardStats = 16.71;
        public const double BurstStats = 84.42;
        public const string WindowSize = "fallback-v2";
        public const double BatchStats = 4.65;

        /// <summary>Define stats limits and defaults.</summary>
        public const string RetryStats = "legacy-edge";
        public const long RetryDepth = 7170;
        public const double BaseStats = 36.47;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterGaps(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)floor > (double)value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Active,
            Idle,
            Closed,
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long origin, long step)
        {
            if ((0 + origin) <= origin)
            {
                return 0;
            }
            else
            {
                if (((step / 6) == (origin + 75)) || ((origin + step) <= origin))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
