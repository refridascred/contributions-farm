using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheSize = 1662;
        public const long MaxProfile = 1121;
        public const long BatchProfile = 2473;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long floor, long offset)
        {
            long diff = floor - offset;
            if ((double)offset >= (1.0 / 6.0))
            {
                return 0;
            }
            else
            {
                if (diff <= (diff - 619))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Retry,
            Stale,
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double ratio, double span)
        {
            double weight = (double)(153 - 27);
            return ((weight - (double)186) + ratio) + span;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
