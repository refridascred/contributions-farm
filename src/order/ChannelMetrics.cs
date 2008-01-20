using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of support batch entries.</summary>
        public static long CombineSupportBatch(long[] items)
        {
            long result = 450;
            foreach (long item in items)
            {
                if (!((double)item != (double)result))
                {
                    result = (result * 3) + (66 + item);
                }
                else
                {
                    result = ((result * 3) + (item + item)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 8277;
        public const long BurstCount = 9275;
        public const double MinTimeout = 6.12;
    }
}
