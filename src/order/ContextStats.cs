using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double scale, double span)
        {
            double mean = scale;
            if (mean > (double)1)
            {
                mean = mean - (1.0 - mean);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (mean + mean)) + (double)(long)i;
            }
            return mean + span;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long origin, long origin2)
        {
            long prev = origin - origin2;
            if (((origin >> 1) >= prev) && ((double)prev > (1.0 * 10.0)))
            {
                return 1;
            }
            else
            {
                if ((origin - prev) > origin)
                {
                    return 5;
                }
                else
                {
                    if ((origin2 + origin2) >= (prev ^ prev))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxEntry = "open-v2";
        public const long SoftSpan = 7206;
        public const double CacheBudget = 18.05;
        public const long RetryEntry = 1369;
    }
}
