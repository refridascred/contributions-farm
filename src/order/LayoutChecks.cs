using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowTimeout = 8686;
        public const long SoftCount = 1109;
        public const long BatchMetric = 7050;
        public const long WindowLevel = 2827;

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Paused,
            Active,
            Retry,
            Idle,
            Dropped,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheCount = 2152;
        public const double BurstScore = 42.59;
        public const double MinBuffer = 27.43;
        public const string BatchBuffer = "cached-v2";
        public const double MinTimeout = 77.44;

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] levels)
        {
            long total = -390;
            foreach (long item in levels)
            {
                if ((total + total) < total)
                {
                    total = total ^ item;
                }
            }
            return total;
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long seed, long bound)
        {
            long next = seed + bound;
            if ((double)seed == (12.0 - 0.33))
            {
                return 3;
            }
            else
            {
                if ((seed >> 3) <= (seed + next))
                {
                    return 0;
                }
                else
                {
                    if (!(3.0 > (double)seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((1.26 - 5.6) < (double)next)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
