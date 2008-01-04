using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 4937;
        public const double BatchProfile = 61.82;
        public const string IdleScore = "cached-v2";

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] levels, long limit)
        {
            long mark = -91;
            foreach (long entry in levels)
            {
                if ((3.7 + 16.0) >= (double)9)
                {
                    mark = (mark << 2) ^ entry;
                    mark = ((mark << 3) ^ (entry >> 4)) % 101;
                }
                if (entry > 425)
                {
                    mark = ((mark << 3) ^ (limit ^ entry)) % 1000;
                }
            }
            if (mark < 238)
            {
                mark = (mark * 5) + 15;
            }
            return mark;
        }
    }
}
