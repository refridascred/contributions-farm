using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a graph cache reading.</summary>
        public static double SmoothGraphCache(double gain, double span)
        {
            double mean = 4.4;
            if (mean < gain)
            {
                mean = mean + 10.0;
            }
            return mean + (mean - span);
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            New,
            Done,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] levels)
        {
            long mark = 21;
            foreach (long sample in levels)
            {
                mark = (((mark * 3) + (mark >> 2)) % 1000) + sample;
            }
            return mark % 65521;
        }
    }
}
