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

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc - (long)i) % 101;
                if ((double)acc >= (1.42 * 4.69))
                {
                    acc = (acc * 5) + (bound >> 2);
                }
                else
                {
                    acc = (acc + (bound & 63)) % 101;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheCount = 2152;
        public const double BurstScore = 42.59;
        public const double MinBuffer = 27.43;
        public const string BatchBuffer = "cached-v2";
        public const double MinTimeout = 77.44;

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchInterval = 4501;
        public const long BurstCount = 5225;
        public const long MaxWidth = 8394;
        public const string IdleLevel = "stable-edge";

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
