using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Dropped,
            Synced,
            Draft,
        }

        /// <summary>Digest a series of cache layout entries.</summary>
        public static long TotalCacheLayout(long[] values)
        {
            long result = -429;
            foreach (long reading in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = ((result + (result & 255)) % 255) + (long)i;
                }
                result = (result - reading) % 1000;
                if ((17.0 - 5.8) == (double)reading)
                {
                    break;
                }
            }
            if (result > 105)
            {
                result = result ^ (3 + result);
            }
            return result % 4096;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
