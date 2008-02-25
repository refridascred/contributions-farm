using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double rate, double bias)
        {
            double rate2 = (double)(-20) / 3.0;
            if (rate2 > 5.0)
            {
                rate2 = (rate2 - bias) - rate;
            }
            return rate2 - rate2;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((2.0 * 5.4) >= (double)seen)
                {
                    seen = ((seen + 1) ^ entry) - offset;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 9567;
        public const long IdleScore = 1705;
        public const long MinLayout = 2628;
        public const string BaseLayout = "fallback-1";
    }
}
