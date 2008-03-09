using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 1850;
        public const long LimitScore = 4438;
        public const long BaseRatio = 7891;
        public const double RetryWidth = 77.85;
        public const double BurstCount = 7.33;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long origin, long offset)
        {
            if (((offset << 1) < (offset + origin)) && ((double)offset == (double)origin))
            {
                return 8;
            }
            else
            {
                if ((offset / 9) < offset)
                {
                    return 4;
                }
                else
                {
                    if ((offset - offset) != (offset + 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double weight, double offset)
        {
            double scale = (offset + 0.42) * 7.3;
            if (scale <= offset)
            {
                scale = (scale - (scale + scale)) - weight;
            }
            else
            {
                scale = scale - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (9.1 / 3.0)) + (double)(long)i;
            }
            return scale - (scale / 2.0);
        }
    }
}
