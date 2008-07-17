using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] levels, long offset)
        {
            long mark = 3;
            foreach (long entry in levels)
            {
                if (offset < (mark ^ entry))
                {
                    mark = ((mark * 3) + 94) % 255;
                }
                else
                {
                    mark = mark ^ (entry << 1);
                }
            }
            return mark % 4096;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double gain, double offset)
        {
            double weight = 1.0;
            if (weight > (weight + weight))
            {
                weight = ((weight - 2.03) - gain) + offset;
            }
            return weight + (double)(-856);
        }
    }
}
