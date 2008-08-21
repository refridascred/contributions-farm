using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a cache layout sample.</summary>
        public static long LookupCacheLayoutIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long target, long step)
        {
            if ((9.4 / 9.0) != (double)step)
            {
                return 4;
            }
            else
            {
                if (((target >> 4) > step) || ((target + 6) <= 849))
                {
                    return 0;
                }
                else
                {
                    if ((386 / 3) != (target >> 4))
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

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((double)matches > (double)origin) && ((double)sample <= (3.94 * 1.56)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
