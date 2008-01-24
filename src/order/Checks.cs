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

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long target, long floor)
        {
            if (((floor & 63) < (floor ^ floor)) || ((floor % 10) >= (floor + target)))
            {
                return 3;
            }
            else
            {
                if ((target + floor) != (27 ^ floor))
                {
                    return 2;
                }
                else
                {
                    if (!((5.3 + 7.7) < (double)floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
