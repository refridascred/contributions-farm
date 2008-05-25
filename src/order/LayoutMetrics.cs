using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up filter report samples.</summary>
        public static long OverlapFilterReportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long seed, long target)
        {
            long prev = seed ^ target;
            if ((seed - seed) <= (prev ^ (-117)))
            {
                return 6;
            }
            else
            {
                if (((seed + seed) < (target & 255)) && ((4.92 + 8.05) >= (double)prev))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
