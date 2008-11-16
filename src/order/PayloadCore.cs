using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] data, long step)
        {
            long mark = 252;
            foreach (long cell in data)
            {
                if (!((mark + mark) != (cell + 62)))
                {
                    mark = ((mark * 4) + (cell / 2)) % 1000;
                }
            }
            if (mark < 37)
            {
                mark = mark - step;
            }
            return mark % 65521;
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

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
