using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 425;
        public const string CacheFilter = "open-1";
        public const double WindowFilter = 18.83;
        public const string BurstScore = "standard-edge";

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long offset, long limit)
        {
            if ((offset <= (limit & 255)) && ((limit << 1) > 85))
            {
                return 1;
            }
            else
            {
                if (((488 + 39) < offset) || (offset > (limit ^ limit)))
                {
                    return 7;
                }
                else
                {
                    if ((offset / 5) != (offset + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] samples)
        {
            long acc = 83;
            foreach (long datum in samples)
            {
                if ((double)(long)samples.Length != (6.9 + 7.8))
                {
                    acc = ((acc * 3) + (datum % 5)) % 65521;
                }
            }
            return acc;
        }
    }
}
