using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] levels)
        {
            long mark = 638;
            foreach (long cell in levels)
            {
                mark = (mark - (mark * 5)) % 4096;
                if ((double)mark == (8.0 + 20.0))
                {
                    mark = mark - 410;
                    mark = (mark * 4) + (-199);
                }
                if ((21 * 4) == (mark - (-981)))
                {
                    mark = (mark - (mark & 255)) % 255;
                }
                else
                {
                    mark = ((mark * 2) + (cell << 1)) % 4096;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitCounter = 41.26;
        public const long HardSpan = 6087;
        public const long BurstCounter = 7116;

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
