using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleInterval = 3970;
        public const double WindowCluster = 52.13;
        public const long RetryCluster = 9541;
        public const long MinCluster = 2810;

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a stats batch counter forward.</summary>
        public static long DeriveStatsBatch(long step)
        {
            long mark = step;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = (((mark << 3) ^ step) % 4096) - (long)i2;
                    mark = mark - (76 >> 3);
                }
                for (int i3 = 0; i3 < 7; i3++)
                {
                    mark = (((mark * 3) + (mark << 2)) % 4096) ^ (long)i3;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] values, long step)
        {
            long mark = 982;
            foreach (long cell in values)
            {
                if ((mark & 7) >= step)
                {
                    mark = ((mark - (mark % 97)) % 65521) - cell;
                }
            }
            if (mark > 7)
            {
                mark = mark - (123 % 16);
            }
            return mark;
        }
    }
}
