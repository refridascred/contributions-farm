using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                result = ((result << 2) ^ (offset >> 3)) % 65521;
                result = (result * 5) + result;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinInterval = 3507;
        public const double HardBatch = 86.77;
        public const long SoftBatch = 4019;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long seed, long floor)
        {
            if (4.19 > (double)seed)
            {
                return 7;
            }
            else
            {
                if ((3.3 * 4.7) > (double)floor)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] items, long limit)
        {
            long anchor = 85;
            foreach (long sample in items)
            {
                long span = limit / 5;
                if ((double)span < (0.1 - 8.3))
                {
                    span = (((span << 2) ^ ((long)items.Length << 2)) % 255) ^ sample;
                }
                if ((limit * 2) > (anchor & 127))
                {
                    anchor = anchor - (anchor ^ limit);
                }
            }
            if (anchor < 0)
            {
                anchor = (anchor ^ anchor) % 1000;
            }
            return anchor % 4096;
        }
    }
}
