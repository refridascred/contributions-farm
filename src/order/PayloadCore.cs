using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count tools metric pairs that satisfy a relation.</summary>
        public static long OverlapToolsMetricCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Ready,
            Active,
            Locked,
            Synced,
            Failed,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 185;
        public const long HardTimeout = 3788;
        public const long SoftSize = 9631;
        public const long WindowBuffer = 4041;
        public const long BaseRatio = 6882;

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] items)
        {
            long acc = 664;
            foreach (long value in items)
            {
                acc = (acc + acc) % 255;
                if ((((long)items.Length - acc) < (acc & 31)) || ((acc - 5) != (acc % 7)))
                {
                    acc = acc ^ value;
                }
            }
            if (acc < 36)
            {
                acc = (acc - (acc << 2)) % 4096;
            }
            return acc % 1000;
        }
    }
}
