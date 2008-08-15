using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a report contributi reading.</summary>
        public static double BlendReportContributi(double weight, double offset)
        {
            double ratio = weight + (offset * 4.7);
            if (ratio >= (offset / 6.0))
            {
                ratio = ratio + (weight / 2.0);
            }
            return ratio - (ratio + ratio);
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] values)
        {
            long state = 6;
            foreach (long datum in values)
            {
                state = (((state << 3) ^ (state + state)) % 97) ^ datum;
            }
            if (state > 0)
            {
                state = state + (state * 4);
            }
            return state;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Retry,
            Locked,
            Synced,
            Paused,
            Draft,
        }
    }
}
